namespace _08.Baza_Podataka_ADP_ZID
{
    partial class Form_Administracija
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Administracija));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_nalozi = new System.Windows.Forms.TabPage();
            this.admin_error = new System.Windows.Forms.Label();
            this.admin_privilegije = new System.Windows.Forms.CheckBox();
            this.admin_btnDell = new System.Windows.Forms.Button();
            this.admin_btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.admin_info = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_user = new System.Windows.Forms.TextBox();
            this.admin_data = new System.Windows.Forms.DataGridView();
            this.tab_backgroundSlika = new System.Windows.Forms.TabPage();
            this.boje_izbrisiSliku = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.boje_potvrdi = new System.Windows.Forms.Button();
            this.boje_pronadji = new System.Windows.Forms.Button();
            this.boje_picture = new System.Windows.Forms.PictureBox();
            this.boje_zuta = new System.Windows.Forms.Label();
            this.boje_zelena = new System.Windows.Forms.Label();
            this.boje_plava = new System.Windows.Forms.Label();
            this.boje_ljubicasta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boje_crvena = new System.Windows.Forms.Label();
            this.tab_bazaPodataka = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.baza_NSA_ucitaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.baza_stara_ponisti = new System.Windows.Forms.Button();
            this.baza_stara_info = new System.Windows.Forms.Label();
            this.baza_stara_preuzmi = new System.Windows.Forms.Button();
            this.baza_stara_loader = new System.Windows.Forms.ProgressBar();
            this.baza_stara_ucitaj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backup_otvoriFolder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.backup_ucitajBazu_loader = new System.Windows.Forms.ProgressBar();
            this.backup_kreirajBazu_loader = new System.Windows.Forms.ProgressBar();
            this.backup_ucitaj = new System.Windows.Forms.Button();
            this.backup_novi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.memorija_nealocirano = new System.Windows.Forms.TextBox();
            this.memorija_ukupno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.baza_updateGodina_loader = new System.Windows.Forms.ProgressBar();
            this.baza_updateGodina = new System.Windows.Forms.Button();
            this.baza_brisanjeGrupa = new System.Windows.Forms.Button();
            this.baza_brisanjeVolontera = new System.Windows.Forms.Button();
            this.tab_PomocPretraga = new System.Windows.Forms.TabPage();
            this.btn_pomocPretraga = new System.Windows.Forms.Button();
            this.pomoc_pretragaVolontera = new System.Windows.Forms.TextBox();
            this.tab_PomocGrupe = new System.Windows.Forms.TabPage();
            this.pomoc_btnGrupe = new System.Windows.Forms.Button();
            this.pomoc_grupe = new System.Windows.Forms.TextBox();
            this.tab_PomocNovi = new System.Windows.Forms.TabPage();
            this.pomoc_btnNoviVolonter = new System.Windows.Forms.Button();
            this.pomoc_noviVolonter = new System.Windows.Forms.TextBox();
            this.tab_PomocDodatne = new System.Windows.Forms.TabPage();
            this.pomoc_btnDodatneInfo = new System.Windows.Forms.Button();
            this.pomoc_dodatneInformacije = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.admin_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.baza_staraBaza = new System.ComponentModel.BackgroundWorker();
            this.baza_worker_updateGodina = new System.ComponentModel.BackgroundWorker();
            this.backup_kreirajBazu = new System.ComponentModel.BackgroundWorker();
            this.baza_ucitajBazu = new System.ComponentModel.BackgroundWorker();
            this.spy_work = new System.ComponentModel.BackgroundWorker();
            this.tabControl.SuspendLayout();
            this.tab_nalozi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_data)).BeginInit();
            this.tab_backgroundSlika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boje_picture)).BeginInit();
            this.tab_bazaPodataka.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_PomocPretraga.SuspendLayout();
            this.tab_PomocGrupe.SuspendLayout();
            this.tab_PomocNovi.SuspendLayout();
            this.tab_PomocDodatne.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_nalozi);
            this.tabControl.Controls.Add(this.tab_backgroundSlika);
            this.tabControl.Controls.Add(this.tab_bazaPodataka);
            this.tabControl.Controls.Add(this.tab_PomocPretraga);
            this.tabControl.Controls.Add(this.tab_PomocGrupe);
            this.tabControl.Controls.Add(this.tab_PomocNovi);
            this.tabControl.Controls.Add(this.tab_PomocDodatne);
            this.tabControl.Location = new System.Drawing.Point(6, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(903, 429);
            this.tabControl.TabIndex = 0;
            // 
            // tab_nalozi
            // 
            this.tab_nalozi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.tab_nalozi.Controls.Add(this.admin_error);
            this.tab_nalozi.Controls.Add(this.admin_privilegije);
            this.tab_nalozi.Controls.Add(this.admin_btnDell);
            this.tab_nalozi.Controls.Add(this.admin_btnAdd);
            this.tab_nalozi.Controls.Add(this.label3);
            this.tab_nalozi.Controls.Add(this.admin_info);
            this.tab_nalozi.Controls.Add(this.label2);
            this.tab_nalozi.Controls.Add(this.admin_pass);
            this.tab_nalozi.Controls.Add(this.label1);
            this.tab_nalozi.Controls.Add(this.admin_user);
            this.tab_nalozi.Controls.Add(this.admin_data);
            this.tab_nalozi.Location = new System.Drawing.Point(4, 22);
            this.tab_nalozi.Name = "tab_nalozi";
            this.tab_nalozi.Padding = new System.Windows.Forms.Padding(3);
            this.tab_nalozi.Size = new System.Drawing.Size(895, 403);
            this.tab_nalozi.TabIndex = 0;
            this.tab_nalozi.Text = "Podesavanje administratorskih naloga";
            // 
            // admin_error
            // 
            this.admin_error.AutoSize = true;
            this.admin_error.Font = new System.Drawing.Font("Calibri", 9F);
            this.admin_error.ForeColor = System.Drawing.Color.Maroon;
            this.admin_error.Location = new System.Drawing.Point(401, 382);
            this.admin_error.Name = "admin_error";
            this.admin_error.Size = new System.Drawing.Size(10, 14);
            this.admin_error.TabIndex = 15;
            this.admin_error.Text = ".";
            // 
            // admin_privilegije
            // 
            this.admin_privilegije.AutoSize = true;
            this.admin_privilegije.Font = new System.Drawing.Font("Calibri", 9F);
            this.admin_privilegije.Location = new System.Drawing.Point(299, 369);
            this.admin_privilegije.Name = "admin_privilegije";
            this.admin_privilegije.Size = new System.Drawing.Size(80, 18);
            this.admin_privilegije.TabIndex = 14;
            this.admin_privilegije.Text = "Privilegije";
            this.admin_privilegije.UseVisualStyleBackColor = true;
            // 
            // admin_btnDell
            // 
            this.admin_btnDell.Location = new System.Drawing.Point(693, 338);
            this.admin_btnDell.Name = "admin_btnDell";
            this.admin_btnDell.Size = new System.Drawing.Size(192, 23);
            this.admin_btnDell.TabIndex = 13;
            this.admin_btnDell.Text = "Izbriši selektovan nalog";
            this.admin_btnDell.UseVisualStyleBackColor = true;
            this.admin_btnDell.Click += new System.EventHandler(this.admin_btnDell_Click);
            // 
            // admin_btnAdd
            // 
            this.admin_btnAdd.Location = new System.Drawing.Point(693, 364);
            this.admin_btnAdd.Name = "admin_btnAdd";
            this.admin_btnAdd.Size = new System.Drawing.Size(192, 23);
            this.admin_btnAdd.TabIndex = 12;
            this.admin_btnAdd.Text = "Dodaj nalog";
            this.admin_btnAdd.UseVisualStyleBackColor = true;
            this.admin_btnAdd.Click += new System.EventHandler(this.admin_btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F);
            this.label3.Location = new System.Drawing.Point(296, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dodatne informacije:";
            // 
            // admin_info
            // 
            this.admin_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.admin_info.Font = new System.Drawing.Font("Calibri", 9F);
            this.admin_info.Location = new System.Drawing.Point(424, 338);
            this.admin_info.Name = "admin_info";
            this.admin_info.Size = new System.Drawing.Size(251, 22);
            this.admin_info.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F);
            this.label2.Location = new System.Drawing.Point(35, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Šifra:";
            // 
            // admin_pass
            // 
            this.admin_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.admin_pass.Font = new System.Drawing.Font("Calibri", 9F);
            this.admin_pass.Location = new System.Drawing.Point(81, 363);
            this.admin_pass.Name = "admin_pass";
            this.admin_pass.Size = new System.Drawing.Size(201, 22);
            this.admin_pass.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F);
            this.label1.Location = new System.Drawing.Point(9, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username:";
            // 
            // admin_user
            // 
            this.admin_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.admin_user.Font = new System.Drawing.Font("Calibri", 9F);
            this.admin_user.Location = new System.Drawing.Point(81, 335);
            this.admin_user.Name = "admin_user";
            this.admin_user.Size = new System.Drawing.Size(201, 22);
            this.admin_user.TabIndex = 6;
            // 
            // admin_data
            // 
            this.admin_data.AllowUserToAddRows = false;
            this.admin_data.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.admin_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.admin_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.admin_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.admin_data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(222)))));
            this.admin_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.admin_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.admin_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.admin_data.Location = new System.Drawing.Point(6, 6);
            this.admin_data.MultiSelect = false;
            this.admin_data.Name = "admin_data";
            this.admin_data.RowHeadersWidth = 15;
            this.admin_data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.admin_data.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.admin_data.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_data.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.admin_data.RowTemplate.Height = 50;
            this.admin_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.admin_data.Size = new System.Drawing.Size(883, 323);
            this.admin_data.TabIndex = 5;
            // 
            // tab_backgroundSlika
            // 
            this.tab_backgroundSlika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.tab_backgroundSlika.Controls.Add(this.boje_izbrisiSliku);
            this.tab_backgroundSlika.Controls.Add(this.label11);
            this.tab_backgroundSlika.Controls.Add(this.boje_potvrdi);
            this.tab_backgroundSlika.Controls.Add(this.boje_pronadji);
            this.tab_backgroundSlika.Controls.Add(this.boje_picture);
            this.tab_backgroundSlika.Controls.Add(this.boje_zuta);
            this.tab_backgroundSlika.Controls.Add(this.boje_zelena);
            this.tab_backgroundSlika.Controls.Add(this.boje_plava);
            this.tab_backgroundSlika.Controls.Add(this.boje_ljubicasta);
            this.tab_backgroundSlika.Controls.Add(this.label6);
            this.tab_backgroundSlika.Controls.Add(this.label5);
            this.tab_backgroundSlika.Controls.Add(this.boje_crvena);
            this.tab_backgroundSlika.Location = new System.Drawing.Point(4, 22);
            this.tab_backgroundSlika.Name = "tab_backgroundSlika";
            this.tab_backgroundSlika.Padding = new System.Windows.Forms.Padding(3);
            this.tab_backgroundSlika.Size = new System.Drawing.Size(895, 403);
            this.tab_backgroundSlika.TabIndex = 1;
            this.tab_backgroundSlika.Text = "Pozadinska slika";
            // 
            // boje_izbrisiSliku
            // 
            this.boje_izbrisiSliku.Location = new System.Drawing.Point(722, 97);
            this.boje_izbrisiSliku.Name = "boje_izbrisiSliku";
            this.boje_izbrisiSliku.Size = new System.Drawing.Size(146, 27);
            this.boje_izbrisiSliku.TabIndex = 11;
            this.boje_izbrisiSliku.Text = "Izbrisi sliku";
            this.boje_izbrisiSliku.UseVisualStyleBackColor = true;
            this.boje_izbrisiSliku.Click += new System.EventHandler(this.boje_izbrisiSliku_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(120, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(308, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Promjene ce biti vidljive nakon restarta programa";
            // 
            // boje_potvrdi
            // 
            this.boje_potvrdi.Location = new System.Drawing.Point(27, 364);
            this.boje_potvrdi.Name = "boje_potvrdi";
            this.boje_potvrdi.Size = new System.Drawing.Size(75, 23);
            this.boje_potvrdi.TabIndex = 9;
            this.boje_potvrdi.Text = "Potvrdi";
            this.boje_potvrdi.UseVisualStyleBackColor = true;
            this.boje_potvrdi.Click += new System.EventHandler(this.boje_potvrdi_Click);
            // 
            // boje_pronadji
            // 
            this.boje_pronadji.Location = new System.Drawing.Point(722, 37);
            this.boje_pronadji.Name = "boje_pronadji";
            this.boje_pronadji.Size = new System.Drawing.Size(146, 54);
            this.boje_pronadji.TabIndex = 8;
            this.boje_pronadji.Text = "Pronadji sliku";
            this.boje_pronadji.UseVisualStyleBackColor = true;
            this.boje_pronadji.Click += new System.EventHandler(this.boje_pronadji_Click);
            // 
            // boje_picture
            // 
            this.boje_picture.Location = new System.Drawing.Point(28, 153);
            this.boje_picture.Name = "boje_picture";
            this.boje_picture.Size = new System.Drawing.Size(840, 205);
            this.boje_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boje_picture.TabIndex = 7;
            this.boje_picture.TabStop = false;
            // 
            // boje_zuta
            // 
            this.boje_zuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(104)))), ((int)(((byte)(51)))));
            this.boje_zuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boje_zuta.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boje_zuta.ForeColor = System.Drawing.Color.White;
            this.boje_zuta.Location = new System.Drawing.Point(533, 37);
            this.boje_zuta.Name = "boje_zuta";
            this.boje_zuta.Size = new System.Drawing.Size(109, 54);
            this.boje_zuta.TabIndex = 6;
            this.boje_zuta.Text = "zuta";
            this.boje_zuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boje_zelena
            // 
            this.boje_zelena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(105)))), ((int)(((byte)(51)))));
            this.boje_zelena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boje_zelena.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boje_zelena.ForeColor = System.Drawing.Color.White;
            this.boje_zelena.Location = new System.Drawing.Point(408, 37);
            this.boje_zelena.Name = "boje_zelena";
            this.boje_zelena.Size = new System.Drawing.Size(109, 54);
            this.boje_zelena.TabIndex = 5;
            this.boje_zelena.Text = "zelena";
            this.boje_zelena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boje_plava
            // 
            this.boje_plava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(105)))));
            this.boje_plava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boje_plava.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boje_plava.ForeColor = System.Drawing.Color.White;
            this.boje_plava.Location = new System.Drawing.Point(279, 37);
            this.boje_plava.Name = "boje_plava";
            this.boje_plava.Size = new System.Drawing.Size(109, 54);
            this.boje_plava.TabIndex = 4;
            this.boje_plava.Text = "plava";
            this.boje_plava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boje_ljubicasta
            // 
            this.boje_ljubicasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.boje_ljubicasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boje_ljubicasta.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boje_ljubicasta.ForeColor = System.Drawing.Color.White;
            this.boje_ljubicasta.Location = new System.Drawing.Point(151, 37);
            this.boje_ljubicasta.Name = "boje_ljubicasta";
            this.boje_ljubicasta.Size = new System.Drawing.Size(109, 54);
            this.boje_ljubicasta.TabIndex = 3;
            this.boje_ljubicasta.Text = "ljubicasta";
            this.boje_ljubicasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(23, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Prikaz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(24, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Odabir pozadinske boje:";
            // 
            // boje_crvena
            // 
            this.boje_crvena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.boje_crvena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boje_crvena.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boje_crvena.ForeColor = System.Drawing.Color.White;
            this.boje_crvena.Location = new System.Drawing.Point(24, 37);
            this.boje_crvena.Name = "boje_crvena";
            this.boje_crvena.Size = new System.Drawing.Size(109, 54);
            this.boje_crvena.TabIndex = 0;
            this.boje_crvena.Text = "crvena";
            this.boje_crvena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_bazaPodataka
            // 
            this.tab_bazaPodataka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.tab_bazaPodataka.Controls.Add(this.groupBox3);
            this.tab_bazaPodataka.Controls.Add(this.groupBox2);
            this.tab_bazaPodataka.Controls.Add(this.groupBox1);
            this.tab_bazaPodataka.Location = new System.Drawing.Point(4, 22);
            this.tab_bazaPodataka.Name = "tab_bazaPodataka";
            this.tab_bazaPodataka.Padding = new System.Windows.Forms.Padding(3);
            this.tab_bazaPodataka.Size = new System.Drawing.Size(895, 403);
            this.tab_bazaPodataka.TabIndex = 7;
            this.tab_bazaPodataka.Text = "Baza podataka";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.baza_NSA_ucitaj);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.baza_stara_ponisti);
            this.groupBox3.Controls.Add(this.baza_stara_info);
            this.groupBox3.Controls.Add(this.baza_stara_preuzmi);
            this.groupBox3.Controls.Add(this.baza_stara_loader);
            this.groupBox3.Controls.Add(this.baza_stara_ucitaj);
            this.groupBox3.Location = new System.Drawing.Point(12, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(874, 115);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Učitavanje stare baze podataka";
            // 
            // baza_NSA_ucitaj
            // 
            this.baza_NSA_ucitaj.Location = new System.Drawing.Point(238, 84);
            this.baza_NSA_ucitaj.Name = "baza_NSA_ucitaj";
            this.baza_NSA_ucitaj.Size = new System.Drawing.Size(63, 23);
            this.baza_NSA_ucitaj.TabIndex = 6;
            this.baza_NSA_ucitaj.Text = "NSA";
            this.baza_NSA_ucitaj.UseVisualStyleBackColor = true;
            this.baza_NSA_ucitaj.Click += new System.EventHandler(this.baza_NSA_ucitaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(15, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 56);
            this.label4.TabIndex = 5;
            this.label4.Text = "Baza mora da bude ona Microsoft access \r\nbaza koju ste prije koristili.\r\nPobrinit" +
                "e se da izbrišete sva prazna polja iz\r\nte baze prije nego što je pokrenete!";
            // 
            // baza_stara_ponisti
            // 
            this.baza_stara_ponisti.Location = new System.Drawing.Point(633, 82);
            this.baza_stara_ponisti.Name = "baza_stara_ponisti";
            this.baza_stara_ponisti.Size = new System.Drawing.Size(211, 23);
            this.baza_stara_ponisti.TabIndex = 4;
            this.baza_stara_ponisti.Text = "Poništi preuzetu bazu";
            this.baza_stara_ponisti.UseVisualStyleBackColor = true;
            this.baza_stara_ponisti.Visible = false;
            this.baza_stara_ponisti.Click += new System.EventHandler(this.baza_stara_ponisti_Click);
            // 
            // baza_stara_info
            // 
            this.baza_stara_info.AutoSize = true;
            this.baza_stara_info.Font = new System.Drawing.Font("Calibri", 9F);
            this.baza_stara_info.Location = new System.Drawing.Point(355, 37);
            this.baza_stara_info.Name = "baza_stara_info";
            this.baza_stara_info.Size = new System.Drawing.Size(489, 14);
            this.baza_stara_info.TabIndex = 3;
            this.baza_stara_info.Text = "U selektovanoj bazi nalazi se 145 volontera. Volonteri će biti nadodati na postoj" +
                "eću bazu";
            this.baza_stara_info.Visible = false;
            // 
            // baza_stara_preuzmi
            // 
            this.baza_stara_preuzmi.Location = new System.Drawing.Point(353, 82);
            this.baza_stara_preuzmi.Name = "baza_stara_preuzmi";
            this.baza_stara_preuzmi.Size = new System.Drawing.Size(274, 23);
            this.baza_stara_preuzmi.TabIndex = 2;
            this.baza_stara_preuzmi.Text = "Prezmi podatke";
            this.baza_stara_preuzmi.UseVisualStyleBackColor = true;
            this.baza_stara_preuzmi.Visible = false;
            this.baza_stara_preuzmi.Click += new System.EventHandler(this.baza_stara_preuzmi_Click);
            // 
            // baza_stara_loader
            // 
            this.baza_stara_loader.Location = new System.Drawing.Point(355, 55);
            this.baza_stara_loader.Name = "baza_stara_loader";
            this.baza_stara_loader.Size = new System.Drawing.Size(489, 23);
            this.baza_stara_loader.TabIndex = 1;
            this.baza_stara_loader.Visible = false;
            // 
            // baza_stara_ucitaj
            // 
            this.baza_stara_ucitaj.Location = new System.Drawing.Point(15, 84);
            this.baza_stara_ucitaj.Name = "baza_stara_ucitaj";
            this.baza_stara_ucitaj.Size = new System.Drawing.Size(217, 23);
            this.baza_stara_ucitaj.TabIndex = 0;
            this.baza_stara_ucitaj.Text = "Učitaj staru bazu podataka";
            this.baza_stara_ucitaj.UseVisualStyleBackColor = true;
            this.baza_stara_ucitaj.Click += new System.EventHandler(this.baza_stara_ucitaj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.backup_otvoriFolder);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.backup_ucitajBazu_loader);
            this.groupBox2.Controls.Add(this.backup_kreirajBazu_loader);
            this.groupBox2.Controls.Add(this.backup_ucitaj);
            this.groupBox2.Controls.Add(this.backup_novi);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup baze podataka";
            // 
            // backup_otvoriFolder
            // 
            this.backup_otvoriFolder.Location = new System.Drawing.Point(18, 74);
            this.backup_otvoriFolder.Name = "backup_otvoriFolder";
            this.backup_otvoriFolder.Size = new System.Drawing.Size(283, 23);
            this.backup_otvoriFolder.TabIndex = 9;
            this.backup_otvoriFolder.Text = "Otvori folder sa backup-ovima";
            this.backup_otvoriFolder.UseVisualStyleBackColor = true;
            this.backup_otvoriFolder.Click += new System.EventHandler(this.backup_otvoriFolder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(15, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(613, 42);
            this.label7.TabIndex = 6;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // backup_ucitajBazu_loader
            // 
            this.backup_ucitajBazu_loader.Location = new System.Drawing.Point(307, 126);
            this.backup_ucitajBazu_loader.Name = "backup_ucitajBazu_loader";
            this.backup_ucitajBazu_loader.Size = new System.Drawing.Size(537, 23);
            this.backup_ucitajBazu_loader.TabIndex = 4;
            this.backup_ucitajBazu_loader.Visible = false;
            // 
            // backup_kreirajBazu_loader
            // 
            this.backup_kreirajBazu_loader.Location = new System.Drawing.Point(307, 100);
            this.backup_kreirajBazu_loader.Name = "backup_kreirajBazu_loader";
            this.backup_kreirajBazu_loader.Size = new System.Drawing.Size(537, 23);
            this.backup_kreirajBazu_loader.TabIndex = 3;
            this.backup_kreirajBazu_loader.Visible = false;
            // 
            // backup_ucitaj
            // 
            this.backup_ucitaj.Location = new System.Drawing.Point(18, 126);
            this.backup_ucitaj.Name = "backup_ucitaj";
            this.backup_ucitaj.Size = new System.Drawing.Size(283, 23);
            this.backup_ucitaj.TabIndex = 2;
            this.backup_ucitaj.Text = "Učitaj backup na postojeću bazu";
            this.backup_ucitaj.UseVisualStyleBackColor = true;
            this.backup_ucitaj.Click += new System.EventHandler(this.backup_ucitaj_Click);
            // 
            // backup_novi
            // 
            this.backup_novi.Location = new System.Drawing.Point(18, 100);
            this.backup_novi.Name = "backup_novi";
            this.backup_novi.Size = new System.Drawing.Size(283, 23);
            this.backup_novi.TabIndex = 0;
            this.backup_novi.Text = "Kreiraj novi backup";
            this.backup_novi.UseVisualStyleBackColor = true;
            this.backup_novi.Click += new System.EventHandler(this.backup_novi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.memorija_nealocirano);
            this.groupBox1.Controls.Add(this.memorija_ukupno);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.baza_updateGodina_loader);
            this.groupBox1.Controls.Add(this.baza_updateGodina);
            this.groupBox1.Controls.Add(this.baza_brisanjeGrupa);
            this.groupBox1.Controls.Add(this.baza_brisanjeVolontera);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Postojeća baza";
            // 
            // memorija_nealocirano
            // 
            this.memorija_nealocirano.Location = new System.Drawing.Point(745, 41);
            this.memorija_nealocirano.Name = "memorija_nealocirano";
            this.memorija_nealocirano.ReadOnly = true;
            this.memorija_nealocirano.Size = new System.Drawing.Size(100, 20);
            this.memorija_nealocirano.TabIndex = 7;
            // 
            // memorija_ukupno
            // 
            this.memorija_ukupno.Location = new System.Drawing.Point(745, 19);
            this.memorija_ukupno.Name = "memorija_ukupno";
            this.memorija_ukupno.ReadOnly = true;
            this.memorija_ukupno.Size = new System.Drawing.Size(100, 20);
            this.memorija_ukupno.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(626, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ne alocirana memorija:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(562, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Memorija koju baza podataka koristi:";
            // 
            // baza_updateGodina_loader
            // 
            this.baza_updateGodina_loader.Location = new System.Drawing.Point(221, 66);
            this.baza_updateGodina_loader.Name = "baza_updateGodina_loader";
            this.baza_updateGodina_loader.Size = new System.Drawing.Size(623, 23);
            this.baza_updateGodina_loader.TabIndex = 3;
            this.baza_updateGodina_loader.Visible = false;
            // 
            // baza_updateGodina
            // 
            this.baza_updateGodina.Location = new System.Drawing.Point(18, 67);
            this.baza_updateGodina.Name = "baza_updateGodina";
            this.baza_updateGodina.Size = new System.Drawing.Size(187, 23);
            this.baza_updateGodina.TabIndex = 2;
            this.baza_updateGodina.Text = "Update godina volontera";
            this.baza_updateGodina.UseVisualStyleBackColor = true;
            this.baza_updateGodina.Click += new System.EventHandler(this.baza_updateGodina_Click);
            // 
            // baza_brisanjeGrupa
            // 
            this.baza_brisanjeGrupa.Location = new System.Drawing.Point(18, 43);
            this.baza_brisanjeGrupa.Name = "baza_brisanjeGrupa";
            this.baza_brisanjeGrupa.Size = new System.Drawing.Size(187, 23);
            this.baza_brisanjeGrupa.TabIndex = 1;
            this.baza_brisanjeGrupa.Text = "Brisanje svih grupa";
            this.baza_brisanjeGrupa.UseVisualStyleBackColor = true;
            this.baza_brisanjeGrupa.Click += new System.EventHandler(this.baza_brisanjeGrupa_Click);
            // 
            // baza_brisanjeVolontera
            // 
            this.baza_brisanjeVolontera.Location = new System.Drawing.Point(18, 19);
            this.baza_brisanjeVolontera.Name = "baza_brisanjeVolontera";
            this.baza_brisanjeVolontera.Size = new System.Drawing.Size(187, 23);
            this.baza_brisanjeVolontera.TabIndex = 0;
            this.baza_brisanjeVolontera.Text = "Brisanje svih volontera";
            this.baza_brisanjeVolontera.UseVisualStyleBackColor = true;
            this.baza_brisanjeVolontera.Click += new System.EventHandler(this.baza_brisanjeVolontera_Click);
            // 
            // tab_PomocPretraga
            // 
            this.tab_PomocPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.tab_PomocPretraga.Controls.Add(this.btn_pomocPretraga);
            this.tab_PomocPretraga.Controls.Add(this.pomoc_pretragaVolontera);
            this.tab_PomocPretraga.Location = new System.Drawing.Point(4, 22);
            this.tab_PomocPretraga.Name = "tab_PomocPretraga";
            this.tab_PomocPretraga.Padding = new System.Windows.Forms.Padding(3);
            this.tab_PomocPretraga.Size = new System.Drawing.Size(895, 403);
            this.tab_PomocPretraga.TabIndex = 3;
            this.tab_PomocPretraga.Text = "Pomoć - Pretraga volonetra";
            // 
            // btn_pomocPretraga
            // 
            this.btn_pomocPretraga.Location = new System.Drawing.Point(5, 375);
            this.btn_pomocPretraga.Name = "btn_pomocPretraga";
            this.btn_pomocPretraga.Size = new System.Drawing.Size(426, 23);
            this.btn_pomocPretraga.TabIndex = 4;
            this.btn_pomocPretraga.Text = "Sačuvaj promjene \"Pomoć pretraga volontera\"";
            this.btn_pomocPretraga.UseVisualStyleBackColor = true;
            this.btn_pomocPretraga.Click += new System.EventHandler(this.btn_pomocPretraga_Click);
            // 
            // pomoc_pretragaVolontera
            // 
            this.pomoc_pretragaVolontera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pomoc_pretragaVolontera.BackColor = System.Drawing.Color.White;
            this.pomoc_pretragaVolontera.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pomoc_pretragaVolontera.ForeColor = System.Drawing.Color.Black;
            this.pomoc_pretragaVolontera.Location = new System.Drawing.Point(6, 3);
            this.pomoc_pretragaVolontera.Multiline = true;
            this.pomoc_pretragaVolontera.Name = "pomoc_pretragaVolontera";
            this.pomoc_pretragaVolontera.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pomoc_pretragaVolontera.Size = new System.Drawing.Size(883, 370);
            this.pomoc_pretragaVolontera.TabIndex = 3;
            // 
            // tab_PomocGrupe
            // 
            this.tab_PomocGrupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.tab_PomocGrupe.Controls.Add(this.pomoc_btnGrupe);
            this.tab_PomocGrupe.Controls.Add(this.pomoc_grupe);
            this.tab_PomocGrupe.Location = new System.Drawing.Point(4, 22);
            this.tab_PomocGrupe.Name = "tab_PomocGrupe";
            this.tab_PomocGrupe.Padding = new System.Windows.Forms.Padding(3);
            this.tab_PomocGrupe.Size = new System.Drawing.Size(895, 403);
            this.tab_PomocGrupe.TabIndex = 4;
            this.tab_PomocGrupe.Text = "Pomoć - Grupe";
            // 
            // pomoc_btnGrupe
            // 
            this.pomoc_btnGrupe.Location = new System.Drawing.Point(5, 376);
            this.pomoc_btnGrupe.Name = "pomoc_btnGrupe";
            this.pomoc_btnGrupe.Size = new System.Drawing.Size(426, 23);
            this.pomoc_btnGrupe.TabIndex = 6;
            this.pomoc_btnGrupe.Text = "Sačuvaj promjene \"Pomoć grupe\"";
            this.pomoc_btnGrupe.UseVisualStyleBackColor = true;
            this.pomoc_btnGrupe.Click += new System.EventHandler(this.pomoc_btnGrupe_Click);
            // 
            // pomoc_grupe
            // 
            this.pomoc_grupe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pomoc_grupe.BackColor = System.Drawing.Color.White;
            this.pomoc_grupe.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pomoc_grupe.ForeColor = System.Drawing.Color.Black;
            this.pomoc_grupe.Location = new System.Drawing.Point(6, 4);
            this.pomoc_grupe.Multiline = true;
            this.pomoc_grupe.Name = "pomoc_grupe";
            this.pomoc_grupe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pomoc_grupe.Size = new System.Drawing.Size(883, 370);
            this.pomoc_grupe.TabIndex = 5;
            // 
            // tab_PomocNovi
            // 
            this.tab_PomocNovi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.tab_PomocNovi.Controls.Add(this.pomoc_btnNoviVolonter);
            this.tab_PomocNovi.Controls.Add(this.pomoc_noviVolonter);
            this.tab_PomocNovi.Location = new System.Drawing.Point(4, 22);
            this.tab_PomocNovi.Name = "tab_PomocNovi";
            this.tab_PomocNovi.Padding = new System.Windows.Forms.Padding(3);
            this.tab_PomocNovi.Size = new System.Drawing.Size(895, 403);
            this.tab_PomocNovi.TabIndex = 5;
            this.tab_PomocNovi.Text = "Pomoć - Novi volonter";
            // 
            // pomoc_btnNoviVolonter
            // 
            this.pomoc_btnNoviVolonter.Location = new System.Drawing.Point(5, 376);
            this.pomoc_btnNoviVolonter.Name = "pomoc_btnNoviVolonter";
            this.pomoc_btnNoviVolonter.Size = new System.Drawing.Size(426, 23);
            this.pomoc_btnNoviVolonter.TabIndex = 6;
            this.pomoc_btnNoviVolonter.Text = "Sačuvaj promjene \"Pomoć novi volonter\"";
            this.pomoc_btnNoviVolonter.UseVisualStyleBackColor = true;
            this.pomoc_btnNoviVolonter.Click += new System.EventHandler(this.pomoc_btnNoviVolonter_Click);
            // 
            // pomoc_noviVolonter
            // 
            this.pomoc_noviVolonter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pomoc_noviVolonter.BackColor = System.Drawing.Color.White;
            this.pomoc_noviVolonter.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pomoc_noviVolonter.ForeColor = System.Drawing.Color.Black;
            this.pomoc_noviVolonter.Location = new System.Drawing.Point(6, 4);
            this.pomoc_noviVolonter.Multiline = true;
            this.pomoc_noviVolonter.Name = "pomoc_noviVolonter";
            this.pomoc_noviVolonter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pomoc_noviVolonter.Size = new System.Drawing.Size(883, 370);
            this.pomoc_noviVolonter.TabIndex = 5;
            // 
            // tab_PomocDodatne
            // 
            this.tab_PomocDodatne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.tab_PomocDodatne.Controls.Add(this.pomoc_btnDodatneInfo);
            this.tab_PomocDodatne.Controls.Add(this.pomoc_dodatneInformacije);
            this.tab_PomocDodatne.Location = new System.Drawing.Point(4, 22);
            this.tab_PomocDodatne.Name = "tab_PomocDodatne";
            this.tab_PomocDodatne.Padding = new System.Windows.Forms.Padding(3);
            this.tab_PomocDodatne.Size = new System.Drawing.Size(895, 403);
            this.tab_PomocDodatne.TabIndex = 6;
            this.tab_PomocDodatne.Text = "Pomoć - Dodatne informacije";
            // 
            // pomoc_btnDodatneInfo
            // 
            this.pomoc_btnDodatneInfo.Location = new System.Drawing.Point(5, 376);
            this.pomoc_btnDodatneInfo.Name = "pomoc_btnDodatneInfo";
            this.pomoc_btnDodatneInfo.Size = new System.Drawing.Size(426, 23);
            this.pomoc_btnDodatneInfo.TabIndex = 6;
            this.pomoc_btnDodatneInfo.Text = "Sačuvaj promjene \"Pomoć dodatne informacije\"";
            this.pomoc_btnDodatneInfo.UseVisualStyleBackColor = true;
            this.pomoc_btnDodatneInfo.Click += new System.EventHandler(this.pomoc_btnDodatneInfo_Click);
            // 
            // pomoc_dodatneInformacije
            // 
            this.pomoc_dodatneInformacije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pomoc_dodatneInformacije.BackColor = System.Drawing.Color.White;
            this.pomoc_dodatneInformacije.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pomoc_dodatneInformacije.ForeColor = System.Drawing.Color.Black;
            this.pomoc_dodatneInformacije.Location = new System.Drawing.Point(6, 4);
            this.pomoc_dodatneInformacije.Multiline = true;
            this.pomoc_dodatneInformacije.Name = "pomoc_dodatneInformacije";
            this.pomoc_dodatneInformacije.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pomoc_dodatneInformacije.Size = new System.Drawing.Size(883, 370);
            this.pomoc_dodatneInformacije.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admin_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(921, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // admin_status
            // 
            this.admin_status.BackColor = System.Drawing.Color.Transparent;
            this.admin_status.Name = "admin_status";
            this.admin_status.Size = new System.Drawing.Size(118, 17);
            this.admin_status.Text = "toolStripStatusLabel1";
            // 
            // baza_staraBaza
            // 
            this.baza_staraBaza.WorkerReportsProgress = true;
            this.baza_staraBaza.DoWork += new System.ComponentModel.DoWorkEventHandler(this.baza_staraBaza_DoWork);
            this.baza_staraBaza.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.baza_staraBaza_ProgressChanged);
            this.baza_staraBaza.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.baza_staraBaza_RunWorkerCompleted);
            // 
            // baza_worker_updateGodina
            // 
            this.baza_worker_updateGodina.WorkerReportsProgress = true;
            this.baza_worker_updateGodina.DoWork += new System.ComponentModel.DoWorkEventHandler(this.baza_worker_updateGodina_DoWork);
            this.baza_worker_updateGodina.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.baza_worker_updateGodina_ProgressChanged);
            this.baza_worker_updateGodina.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.baza_worker_updateGodina_RunWorkerCompleted);
            // 
            // backup_kreirajBazu
            // 
            this.backup_kreirajBazu.WorkerReportsProgress = true;
            this.backup_kreirajBazu.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backup_kreirajBazu_DoWork);
            this.backup_kreirajBazu.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backup_kreirajBazu_ProgressChanged);
            this.backup_kreirajBazu.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backup_kreirajBazu_RunWorkerCompleted);
            // 
            // baza_ucitajBazu
            // 
            this.baza_ucitajBazu.WorkerReportsProgress = true;
            this.baza_ucitajBazu.DoWork += new System.ComponentModel.DoWorkEventHandler(this.baza_ucitajBazu_DoWork);
            this.baza_ucitajBazu.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.baza_ucitajBazu_ProgressChanged);
            this.baza_ucitajBazu.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.baza_ucitajBazu_RunWorkerCompleted);
            // 
            // spy_work
            // 
            this.spy_work.WorkerReportsProgress = true;
            this.spy_work.DoWork += new System.ComponentModel.DoWorkEventHandler(this.spy_work_DoWork);
            this.spy_work.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.spy_work_ProgressChanged);
            this.spy_work.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.spy_work_RunWorkerCompleted);
            // 
            // Form_Administracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(921, 460);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(937, 498);
            this.MinimumSize = new System.Drawing.Size(937, 498);
            this.Name = "Form_Administracija";
            this.Text = "Administracija baze";
            this.Load += new System.EventHandler(this.Form_Administracija_Load);
            this.tabControl.ResumeLayout(false);
            this.tab_nalozi.ResumeLayout(false);
            this.tab_nalozi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_data)).EndInit();
            this.tab_backgroundSlika.ResumeLayout(false);
            this.tab_backgroundSlika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boje_picture)).EndInit();
            this.tab_bazaPodataka.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_PomocPretraga.ResumeLayout(false);
            this.tab_PomocPretraga.PerformLayout();
            this.tab_PomocGrupe.ResumeLayout(false);
            this.tab_PomocGrupe.PerformLayout();
            this.tab_PomocNovi.ResumeLayout(false);
            this.tab_PomocNovi.PerformLayout();
            this.tab_PomocDodatne.ResumeLayout(false);
            this.tab_PomocDodatne.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_nalozi;
        private System.Windows.Forms.TabPage tab_backgroundSlika;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView admin_data;
        private System.Windows.Forms.Button admin_btnDell;
        private System.Windows.Forms.Button admin_btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox admin_info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox admin_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox admin_user;
        private System.Windows.Forms.CheckBox admin_privilegije;
        private System.Windows.Forms.Label admin_error;
        private System.Windows.Forms.ToolStripStatusLabel admin_status;
        private System.Windows.Forms.TabPage tab_PomocPretraga;
        private System.Windows.Forms.TabPage tab_PomocGrupe;
        private System.Windows.Forms.TabPage tab_PomocNovi;
        private System.Windows.Forms.TabPage tab_PomocDodatne;
        private System.Windows.Forms.Button btn_pomocPretraga;
        private System.Windows.Forms.TextBox pomoc_pretragaVolontera;
        private System.Windows.Forms.Button pomoc_btnGrupe;
        private System.Windows.Forms.TextBox pomoc_grupe;
        private System.Windows.Forms.Button pomoc_btnNoviVolonter;
        private System.Windows.Forms.TextBox pomoc_noviVolonter;
        private System.Windows.Forms.Button pomoc_btnDodatneInfo;
        private System.Windows.Forms.TextBox pomoc_dodatneInformacije;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button boje_potvrdi;
        private System.Windows.Forms.Button boje_pronadji;
        private System.Windows.Forms.PictureBox boje_picture;
        private System.Windows.Forms.Label boje_zuta;
        private System.Windows.Forms.Label boje_zelena;
        private System.Windows.Forms.Label boje_plava;
        private System.Windows.Forms.Label boje_ljubicasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label boje_crvena;
        private System.Windows.Forms.Button boje_izbrisiSliku;
        private System.Windows.Forms.TabPage tab_bazaPodataka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button baza_brisanjeGrupa;
        private System.Windows.Forms.Button baza_brisanjeVolontera;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button baza_stara_ponisti;
        private System.Windows.Forms.Label baza_stara_info;
        private System.Windows.Forms.Button baza_stara_preuzmi;
        private System.Windows.Forms.ProgressBar baza_stara_loader;
        private System.ComponentModel.BackgroundWorker baza_staraBaza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button baza_updateGodina;
        private System.ComponentModel.BackgroundWorker baza_worker_updateGodina;
        private System.Windows.Forms.ProgressBar baza_updateGodina_loader;
        private System.Windows.Forms.Button backup_ucitaj;
        private System.Windows.Forms.Button backup_novi;
        private System.Windows.Forms.ProgressBar backup_ucitajBazu_loader;
        private System.Windows.Forms.ProgressBar backup_kreirajBazu_loader;
        private System.ComponentModel.BackgroundWorker backup_kreirajBazu;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker baza_ucitajBazu;
        private System.Windows.Forms.TextBox memorija_nealocirano;
        private System.Windows.Forms.TextBox memorija_ukupno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button backup_otvoriFolder;
        private System.Windows.Forms.Button baza_NSA_ucitaj;
        private System.Windows.Forms.Button baza_stara_ucitaj;
        private System.ComponentModel.BackgroundWorker spy_work;
    }
}