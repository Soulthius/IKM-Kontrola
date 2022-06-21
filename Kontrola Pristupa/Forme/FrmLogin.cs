using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Kontrola_Pristupa.Forme
{
    public partial class FrmLogin : Form
    {
       
        private int nivoPristupa=-1;

        public int NivoPristupa
        { 
            get { return nivoPristupa; }    
        }
       

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connect = new NpgsqlConnection(@"Host = localhost; Port = 5432; User Id = postgres; Password = 1234; Database = kontrola;");
           
            

            try
            {
                connect.Open();
                string username = txtUname.Text;
                string password = txtPass.Text;
                string naredba = $"SELECT uloga FROM login WHERE ime = '{username}' and lozinka = '{password}'";

                NpgsqlCommand command = new NpgsqlCommand(naredba, connect);
                string pristup = command.ExecuteScalar().ToString();
                

                if (String.Equals(pristup, "Admin"))
                {
                    this.Close();
                    nivoPristupa = 1;
                }
                else if (String.Equals(pristup, "Korisnik"))
                {
                    this.Close();
                    nivoPristupa = 0;
                    this.DialogResult = DialogResult.OK;
                }
                

            }
            catch (Exception)
            {
                errLabel.Visible = false;
                Thread.Sleep(100);
                errLabel.Text = "Pogresno Korisnicko ime ili lozinka";
                errLabel.Visible = true;
            }
            finally
            {
                connect.Close();
                connect.Dispose();
               
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void errLabel_Click(object sender, EventArgs e)
        {

        }

        private void chPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {

                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }


        }
    }
}
