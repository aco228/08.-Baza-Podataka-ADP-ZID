namespace _08.Baza_Podataka_ADP_ZID
{
    partial class Home_Intro
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.start_info_notifikacije = new System.Windows.Forms.Label();
            this.waterMark = new System.Windows.Forms.PictureBox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.panel_login_greska = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_pass = new System.Windows.Forms.TextBox();
            this.login_username = new System.Windows.Forms.TextBox();
            this.baza_konektor = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.waterMark)).BeginInit();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start_info_notifikacije
            // 
            this.start_info_notifikacije.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_info_notifikacije.ForeColor = System.Drawing.Color.White;
            this.start_info_notifikacije.Location = new System.Drawing.Point(13, 87);
            this.start_info_notifikacije.Name = "start_info_notifikacije";
            this.start_info_notifikacije.Size = new System.Drawing.Size(1036, 350);
            this.start_info_notifikacije.TabIndex = 5;
            this.start_info_notifikacije.Text = "Provjera resursa...";
            this.start_info_notifikacije.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.start_info_notifikacije.Visible = false;
            // 
            // waterMark
            // 
            this.waterMark.Image = global::_08.Baza_Podataka_ADP_ZID.Resursi.intro_watermark;
            this.waterMark.Location = new System.Drawing.Point(0, 489);
            this.waterMark.Name = "waterMark";
            this.waterMark.Size = new System.Drawing.Size(310, 23);
            this.waterMark.TabIndex = 7;
            this.waterMark.TabStop = false;
            this.waterMark.Visible = false;
            this.waterMark.Click += new System.EventHandler(this.waterMark_Click);
            // 
            // panel_login
            // 
            this.panel_login.BackgroundImage = global::_08.Baza_Podataka_ADP_ZID.Resursi.index_login;
            this.panel_login.Controls.Add(this.panel_login_greska);
            this.panel_login.Controls.Add(this.pictureBox1);
            this.panel_login.Controls.Add(this.login_pass);
            this.panel_login.Controls.Add(this.login_username);
            this.panel_login.Location = new System.Drawing.Point(26, 105);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(400, 303);
            this.panel_login.TabIndex = 6;
            this.panel_login.Visible = false;
            // 
            // panel_login_greska
            // 
            this.panel_login_greska.AutoSize = true;
            this.panel_login_greska.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel_login_greska.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel_login_greska.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel_login_greska.Location = new System.Drawing.Point(133, 250);
            this.panel_login_greska.Name = "panel_login_greska";
            this.panel_login_greska.Size = new System.Drawing.Size(152, 18);
            this.panel_login_greska.TabIndex = 3;
            this.panel_login_greska.Text = "Greska, pogresno nesto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_08.Baza_Podataka_ADP_ZID.Resursi.index_login_btn;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(22, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 40);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // login_pass
            // 
            this.login_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.login_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_pass.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_pass.Location = new System.Drawing.Point(36, 170);
            this.login_pass.Name = "login_pass";
            this.login_pass.PasswordChar = '*';
            this.login_pass.Size = new System.Drawing.Size(284, 19);
            this.login_pass.TabIndex = 1;
            this.login_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_pass_KeyDown);
            // 
            // login_username
            // 
            this.login_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.login_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_username.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_username.Location = new System.Drawing.Point(36, 99);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(284, 19);
            this.login_username.TabIndex = 0;
            // 
            // baza_konektor
            // 
            this.baza_konektor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.baza_konektor_DoWork);
            this.baza_konektor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.baza_konektor_RunWorkerCompleted);
            // 
            // Home_Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            this.Controls.Add(this.waterMark);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.start_info_notifikacije);
            this.Name = "Home_Intro";
            this.Size = new System.Drawing.Size(1062, 512);
            this.Load += new System.EventHandler(this.Home_Intro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.waterMark)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label panel_login_greska;
        private System.Windows.Forms.TextBox login_pass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label start_info_notifikacije;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.PictureBox waterMark;
        private System.ComponentModel.BackgroundWorker baza_konektor;
    }
}
