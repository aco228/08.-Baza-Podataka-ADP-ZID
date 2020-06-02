namespace _08.Baza_Podataka_ADP_ZID
{
    partial class grupe_NovaGrupa
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
            this.imeGrupe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.opisGrupe = new System.Windows.Forms.TextBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.greska = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.br_sati = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.br_sati)).BeginInit();
            this.SuspendLayout();
            // 
            // imeGrupe
            // 
            this.imeGrupe.Font = new System.Drawing.Font("Calibri", 11F);
            this.imeGrupe.Location = new System.Drawing.Point(13, 27);
            this.imeGrupe.Name = "imeGrupe";
            this.imeGrupe.Size = new System.Drawing.Size(295, 25);
            this.imeGrupe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F);
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime grupe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F);
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opis grupe:";
            // 
            // opisGrupe
            // 
            this.opisGrupe.Font = new System.Drawing.Font("Calibri", 11F);
            this.opisGrupe.Location = new System.Drawing.Point(13, 76);
            this.opisGrupe.Multiline = true;
            this.opisGrupe.Name = "opisGrupe";
            this.opisGrupe.Size = new System.Drawing.Size(295, 110);
            this.opisGrupe.TabIndex = 2;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(12, 223);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(100, 23);
            this.btnPotvrdi.TabIndex = 4;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // greska
            // 
            this.greska.AutoSize = true;
            this.greska.Font = new System.Drawing.Font("Calibri", 9F);
            this.greska.Location = new System.Drawing.Point(117, 228);
            this.greska.Name = "greska";
            this.greska.Size = new System.Drawing.Size(42, 14);
            this.greska.TabIndex = 5;
            this.greska.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F);
            this.label3.Location = new System.Drawing.Point(13, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj sati:";
            // 
            // br_sati
            // 
            this.br_sati.Font = new System.Drawing.Font("Calibri", 11F);
            this.br_sati.Location = new System.Drawing.Point(72, 190);
            this.br_sati.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.br_sati.Name = "br_sati";
            this.br_sati.Size = new System.Drawing.Size(235, 25);
            this.br_sati.TabIndex = 8;
            // 
            // grupe_NovaGrupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 251);
            this.Controls.Add(this.br_sati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.greska);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.opisGrupe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imeGrupe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "grupe_NovaGrupa";
            this.Text = "Nova grupa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.br_sati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imeGrupe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox opisGrupe;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Label greska;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown br_sati;
    }
}