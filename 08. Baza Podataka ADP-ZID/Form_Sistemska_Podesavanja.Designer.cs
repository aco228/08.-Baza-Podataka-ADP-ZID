namespace _08.Baza_Podataka_ADP_ZID
{
    partial class Form_Sistemska_Podesavanja
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.veze_koristi = new System.Windows.Forms.TextBox();
            this.veze_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.veze_nova = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F);
            this.label4.Location = new System.Drawing.Point(144, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Vodite računa šta radite!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F);
            this.label3.Location = new System.Drawing.Point(24, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Veza koja se koristi:";
            // 
            // veze_koristi
            // 
            this.veze_koristi.Font = new System.Drawing.Font("Calibri", 12F);
            this.veze_koristi.Location = new System.Drawing.Point(147, 51);
            this.veze_koristi.Name = "veze_koristi";
            this.veze_koristi.ReadOnly = true;
            this.veze_koristi.Size = new System.Drawing.Size(443, 27);
            this.veze_koristi.TabIndex = 16;
            // 
            // veze_btn
            // 
            this.veze_btn.Font = new System.Drawing.Font("Calibri", 10F);
            this.veze_btn.Location = new System.Drawing.Point(145, 122);
            this.veze_btn.Name = "veze_btn";
            this.veze_btn.Size = new System.Drawing.Size(272, 26);
            this.veze_btn.TabIndex = 15;
            this.veze_btn.Text = "Sačuvaj";
            this.veze_btn.UseVisualStyleBackColor = true;
            this.veze_btn.Click += new System.EventHandler(this.veze_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F);
            this.label5.Location = new System.Drawing.Point(50, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Promjeni vezu:";
            // 
            // veze_nova
            // 
            this.veze_nova.Font = new System.Drawing.Font("Calibri", 12F);
            this.veze_nova.Location = new System.Drawing.Point(147, 81);
            this.veze_nova.Name = "veze_nova";
            this.veze_nova.Size = new System.Drawing.Size(443, 27);
            this.veze_nova.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F);
            this.label1.Location = new System.Drawing.Point(144, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nakon promjene morate restartovati program!";
            // 
            // Form_Sistemska_Podesavanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.veze_koristi);
            this.Controls.Add(this.veze_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.veze_nova);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Sistemska_Podesavanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemska podesavanja";
            this.Load += new System.EventHandler(this.Form_Sistemska_Podesavanja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox veze_koristi;
        private System.Windows.Forms.Button veze_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox veze_nova;
        private System.Windows.Forms.Label label1;

    }
}