namespace Kontrola_Pristupa
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnDozvola = new System.Windows.Forms.Button();
            this.btnKraj = new System.Windows.Forms.Button();
            this.btnObrisiListu = new System.Windows.Forms.Button();
            this.glavniPanel = new System.Windows.Forms.Panel();
            this.btnOcistiEv = new System.Windows.Forms.Button();
            this.btnCitac = new System.Windows.Forms.Button();
            this.txtNivoKorisnika = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListBox();
            this.glavniPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Enabled = false;
            this.btnDodaj.Location = new System.Drawing.Point(43, 47);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(87, 28);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Enabled = false;
            this.btnObrisi.Location = new System.Drawing.Point(43, 90);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(87, 28);
            this.btnObrisi.TabIndex = 1;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(43, 178);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(87, 28);
            this.btnPrikazi.TabIndex = 2;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Enabled = false;
            this.btnIzmjeni.Location = new System.Drawing.Point(43, 135);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(87, 28);
            this.btnIzmjeni.TabIndex = 3;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // btnDozvola
            // 
            this.btnDozvola.Location = new System.Drawing.Point(43, 233);
            this.btnDozvola.Name = "btnDozvola";
            this.btnDozvola.Size = new System.Drawing.Size(87, 28);
            this.btnDozvola.TabIndex = 4;
            this.btnDozvola.Text = "Dozvola";
            this.btnDozvola.UseVisualStyleBackColor = true;
            this.btnDozvola.Click += new System.EventHandler(this.btnDozvola_Click);
            // 
            // btnKraj
            // 
            this.btnKraj.Location = new System.Drawing.Point(13, 343);
            this.btnKraj.Name = "btnKraj";
            this.btnKraj.Size = new System.Drawing.Size(136, 33);
            this.btnKraj.TabIndex = 6;
            this.btnKraj.Text = "Kraj";
            this.btnKraj.UseVisualStyleBackColor = true;
            this.btnKraj.Click += new System.EventHandler(this.btnKraj_Click);
            // 
            // btnObrisiListu
            // 
            this.btnObrisiListu.Location = new System.Drawing.Point(590, 286);
            this.btnObrisiListu.Name = "btnObrisiListu";
            this.btnObrisiListu.Size = new System.Drawing.Size(121, 28);
            this.btnObrisiListu.TabIndex = 7;
            this.btnObrisiListu.Text = "Obriši prikaz";
            this.btnObrisiListu.UseVisualStyleBackColor = true;
            this.btnObrisiListu.Click += new System.EventHandler(this.btnObrisiListu_Click);
            // 
            // glavniPanel
            // 
            this.glavniPanel.Controls.Add(this.listView);
            this.glavniPanel.Controls.Add(this.btnOcistiEv);
            this.glavniPanel.Controls.Add(this.btnCitac);
            this.glavniPanel.Controls.Add(this.txtNivoKorisnika);
            this.glavniPanel.Controls.Add(this.btnLogout);
            this.glavniPanel.Controls.Add(this.btnObrisiListu);
            this.glavniPanel.Controls.Add(this.btnDodaj);
            this.glavniPanel.Controls.Add(this.btnObrisi);
            this.glavniPanel.Controls.Add(this.btnPrikazi);
            this.glavniPanel.Controls.Add(this.btnIzmjeni);
            this.glavniPanel.Controls.Add(this.btnDozvola);
            this.glavniPanel.Controls.Add(this.btnKraj);
            this.glavniPanel.Location = new System.Drawing.Point(12, 34);
            this.glavniPanel.Name = "glavniPanel";
            this.glavniPanel.Size = new System.Drawing.Size(725, 385);
            this.glavniPanel.TabIndex = 8;
            this.glavniPanel.Visible = false;
            // 
            // btnOcistiEv
            // 
            this.btnOcistiEv.Location = new System.Drawing.Point(136, 286);
            this.btnOcistiEv.Name = "btnOcistiEv";
            this.btnOcistiEv.Size = new System.Drawing.Size(121, 28);
            this.btnOcistiEv.TabIndex = 13;
            this.btnOcistiEv.Text = "Obrisi evidenciju";
            this.btnOcistiEv.UseVisualStyleBackColor = true;
            this.btnOcistiEv.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCitac
            // 
            this.btnCitac.Location = new System.Drawing.Point(136, 17);
            this.btnCitac.Name = "btnCitac";
            this.btnCitac.Size = new System.Drawing.Size(154, 26);
            this.btnCitac.TabIndex = 12;
            this.btnCitac.Text = "Podesi komunikaciju";
            this.btnCitac.UseVisualStyleBackColor = true;
            this.btnCitac.Click += new System.EventHandler(this.btnCitac_Click);
            // 
            // txtNivoKorisnika
            // 
            this.txtNivoKorisnika.AutoSize = true;
            this.txtNivoKorisnika.Location = new System.Drawing.Point(374, 17);
            this.txtNivoKorisnika.Name = "txtNivoKorisnika";
            this.txtNivoKorisnika.Size = new System.Drawing.Size(44, 16);
            this.txtNivoKorisnika.TabIndex = 11;
            this.txtNivoKorisnika.Text = "label1";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(155, 345);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 31);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(288, 150);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(155, 72);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 51);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listView
            // 
            this.listView.FormattingEnabled = true;
            this.listView.ItemHeight = 16;
            this.listView.Location = new System.Drawing.Point(136, 49);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(575, 212);
            this.listView.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 431);
            this.Controls.Add(this.glavniPanel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrola pristupa";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.glavniPanel.ResumeLayout(false);
            this.glavniPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnDozvola;
        private System.Windows.Forms.Button btnKraj;
        private System.Windows.Forms.Button btnObrisiListu;
        private System.Windows.Forms.Panel glavniPanel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label txtNivoKorisnika;
        private System.Windows.Forms.Button btnCitac;
        private System.Windows.Forms.Button btnOcistiEv;
        private System.Windows.Forms.ListBox listView;
    }
}
