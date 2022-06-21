using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Npgsql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrola_Pristupa.Forme
{
    public partial class Izmjeni : Form
    {

        private int id;
        private string name;
        private string prezime;
        private string tip;
        private DateTime datum;
        private string izmjena;

        public string Izmjena { 
            get { return izmjena; } 
        }

        public int ID { 
            get { return id; }  
        }
       
        public string Ime { 
            get { return name; }    
        }

        public string Prezime {
            
              get { return prezime; }

        }

        public string Tip {
            get { return tip; }
        }

        public DateTime Datum{
            get { return datum; }
        }

        public Izmjeni()
        {
            InitializeComponent();
        }

        private void Izmjeni_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxIzbor.SelectedIndex == 4)
            {
                txtNova.Visible = false;
                datePicker.Visible = true;
            }
            else {

                txtNova.Visible = true;
                datePicker.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
                    string ime1 = reader.GetString(0);
                    string prezime1 = reader.GetString(3);
                    DateTime datum1 = reader.GetDateTime(4);
                    int id1 = reader.GetInt32(1);
                    string tip1 = reader.GetString(2);
                    id = id1;
                    name = ime1;
                    tip = tip1;
                    datum = datum1;
                    prezime = prezime1;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Pogresan ID!");
            }
            finally 
            {
                Connection.Close();
                Connection.Dispose();
                this.Close();
            }


            
            izmjena = boxIzbor.Text;
            if (txtNova.Text.Length == 0 && !datePicker.Visible)
            {
                MessageBox.Show("Morate uneti vrijednost");
            }

            if (boxIzbor.Text == "ime") {
                name = txtNova.Text;
            }

            if(boxIzbor.Text == "prezime") {
                prezime = txtNova.Text;
            }
            else if (boxIzbor.Text == "id")
            {
                id = int.Parse(txtNova.Text);
            }
            else if (boxIzbor.Text == "tip")
            {
                tip = txtNova.Text;
            }
            else if (boxIzbor.Text == "datum")
            {
                datum = datePicker.Value;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNova_TextChanged(object sender, EventArgs e)
        {

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
