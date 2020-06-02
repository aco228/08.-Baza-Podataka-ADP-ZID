namespace _08.Baza_Podataka_ADP_ZID
{
    partial class Form_Pomoc
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
            this.loading_panel = new System.Windows.Forms.Panel();
            this.label75 = new System.Windows.Forms.Label();
            this.loading_greska = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.text_pretragaVolontera = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.text_noviVolonter = new System.Windows.Forms.TextBox();
            this.text_grupe = new System.Windows.Forms.TextBox();
            this.text_dodatneInfo = new System.Windows.Forms.TextBox();
            this.loading_panel.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loading_panel
            // 
            this.loading_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loading_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loading_panel.Controls.Add(this.loading_greska);
            this.loading_panel.Controls.Add(this.label75);
            this.loading_panel.Location = new System.Drawing.Point(747, 6);
            this.loading_panel.Name = "loading_panel";
            this.loading_panel.Size = new System.Drawing.Size(378, 210);
            this.loading_panel.TabIndex = 152;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(100, 83);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(164, 19);
            this.label75.TabIndex = 0;
            this.label75.Text = "Preuzimanje podataka...";
            // 
            // loading_greska
            // 
            this.loading_greska.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_greska.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loading_greska.Location = new System.Drawing.Point(3, 179);
            this.loading_greska.Name = "loading_greska";
            this.loading_greska.Size = new System.Drawing.Size(370, 19);
            this.loading_greska.TabIndex = 1;
            this.loading_greska.Text = "Greska";
            this.loading_greska.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loading_greska.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabPage4.Controls.Add(this.text_dodatneInfo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(798, 403);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dodatne informacije";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabPage3.Controls.Add(this.text_grupe);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(798, 403);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Grupe";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabPage2.Controls.Add(this.text_noviVolonter);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(798, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Novi volonter";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabPage1.Controls.Add(this.text_pretragaVolontera);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(798, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pretraga volontera";
            // 
            // text_pretragaVolontera
            // 
            this.text_pretragaVolontera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.text_pretragaVolontera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.text_pretragaVolontera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_pretragaVolontera.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_pretragaVolontera.ForeColor = System.Drawing.Color.Black;
            this.text_pretragaVolontera.Location = new System.Drawing.Point(7, 11);
            this.text_pretragaVolontera.Multiline = true;
            this.text_pretragaVolontera.Name = "text_pretragaVolontera";
            this.text_pretragaVolontera.ReadOnly = true;
            this.text_pretragaVolontera.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_pretragaVolontera.Size = new System.Drawing.Size(784, 382);
            this.text_pretragaVolontera.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(7, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 429);
            this.tabControl1.TabIndex = 0;
            // 
            // text_noviVolonter
            // 
            this.text_noviVolonter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.text_noviVolonter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.text_noviVolonter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_noviVolonter.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_noviVolonter.ForeColor = System.Drawing.Color.Black;
            this.text_noviVolonter.Location = new System.Drawing.Point(7, 10);
            this.text_noviVolonter.Multiline = true;
            this.text_noviVolonter.Name = "text_noviVolonter";
            this.text_noviVolonter.ReadOnly = true;
            this.text_noviVolonter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_noviVolonter.Size = new System.Drawing.Size(784, 382);
            this.text_noviVolonter.TabIndex = 1;
            // 
            // text_grupe
            // 
            this.text_grupe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.text_grupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.text_grupe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_grupe.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_grupe.ForeColor = System.Drawing.Color.Black;
            this.text_grupe.Location = new System.Drawing.Point(7, 10);
            this.text_grupe.Multiline = true;
            this.text_grupe.Name = "text_grupe";
            this.text_grupe.ReadOnly = true;
            this.text_grupe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_grupe.Size = new System.Drawing.Size(784, 382);
            this.text_grupe.TabIndex = 2;
            // 
            // text_dodatneInfo
            // 
            this.text_dodatneInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.text_dodatneInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.text_dodatneInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_dodatneInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_dodatneInfo.ForeColor = System.Drawing.Color.Black;
            this.text_dodatneInfo.Location = new System.Drawing.Point(7, 10);
            this.text_dodatneInfo.Multiline = true;
            this.text_dodatneInfo.Name = "text_dodatneInfo";
            this.text_dodatneInfo.ReadOnly = true;
            this.text_dodatneInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_dodatneInfo.Size = new System.Drawing.Size(784, 382);
            this.text_dodatneInfo.TabIndex = 2;
            // 
            // Form_Pomoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(814, 438);
            this.Controls.Add(this.loading_panel);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_Pomoc";
            this.ShowInTaskbar = false;
            this.Text = "Pomoć";
            this.Load += new System.EventHandler(this.Form_Pomoc_Load);
            this.loading_panel.ResumeLayout(false);
            this.loading_panel.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loading_panel;
        private System.Windows.Forms.Label loading_greska;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox text_pretragaVolontera;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox text_dodatneInfo;
        private System.Windows.Forms.TextBox text_grupe;
        private System.Windows.Forms.TextBox text_noviVolonter;

    }
}