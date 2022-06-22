using System;
using Kontrola_Pristupa.Forme;
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

namespace Kontrola_Pristupa.Clase
{
    internal class KorisnikData
    {
        public KorisnikData()
        {
            /*  this.id = id;
              this.ime = ime;
              this.prezime = prezime;
              this.tip = tip;
              this.datum = datum;*/

        }

        private int id;
        private string ime;
        private string prezime;
        private string tip;
        private DateTime datum;
        private string Pristup;


        public int Id
        {
            get { return id; }
        }
        public string Ime
        {
            get { return ime; }
        }

        public string Prezime
        {
            get { return prezime; }
        }

        public string Tip
        {
            get { return tip; }
        }

        public DateTime Datum
        {
            get { return datum; }
        }

        public bool korisnikPostoji(int id)
        {
            NpgsqlConnection Connection = new NpgsqlConnection(@"Host = localhost; Port = 5432; User Id = postgres; Password = 1234; Database = kontrola;");
            Connection.Open();
            try
            {
                string naredba = $"SELECT EXISTS(SELECT id FROM korisnici WHERE id={id})";
                NpgsqlCommand Command = new NpgsqlCommand(naredba, Connection);
                bool pristup = Command.ExecuteScalar().Equals(true);
                return pristup;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                Connection.Close();
                Connection.Dispose();
            }

        }

        public bool prviProlaz(int id)
        {
            NpgsqlConnection Connection = new NpgsqlConnection(@"Host = localhost; Port = 5432; User Id = postgres; Password = 1234; Database = kontrola;");
            Connection.Open();
            try
            {
                string naredba = $"SELECT EXISTS(SELECT id FROM evidencija WHERE id={id})";
                NpgsqlCommand Command = new NpgsqlCommand(naredba, Connection);
                bool pristup = Command.ExecuteScalar().Equals(true);
                return pristup;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                Connection.Close();
                Connection.Dispose();
            }


        }


        public string korisnikProlaz(int id)
        {



            NpgsqlConnection Connection = new NpgsqlConnection(@"Host = localhost; Port = 5432; User Id = postgres; Password = 1234; Database = kontrola;");
            Connection.Open();
            try
            {
                string naredba = $"SELECT ulazak, max(rbroj) as rbroj FROM evidencija WHERE id={id} GROUP BY ulazak ORDER BY rbroj desc limit 1";
                NpgsqlCommand Command = new NpgsqlCommand(naredba, Connection);
                string pristup = Command.ExecuteScalar().ToString();

                return pristup;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                Connection.Close();
                Connection.Dispose();
            }



        }




        public void korisnikInfo(int idKartice)
        {

            
                NpgsqlConnection Connection = new NpgsqlConnection(@"Host = localhost; Port = 5432; User Id = postgres; Password = 1234; Database = kontrola;");
                Connection.Open();
                try
                {

                    string naredba = $"select * FROM public.korisnici WHERE id = '{idKartice}'";
                    NpgsqlCommand Command = new NpgsqlCommand(naredba, Connection);
                    NpgsqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {

                        string ime1 = reader.GetString(0);
                        string prezime1 = reader.GetString(3);
                        DateTime datum1 = reader.GetDateTime(4);
                        int id1 = reader.GetInt32(1);
                        string tip1 = reader.GetString(2);
                        id = id1;
                        ime = ime1;
                        prezime = ime1;
                        tip = tip1;
                        datum = datum1;
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    Connection.Close();
                    Connection.Dispose();
                }
        }
            


    }


}

