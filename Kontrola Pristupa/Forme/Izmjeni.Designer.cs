namespace Kontrola_Pristupa.Forme
{
    partial class Izmjeni
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNova = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxIzbor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite ID korisnika:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(161, 18);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(47, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nova vrijednost";
            // 
            // txtNova
            // 
            this.txtNova.Location = new System.Drawing.Point(161, 104);
            this.txtNova.Name = "txtNova";
            this.txtNova.Size = new System.Drawing.Size(121, 22);
            this.txtNova.TabIndex = 5;
            this.txtNova.TextChanged += new System.EventHandler(this.txtNova_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Podatak koji se mjenja:";
            // 
            // boxIzbor
            // 
            this.boxIzbor.FormattingEnabled = true;
            this.boxIzbor.Items.AddRange(new object[] {
            "ime",
            "prezime",
            "id",
            "tip",
            "datum"});
            this.boxIzbor.Location = new System.Drawing.Point(161, 63);
            this.boxIzbor.Name = "boxIzbor";
            this.boxIzbor.Size = new System.Drawing.Size(121, 24);
            this.boxIzbor.TabIndex = 7;
            this.boxIzbor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Izmjeni";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(161, 104);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(121, 22);
            this.datePicker.TabIndex = 10;
            this.datePicker.Visible = false;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // Izmjeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 193);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxIzbor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNova);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "Izmjeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmjeni korisnika";
            this.Load += new System.EventHandler(this.Izmjeni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNova;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxIzbor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}
