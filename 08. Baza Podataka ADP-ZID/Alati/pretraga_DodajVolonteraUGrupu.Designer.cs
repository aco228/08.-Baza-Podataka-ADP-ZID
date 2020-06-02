namespace _08.Baza_Podataka_ADP_ZID
{
    partial class pretraga_DodajVolonteraUGrupu
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
            this.opis = new System.Windows.Forms.Label();
            this.combo_grupe = new System.Windows.Forms.ComboBox();
            this.btn_potvrdi = new System.Windows.Forms.Button();
            this.poruka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // opis
            // 
            this.opis.AutoSize = true;
            this.opis.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opis.Location = new System.Drawing.Point(8, 10);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(262, 15);
            this.opis.TabIndex = 0;
            this.opis.Text = "Dodaj volontera \'Aleksandar Konatar\' u grupu:";
            // 
            // combo_grupe
            // 
            this.combo_grupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_grupe.FormattingEnabled = true;
            this.combo_grupe.Location = new System.Drawing.Point(13, 29);
            this.combo_grupe.Name = "combo_grupe";
            this.combo_grupe.Size = new System.Drawing.Size(355, 21);
            this.combo_grupe.TabIndex = 1;
            // 
            // btn_potvrdi
            // 
            this.btn_potvrdi.Location = new System.Drawing.Point(374, 27);
            this.btn_potvrdi.Name = "btn_potvrdi";
            this.btn_potvrdi.Size = new System.Drawing.Size(142, 23);
            this.btn_potvrdi.TabIndex = 2;
            this.btn_potvrdi.Text = "Potvrdi";
            this.btn_potvrdi.UseVisualStyleBackColor = true;
            this.btn_potvrdi.Click += new System.EventHandler(this.btn_potvrdi_Click);
            // 
            // poruka
            // 
            this.poruka.AutoSize = true;
            this.poruka.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poruka.ForeColor = System.Drawing.Color.Gray;
            this.poruka.Location = new System.Drawing.Point(8, 96);
            this.poruka.Name = "poruka";
            this.poruka.Size = new System.Drawing.Size(447, 15);
            this.poruka.TabIndex = 3;
            this.poruka.Text = "Nakon dodavanja, volonteri se mogu brisati iz grupa jedino preko sekcije Grupe!";
            // 
            // pretraga_DodajVolonteraUGrupu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 120);
            this.Controls.Add(this.poruka);
            this.Controls.Add(this.btn_potvrdi);
            this.Controls.Add(this.combo_grupe);
            this.Controls.Add(this.opis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "pretraga_DodajVolonteraUGrupu";
            this.Text = "Dodaj volontera u grupu";
            this.Load += new System.EventHandler(this.pretraga_DodajVolonteraUGrupu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label opis;
        private System.Windows.Forms.ComboBox combo_grupe;
        private System.Windows.Forms.Button btn_potvrdi;
        private System.Windows.Forms.Label poruka;
    }
}