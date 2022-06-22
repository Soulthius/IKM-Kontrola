using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Kontrola_Pristupa.Forme
{
    public partial class Obrisi : Form
    {

        private int id;
        private string ime;
        private string prezime;

        public string Ime {
            get { return ime; }    
        }

        public string Prezime
        {
            get { return prezime; }
        }

        public int Id { 
            get { return id; }
        }

        public Obrisi()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            id = int.Parse(txtID.Text);
            ime = txtIme.Text;
            prezime = txtPrezime.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            NpgsqlConnection Connection = new NpgsqlConnection(@"Host = localhost; Port = 5432; User Id = postgres; Password = 1234; Database = kontrola;");
            Connection.Open();
            try
            {

                string naredba = $"select * FROM public.korisnici WHERE id = '{int.Parse(txtID.Text)}'";
                NpgsqlCommand Command = new NpgsqlCommand(naredba, Connection);
                NpgsqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(0);
                    string prezime = reader.GetString(3);
                    DateTime datum = reader.GetDateTime(4);
                    txtIme.Text = ime;
                    txtPrezime.Text = prezime;
                    txtDatum.Text = datum.ToString("yyyy-MM-dd");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepostojeci korisnik");
                MessageBox.Show(ex.Message);
            }

        }

        private void Obrisi_Load(object sender, EventArgs e)
        {

        }

        private void ispisKorisnika_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
