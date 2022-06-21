using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrola_Pristupa.Forme
{
    public partial class dodajKorisnika : Form
    {

        private string ime;
        private string prezime;
        private int id;
        private DateTime dateTime;
        private string tip;

        public string Ime { 
            get { return ime; }
        }

        public string Prezime
        {
            get { return prezime; }
        }

        public int Id
        {
            get { return id; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }    
        }

        public string Tip {
            get { return tip; } 
        }


        public dodajKorisnika()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dodajKorisnika_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Length == 0)
                {
                    MessageBox.Show("Morate unijeti ID");
                    txtId.Focus();
                    return;
                }
                else if (txtIme.Text.Length == 0)
                {
                    MessageBox.Show("Morate unijeti ime");
                    txtIme.Focus();
                    return;
                }
                else if (txtTip.Text.Length == 0)
                {
                    MessageBox.Show("Morate unijeti tip korisnika");
                    txtTip.Focus();
                    return;
                }

                ime = txtIme.Text;
                prezime = txtPrezime.Text;
                id = int.Parse(txtId.Text);
                tip = txtTip.Text;
                dateTime = dateTimePostavi.Value;
                this.DialogResult = DialogResult.OK;
            }
            catch {
                MessageBox.Show("Niste uneli dobre vrijednosti");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
