namespace Kontrola_Pristupa.Forme
{
    partial class Komunikacija
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboPortsUlaz = new System.Windows.Forms.ComboBox();
            this.btnPodesi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboPortsIzlaz = new System.Windows.Forms.ComboBox();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port Ulaz:";
            // 
            // comboPortsUlaz
            // 
            this.comboPortsUlaz.FormattingEnabled = true;
            this.comboPortsUlaz.Location = new System.Drawing.Point(83, 21);
            this.comboPortsUlaz.Name = "comboPortsUlaz";
            this.comboPortsUlaz.Size = new System.Drawing.Size(74, 24);
            this.comboPortsUlaz.TabIndex = 3;
            this.comboPortsUlaz.Text = "COM1";
            // 
            // btnPodesi
            // 
            this.btnPodesi.Location = new System.Drawing.Point(214, 141);
            this.btnPodesi.Name = "btnPodesi";
            this.btnPodesi.Size = new System.Drawing.Size(89, 31);
            this.btnPodesi.TabIndex = 8;
            this.btnPodesi.Text = "Podesi";
            this.btnPodesi.UseVisualStyleBackColor = true;
            this.btnPodesi.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Odsutani";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboPortsIzlaz
            // 
            this.comboPortsIzlaz.FormattingEnabled = true;
            this.comboPortsIzlaz.Location = new System.Drawing.Point(83, 65);
            this.comboPortsIzlaz.Name = "comboPortsIzlaz";
            this.comboPortsIzlaz.Size = new System.Drawing.Size(74, 24);
            this.comboPortsIzlaz.TabIndex = 11;
            this.comboPortsIzlaz.Text = "COM5";
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Location = new System.Drawing.Point(13, 68);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(63, 16);
            this.lblIzlaz.TabIndex = 10;
            this.lblIzlaz.Text = "Port Izlaz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "IP:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(198, 21);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(134, 22);
            this.txtIP.TabIndex = 13;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(198, 73);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(72, 22);
            this.txtPort.TabIndex = 15;
            this.txtPort.Text = "7000";
            // 
            // Komunikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 184);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboPortsIzlaz);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPodesi);
            this.Controls.Add(this.comboPortsUlaz);
            this.Controls.Add(this.label2);
            this.Name = "Komunikacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Citac kartica";
            this.Load += new System.EventHandler(this.Rs232_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboPortsUlaz;
        private System.Windows.Forms.Button btnPodesi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboPortsIzlaz;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
    }
}
