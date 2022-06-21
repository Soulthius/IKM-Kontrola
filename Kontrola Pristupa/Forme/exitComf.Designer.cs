namespace Kontrola_Pristupa.Forme
{
    partial class exitComf
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
            this.btnDA = new System.Windows.Forms.Button();
            this.btnNE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDA
            // 
            this.btnDA.Location = new System.Drawing.Point(42, 74);
            this.btnDA.Name = "btnDA";
            this.btnDA.Size = new System.Drawing.Size(62, 44);
            this.btnDA.TabIndex = 0;
            this.btnDA.Text = "DA";
            this.btnDA.UseVisualStyleBackColor = true;
            this.btnDA.Click += new System.EventHandler(this.btnDA_Click);
            // 
            // btnNE
            // 
            this.btnNE.Location = new System.Drawing.Point(174, 74);
            this.btnNE.Name = "btnNE";
            this.btnNE.Size = new System.Drawing.Size(62, 44);
            this.btnNE.TabIndex = 1;
            this.btnNE.Text = "NE";
            this.btnNE.UseVisualStyleBackColor = true;
            this.btnNE.Click += new System.EventHandler(this.btnNE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Da li ste sigurni";
            // 
            // exitComf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 134);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNE);
            this.Controls.Add(this.btnDA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "exitComf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.exitComf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDA;
        private System.Windows.Forms.Button btnNE;
        private System.Windows.Forms.Label label1;
    }
}