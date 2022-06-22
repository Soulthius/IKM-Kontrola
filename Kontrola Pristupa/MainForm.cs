using System;
using Kontrola_Pristupa.Forme;
using Kontrola_Pristupa.Clase;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO.Ports;
using System.Net.Sockets;
using Npgsql;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrola_Pristupa
{
    public partial class MainForm : Form
    {
        //Promjenljive koje se koriste u kodu

        bool RucnaDozvola;
        bool tabelaObrisana = false;
        int rbroj = 1;
        string prolaz;

        KorisnikData korisnik = new KorisnikData();
        NpgsqlConnection connect;
        SerialPort serialPortUlaz;
        SerialPort serialPortIzlaz;
        Komunikacija komunikacija;
        TcpClient tCPclient;
        NetworkStream stream;
        Timer timer;
        DateTime dateTime;
        TimeSpan timeSpan;

        //----------------------------------------------------------------------------------



        public MainForm()
        {
            InitializeComponent();
            initTimer();
            obrisiEvidenciju();
            

        }
        //G-{Naziv} - Za lakse pretrazivanje sa ctrl-f

        //G_Timer: Inicijalizacija tajmera
        private void initTimer(){
            
          timer = new Timer();
          timer.Interval = 1000;
          timer.Tick += Sec_Inc;
          timer.Start();

        }

        //G_Timer: Inicijalizacija portova: TCP i rs232
        private void initSerialPorts()
        {


            tCPclient = new TcpClient();
            tCPclient.Connect(komunikacija.IP, int.Parse(komunikacija.Port));
            stream = tCPclient.GetStream();
            print2list("Connected to TCP Server");

            serialPortUlaz = new SerialPort(komunikacija.PortUlaz);
            serialPortUlaz.Open();
            serialPortIzlaz = new SerialPort(komunikacija.PortIzlaz);
            serialPortIzlaz.Open();
            print2list("Opened ports");
            serialPortUlaz.DataReceived += SerialPort_DataReceivedUlaz;
            serialPortIzlaz.DataReceived += SerialPort_DataReceivedIzlaz;

        }

        //G_dodaj: dodaje nove korisnike u tabelu

        private void button1_Click(object sender, EventArgs e)
        {
            connect = connection();
            dodajKorisnika noviKorisnik = new dodajKorisnika();
            if (noviKorisnik.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    connect.Open();
                    string naredba = $"INSERT INTO public.korisnici(ime, id, tip, prezime, datum) VALUES ('{noviKorisnik.Ime}','{noviKorisnik.Id}','{noviKorisnik.Tip}','{noviKorisnik.Prezime}','{noviKorisnik.DateTime}')";
                    NpgsqlCommand Command = new NpgsqlCommand(naredba, connect);
                    int br = Command.ExecuteNonQuery();

                    if (br > 0)
                    {
                        print2list($"Korisnik ID: {noviKorisnik.Id} je  dodat");
                    }
                    else
                    {
                        print2list("Nije dodat");
                    }

                }
                catch (Exception ex)
                {
                    print2list(ex.Message);
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connect.Close();
                    connect.Dispose();
                }

            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //G_exit: zatvara aplikaciju
        private void btnExit_Click(object sender, EventArgs e)
        {
            closeApplication();
        }

        private static void closeApplication()
        {

            exitComf exitComf = new exitComf();
            if (exitComf.ShowDialog() == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //G_Npgsql konektuje se na bazu 
        private static NpgsqlConnection connection()
        {
            return new NpgsqlConnection(@"Host = localhost; Port = 5432; User Id = postgres; Password = 1234; Database = kontrola;");
        }

        //G_login: poziva formu frmLogin i provjerava da li je dobar login, 
        //Hide button i admin button sluzi za prikaz button u zavisnosti od uloge
        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog(); 
            mainPrikaz(frmLogin.NivoPristupa);
            

        }

        private void mainPrikaz(int nivo)
        {
            
            hideButtons();

            if (nivo == 1)
            {
                adminButtons();
            }
            else if (nivo == 0)
            {
                hideButtons();
            }
            else 
            {
                Application.Restart();
            }

        }

        private void hideButtons()
        {
            glavniPanel.Visible = true;
            btnLogin.Visible = false;
            btnLogin.Enabled = false;
            btnExit.Enabled = false;
            btnExit.Visible = false;
            txtNivoKorisnika.Text = "KORISNIK";
            btnDodaj.Enabled = false;
            btnIzmjeni.Enabled = false;
        }

        private void adminButtons()
        {
            btnDodaj.Enabled = true;
            btnDozvola.Enabled = true;
            btnIzmjeni.Enabled = true;
            btnObrisi.Enabled = true;
            txtNivoKorisnika.Text = "ADMIN";
        }

        //G_print2list: printa podatke na listu
        private void print2list(string poruka)
        {

            
            if (listView.InvokeRequired)
            {
                listView.Invoke((MethodInvoker)(() =>
                {
                    listView.Items.Add(poruka);
                }));
            }
            else
            {
                listView.Items.Add(poruka);
            }


        }

        
        //G_kraj: zatvara aplikaciju
        private void btnKraj_Click(object sender, EventArgs e)
        {
            closeApplication();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //G_obrisi: brise korisnike iz tabele korisnici
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            connect = connection();
            Obrisi obrisi = new Obrisi();
            if (obrisi.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    connect.Open();
                    string naredba = $"DELETE FROM public.korisnici WHERE id = {obrisi.Id}";
                    NpgsqlCommand command = new NpgsqlCommand(naredba, connect);
                    int br = command.ExecuteNonQuery();
                    if (br > 0)
                    {
                        print2list($"Korisnk {obrisi.Ime} {obrisi.Prezime}, sa ID:{obrisi.Id} je obrisan");
                    }
                    else
                    {
                        print2list($"Korisnik nije obrisan");
                    }



                }
                catch (Exception ex)
                {
                    print2list(ex.Message);
                }
                finally 
                {
                    connect.Close();
                    connect.Dispose();
                }
            }
        }
        //G_izmjeni: mjenja izabrani podatak, izabranog korisnika iz tabele korisnici
        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            connect = connection();
            Izmjeni izmjeni = new Izmjeni();
            izmjeni.ShowDialog();
                try
                {
                    connect.Open();
                    string naredba = $"UPDATE public.korisnici SET ime ='{izmjeni.Ime}', id ='{izmjeni.ID}',tip = '{izmjeni.Tip}',datum='{izmjeni.Datum}' WHERE id = '{izmjeni.ID}'";
                    NpgsqlCommand command = new NpgsqlCommand(naredba, connect);
                    int br = command.ExecuteNonQuery();
                    if (br > 0)
                    {
                        print2list($"Korisnk {izmjeni.Name} sa ID:{izmjeni.ID} je promjenjen");
                    }
                    else
                    {
                        print2list($"Korisnik nije promjenjen");
                    }



                }
                catch (Exception ex)
                {
                    print2list(ex.Message);
                }
                finally
                {
                    connect.Close();
                    connect.Dispose();
                }
            
        }
        //G_logout: logout iz programa
        private void btnLogout_Click(object sender, EventArgs e)
        {
            exitComf exitComf = new exitComf();
            if (exitComf.ShowDialog() == DialogResult.Yes)
            {
                Application.Restart();
            }
            
        }
        //G_prikaz: sluzi za prikaz svih clanova tabele korisnici
        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            connect = connection();
            clearList();
            

            try
            {
                connect.Open();
                string naredba = $"select * FROM public.korisnici";
                NpgsqlCommand Command = new NpgsqlCommand(naredba, connect);
                NpgsqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    string ime1 = reader.GetString(0);
                    string prezime1 = reader.GetString(3);
                    DateTime datum1 = reader.GetDateTime(4);
                    int id1 = reader.GetInt32(1);
                    string tip1 = reader.GetString(2);
                    print2list($"Ime: {ime1} | Prezime: {prezime1} | ID: {id1.ToString()} | Datum: {datum1.ToString("yyyy-MM-dd")} | Tip: {tip1}");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connect.Close();
                connect.Dispose();
            }

        }
        //G_obrisiListu: brise sve podatke koji se nalaze na listi
        private void btnObrisiListu_Click(object sender, EventArgs e)
        {
            clearList();
        }

        private void clearList()
        {

            listView.Items.Clear();
        }
        //G_citac: button za konekciju na portove
        private void btnCitac_Click(object sender, EventArgs e)
        {
            try
            {
                komunikacija = new Komunikacija();
                if (komunikacija.ShowDialog() == DialogResult.OK) { 
                    initSerialPorts();
                }
                
                

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }


        }

        //G_DataReciveUlaz: Ceka dok dodje nesta na ulazni buffer 
        private void SerialPort_DataReceivedUlaz(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPortUlaz.ReadExisting();
            int id = int.Parse(data);
            if (korisnik.korisnikPostoji(id))
            {
                prolaz = "Ulaz";
                if (data != null)
                {
                    if ((!korisnik.prviProlaz(id) || (korisnik.korisnikProlaz(id) == "Izlaz")))
                    {
                        provjera(data, prolaz);
                    }
                    else
                    {
                        zabrana(prolaz);
                        print2list("Korisnik je vec usao");
                        MessageBox.Show("Korisnik je vec usao");
                    }
                }
            }
            else 
            {
                print2list($"ID:{id} nije zabiljezen u bazi");
                MessageBox.Show($"ID:{id} nije zabiljezen u bazi");
                zabrana(prolaz);
            }
        }
        //G_DataReciveIzlaz: Ceka dok dodje nesta na izlazni buffer 
        private void SerialPort_DataReceivedIzlaz(object sender, SerialDataReceivedEventArgs e)
        {
            
            
            string data = serialPortIzlaz.ReadExisting();
            int id = int.Parse(data);

            if (korisnik.korisnikPostoji(id))
            {

                prolaz = "Izlaz";

                if (data != null)
                {
                    if ((rbroj == 1) || korisnik.korisnikProlaz(id) == "Ulaz")
                    {
                        provjera(data, prolaz);
                    }
                    else
                    {
                        zabrana(prolaz);
                        print2list("Korisnik je vec izasao");
                        MessageBox.Show("Korisnik je vec izasao");
                    }
                }
            }
            else
            {
                print2list($"ID:{id} nije zabiljezen u bazi");
                MessageBox.Show($"ID:{id} nije zabiljezen u bazi");
                zabrana(prolaz);
            }
        }

        //G_Provjera: provjerava da li je ocitana kartica validna
        private void provjera(string data,string tipulaza) {

            
            int id = int.Parse(data);
            korisnik.korisnikInfo(id);
            try
            {
                
                if (getDate(korisnik.Datum) < 0)
                {

                    if (String.Equals(korisnik.Tip, "Ovlascen"))
                    {
                        print2list($"Kartica ID: {data} ocitana na {tipulaza}u je validna");
                        odobreno(tipulaza);
                    }
                    else if (String.Equals(korisnik.Tip, "Obican") && (smjena()))
                    {
                        print2list($"Kartica  ID: {data}, ocitana na {tipulaza}u je validna, vrijeme ulazka: {timeSpan.ToString("T")}");
                        odobreno(tipulaza);
                    }
                    else
                    {
                        MessageBox.Show("Proslo je vrijeme smijene, zatrazite pomoc od operatera");
                        print2list($"Kartica  ID: {data}, ocitana na {tipulaza}u je validna, vrijeme van smjene: {timeSpan.ToString("T")}");
                        sendTCP("Zabrana");
                        RucnaDozvola = true;
                        zabrana(tipulaza);
                    }
                }
                else {
                    MessageBox.Show("Kartica nije validna!");
                    sendTCP("Zabrana");
                    zabrana(tipulaza);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           



        }
        //G_Date: provjerava datum kartice sa danasnjim
        private int getDate(DateTime dateTime)
        {
            DateTime dateTime1 = DateTime.Now;
            int rez = DateTime.Compare(dateTime1, dateTime);
            return rez;
        }
        //G_UpisKorisnika: upisuje korisnika u tabelu evidencije
        private void  upisiKorisnika(string tipUlaza)
        {
            
            connect = connection();
            
            try
            {
                connect.Open();
                
                    string naredba2 = $"INSERT INTO public.evidencija(ime, prezime, tip, id, datum, vrijeme,ulazak, rbroj) VALUES ('{korisnik.Ime}','{korisnik.Prezime}','{korisnik.Tip}','{korisnik.Id}','{korisnik.Datum}','{timeSpan}','{tipUlaza}','{rbroj}')";
                    NpgsqlCommand Command = new NpgsqlCommand(naredba2, connect);
                    int br = Command.ExecuteNonQuery();

                    if (br > 0)
                    {
                        print2list($"Korisnik ID: {korisnik.Id} je  dodat u evidenciju");
                    }
                    else
                    {
                        print2list("Nije dodat");
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
                connect.Dispose();
                rbroj++;
            }

        }
        //G_Sec: svake sekunde daje tacno vrijeme
        private void Sec_Inc(object sender, EventArgs e) {
            dateTime = DateTime.Now;
            timeSpan = DateTime.Now.TimeOfDay;
        }
        //G_smjena: provjerava da li je obicna kartica ocitana u periodu od 7-15h
        private bool smjena() {
            TimeSpan timeStart = new TimeSpan(7, 0, 0);
            TimeSpan timeEnd = new TimeSpan(15, 0, 0);
            if ((timeStart < timeSpan) && (timeEnd > timeSpan)) { 
                return true;
            }else return false;
        }
        //G_sendTcp: salje podatke na TCPserver preko porta com3
        private void sendTCP(string msg) {
            
            byte[] data = Encoding.UTF8.GetBytes(msg + "\r\n");
            stream.Write(data, 0, data.Length);

        }

        public void sendTCIPbytes(byte[] data)
        {
            stream.Write(data, 0, data.Length);
        }

        //G_dozvola: rucna komanda za dozvolu prolaza ocitanoj kartici
        private void btnDozvola_Click(object sender, EventArgs e)
        {
            if (RucnaDozvola)
            {
                
                byte[] data2 = new byte[4];
                data2 = new byte[4] { 3, 78, 58, 80 };
                string strData = "03,78,58,80";
                sendTCP(strData);
                sendTCIPbytes(data2);
                sendTCP("Odobreno");
                print2list($"Korisniku ID: {korisnik.Id} je dozvoljen prolaz");
                RucnaDozvola = false;
                upisiKorisnika(prolaz);

            }
            else
            {
                MessageBox.Show("Nema korisnika za rucnu dozvolu");
            }
        }
        //G_ObrisiEv: brise sadrzaj iz tabele evidencija
        private void button1_Click_1(object sender, EventArgs e)
        {

            obrisiEvidenciju();
            if (tabelaObrisana)
            {
                print2list("Tabela evidencije obrisana");

            }
            else {
                print2list("Tabela evidencije je vec prazna!");
            }
        }

       
        private void obrisiEvidenciju() {
            connect = connection();
            try
            {
                connect.Open();
                string naredba = $"DELETE FROM public.evidencija";
                NpgsqlCommand command = new NpgsqlCommand(naredba, connect);
                int br = command.ExecuteNonQuery();
                if (br > 0)
                {
                    tabelaObrisana = true;
                }
                else
                {
                    tabelaObrisana = false;
                }

            }
            catch (Exception ex)
            {
                print2list(ex.Message);
            }
            finally
            {
                connect.Close();
                connect.Dispose();
                rbroj = 1;
            }

        }

        //G_odobreno: ukoliko je validna kartica propusti je
        private void odobreno(string tipulaza)
        {
            byte[] data2 = new byte[4];
            sendTCP("Odobreno");
            data2 = new byte[4] { 3, 78, 58, 68 };
            string strData = "03,78,58,68";
            sendTCP(strData);
            sendTCIPbytes(data2);
            upisiKorisnika(tipulaza);
        }
        //G_zabrana: ukoliko je nije validna kartica zabrani
        private void zabrana(string tipulaza)
        {
            sendTCP("Zabrana");
            byte[] data2 = new byte[4];
            data2 = new byte[4] { 3, 78, 58, 90 };
            string strData = "03,78,58,90";
            sendTCP(strData);
            sendTCIPbytes(data2);
        }
    }

}
