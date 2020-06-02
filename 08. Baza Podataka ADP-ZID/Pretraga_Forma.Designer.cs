namespace _08.Baza_Podataka_ADP_ZID
{
    partial class Pretraga_Forma
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pretraga_Forma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_noviClan = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_grupe = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_novaGrupa = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_dodajVolontera = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_vazneInformacije = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_brojRezultata = new System.Windows.Forms.ToolStripStatusLabel();
            this.ikone = new System.Windows.Forms.ImageList(this.components);
            this.pretraga_unos = new System.Windows.Forms.TextBox();
            this.btn_pretraga = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.combo_grupe = new System.Windows.Forms.ComboBox();
            this.combo_aktivnost = new System.Windows.Forms.ComboBox();
            this.worker_preuzimanjePodataka = new System.ComponentModel.BackgroundWorker();
            this.loading_panel = new System.Windows.Forms.Panel();
            this.label75 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.loading_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_noviClan,
            this.btn_grupe,
            this.btn_novaGrupa,
            this.btn_dodajVolontera,
            this.btn_vazneInformacije});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_noviClan
            // 
            this.btn_noviClan.Name = "btn_noviClan";
            this.btn_noviClan.Size = new System.Drawing.Size(140, 20);
            this.btn_noviClan.Text = "Dodaj novog volontera";
            this.btn_noviClan.Click += new System.EventHandler(this.btn_noviClan_Click);
            // 
            // btn_grupe
            // 
            this.btn_grupe.Name = "btn_grupe";
            this.btn_grupe.Size = new System.Drawing.Size(51, 20);
            this.btn_grupe.Text = "Grupe";
            this.btn_grupe.Click += new System.EventHandler(this.btn_grupe_Click);
            // 
            // btn_novaGrupa
            // 
            this.btn_novaGrupa.Name = "btn_novaGrupa";
            this.btn_novaGrupa.Size = new System.Drawing.Size(115, 20);
            this.btn_novaGrupa.Text = "Dodaj novu grupu";
            this.btn_novaGrupa.Click += new System.EventHandler(this.btn_novaGrupa_Click);
            // 
            // btn_dodajVolontera
            // 
            this.btn_dodajVolontera.Name = "btn_dodajVolontera";
            this.btn_dodajVolontera.Size = new System.Drawing.Size(148, 20);
            this.btn_dodajVolontera.Text = "Dodaj volontera u grupu";
            this.btn_dodajVolontera.Click += new System.EventHandler(this.btn_dodajVolontera_Click);
            // 
            // btn_vazneInformacije
            // 
            this.btn_vazneInformacije.Name = "btn_vazneInformacije";
            this.btn_vazneInformacije.Size = new System.Drawing.Size(216, 20);
            this.btn_vazneInformacije.Text = "Par važnih informacija u vezi pretrage";
            this.btn_vazneInformacije.Click += new System.EventHandler(this.btn_vazneInformacije_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_brojRezultata});
            this.statusStrip1.Location = new System.Drawing.Point(0, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(936, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Broj rezultata je ";
            // 
            // status_brojRezultata
            // 
            this.status_brojRezultata.BackColor = System.Drawing.Color.Transparent;
            this.status_brojRezultata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.status_brojRezultata.Name = "status_brojRezultata";
            this.status_brojRezultata.Size = new System.Drawing.Size(118, 17);
            this.status_brojRezultata.Text = "toolStripStatusLabel1";
            // 
            // ikone
            // 
            this.ikone.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ikone.ImageStream")));
            this.ikone.TransparentColor = System.Drawing.Color.Transparent;
            this.ikone.Images.SetKeyName(0, "grupe_add.png");
            this.ikone.Images.SetKeyName(1, "ja_sam.png");
            this.ikone.Images.SetKeyName(2, "omiljeno.png");
            // 
            // pretraga_unos
            // 
            this.pretraga_unos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pretraga_unos.BackColor = System.Drawing.Color.White;
            this.pretraga_unos.Font = new System.Drawing.Font("Calibri", 9F);
            this.pretraga_unos.Location = new System.Drawing.Point(6, 29);
            this.pretraga_unos.Name = "pretraga_unos";
            this.pretraga_unos.Size = new System.Drawing.Size(548, 22);
            this.pretraga_unos.TabIndex = 5;
            this.pretraga_unos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pretraga_unos_KeyDown);
            // 
            // btn_pretraga
            // 
            this.btn_pretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.btn_pretraga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pretraga.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_pretraga.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_pretraga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_pretraga.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pretraga.ImageKey = "(none)";
            this.btn_pretraga.ImageList = this.ikone;
            this.btn_pretraga.Location = new System.Drawing.Point(808, 28);
            this.btn_pretraga.Name = "btn_pretraga";
            this.btn_pretraga.Size = new System.Drawing.Size(116, 25);
            this.btn_pretraga.TabIndex = 6;
            this.btn_pretraga.Text = "Pretraži";
            this.btn_pretraga.UseVisualStyleBackColor = false;
            this.btn_pretraga.Click += new System.EventHandler(this.btn_pretraga_Click);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data.Location = new System.Drawing.Point(0, 56);
            this.data.Margin = new System.Windows.Forms.Padding(0);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.data.RowHeadersWidth = 15;
            this.data.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.data.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.data.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(96)))), ((int)(((byte)(141)))));
            this.data.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.data.RowTemplate.Height = 18;
            this.data.RowTemplate.ReadOnly = true;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(936, 400);
            this.data.TabIndex = 7;
            this.data.VirtualMode = true;
            this.data.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_CellMouseDoubleClick);
            this.data.Sorted += new System.EventHandler(this.data_Sorted);
            this.data.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_KeyDown);
            // 
            // combo_grupe
            // 
            this.combo_grupe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_grupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.combo_grupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_grupe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combo_grupe.Font = new System.Drawing.Font("Calibri", 9F);
            this.combo_grupe.FormattingEnabled = true;
            this.combo_grupe.Location = new System.Drawing.Point(684, 30);
            this.combo_grupe.Name = "combo_grupe";
            this.combo_grupe.Size = new System.Drawing.Size(121, 22);
            this.combo_grupe.TabIndex = 8;
            this.combo_grupe.SelectedIndexChanged += new System.EventHandler(this.combo_grupe_SelectedIndexChanged);
            // 
            // combo_aktivnost
            // 
            this.combo_aktivnost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_aktivnost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.combo_aktivnost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_aktivnost.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combo_aktivnost.Font = new System.Drawing.Font("Calibri", 9F);
            this.combo_aktivnost.FormattingEnabled = true;
            this.combo_aktivnost.Items.AddRange(new object[] {
            "Prikaži sve",
            "Aktivan",
            "Neaktivan",
            "Tu i tamo"});
            this.combo_aktivnost.Location = new System.Drawing.Point(560, 30);
            this.combo_aktivnost.Name = "combo_aktivnost";
            this.combo_aktivnost.Size = new System.Drawing.Size(121, 22);
            this.combo_aktivnost.TabIndex = 9;
            // 
            // worker_preuzimanjePodataka
            // 
            this.worker_preuzimanjePodataka.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_preuzimanjePodataka_DoWork);
            // 
            // loading_panel
            // 
            this.loading_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loading_panel.Controls.Add(this.label75);
            this.loading_panel.Location = new System.Drawing.Point(303, 138);
            this.loading_panel.Name = "loading_panel";
            this.loading_panel.Size = new System.Drawing.Size(378, 210);
            this.loading_panel.TabIndex = 152;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(83, 97);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(212, 19);
            this.label75.TabIndex = 0;
            this.label75.Text = "Preuzimanje podataka iz baze...";
            // 
            // Pretraga_Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(936, 478);
            this.Controls.Add(this.loading_panel);
            this.Controls.Add(this.combo_aktivnost);
            this.Controls.Add(this.combo_grupe);
            this.Controls.Add(this.data);
            this.Controls.Add(this.btn_pretraga);
            this.Controls.Add(this.pretraga_unos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pretraga_Forma";
            this.Text = "Pretraga_Forma";
            this.Load += new System.EventHandler(this.Pretraga_Forma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.loading_panel.ResumeLayout(false);
            this.loading_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_noviClan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ImageList ikone;
        private System.Windows.Forms.TextBox pretraga_unos;
        private System.Windows.Forms.Button btn_pretraga;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.ComboBox combo_grupe;
        private System.Windows.Forms.ComboBox combo_aktivnost;
        private System.Windows.Forms.ToolStripStatusLabel status_brojRezultata;
        private System.Windows.Forms.ToolStripMenuItem btn_novaGrupa;
        private System.Windows.Forms.ToolStripMenuItem btn_dodajVolontera;
        private System.Windows.Forms.ToolStripMenuItem btn_grupe;
        private System.ComponentModel.BackgroundWorker worker_preuzimanjePodataka;
        private System.Windows.Forms.ToolStripMenuItem btn_vazneInformacije;
        private System.Windows.Forms.Panel loading_panel;
        private System.Windows.Forms.Label label75;
    }
}