using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrola_Pristupa.Forme
{
    public partial class Komunikacija : Form
    {

        public string IP { get; set; }
        
        public string Port { get; set; }    
        public string PortIzlaz { get; set; }
        public string PortUlaz { get; set; }
        
        public bool Ulaz { get; set; }
        public bool Izlaz { get; set; }   

        public bool dozvola { get; set; }  

        
        public Komunikacija()
        {
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();
            comboPortsUlaz.Items.AddRange(ports); 
            comboPortsUlaz.SelectedIndex = 0;
            comboPortsIzlaz.Items.AddRange(ports);
            comboPortsIzlaz.SelectedIndex = 0;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PortIzlaz = comboPortsIzlaz.SelectedItem.ToString();
            PortUlaz = comboPortsUlaz.SelectedItem.ToString();
            Port = txtPort.Text;
            IP = txtIP.Text;
            this.DialogResult = DialogResult.OK;
           
        }

        private void Rs232_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
