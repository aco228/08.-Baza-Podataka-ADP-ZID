namespace _08.Baza_Podataka_ADP_ZID
{
    partial class Grupa_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grupa_Info));
            this.info_naslov = new System.Windows.Forms.Label();
            this.info_opis = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_brVolontera = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_izbrisiGrupu = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_izmjeni = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_izbrisiClana = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.info_sati = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // info_naslov
            // 
            this.info_naslov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.info_naslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(224)))));
            this.info_naslov.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info_naslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.info_naslov.Location = new System.Drawing.Point(12, 29);
            this.info_naslov.Name = "info_naslov";
            this.info_naslov.Size = new System.Drawing.Size(699, 19);
            this.info_naslov.TabIndex = 0;
            this.info_naslov.Text = "Radi se o tebi";
            // 
            // info_opis
            // 
            this.info_opis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.info_opis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.info_opis.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info_opis.Location = new System.Drawing.Point(13, 53);
            this.info_opis.Name = "info_opis";
            this.info_opis.Size = new System.Drawing.Size(602, 55);
            this.info_opis.TabIndex = 1;
            this.info_opis.Text = resources.GetString("info_opis.Text");
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data.Location = new System.Drawing.Point(12, 111);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.data.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.data.RowTemplate.Height = 50;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(699, 348);
            this.data.TabIndex = 3;
            this.data.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_CellMouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_brVolontera});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(723, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_brVolontera
            // 
            this.status_brVolontera.BackColor = System.Drawing.Color.Transparent;
            this.status_brVolontera.Name = "status_brVolontera";
            this.status_brVolontera.Size = new System.Drawing.Size(118, 17);
            this.status_brVolontera.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_izbrisiGrupu,
            this.btn_izmjeni,
            this.btn_izbrisiClana});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_izbrisiGrupu
            // 
            this.btn_izbrisiGrupu.Name = "btn_izbrisiGrupu";
            this.btn_izbrisiGrupu.Size = new System.Drawing.Size(84, 20);
            this.btn_izbrisiGrupu.Text = "Izbriši grupu";
            this.btn_izbrisiGrupu.Click += new System.EventHandler(this.btn_izbrisiGrupu_Click);
            // 
            // btn_izmjeni
            // 
            this.btn_izmjeni.Name = "btn_izmjeni";
            this.btn_izmjeni.Size = new System.Drawing.Size(165, 20);
            this.btn_izmjeni.Text = "Izmjeni informacije o grupu";
            this.btn_izmjeni.Click += new System.EventHandler(this.btn_izmjeni_Click);
            // 
            // btn_izbrisiClana
            // 
            this.btn_izbrisiClana.Name = "btn_izbrisiClana";
            this.btn_izbrisiClana.Size = new System.Drawing.Size(220, 20);
            this.btn_izbrisiClana.Text = "Izbriši selektovanog volontera iz grupe";
            this.btn_izbrisiClana.Click += new System.EventHandler(this.btn_izbrisiClana_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F);
            this.label1.Location = new System.Drawing.Point(620, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Broj sati:";
            // 
            // info_sati
            // 
            this.info_sati.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.info_sati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.info_sati.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info_sati.Location = new System.Drawing.Point(622, 69);
            this.info_sati.Name = "info_sati";
            this.info_sati.Size = new System.Drawing.Size(87, 15);
            this.info_sati.TabIndex = 9;
            this.info_sati.Text = "15";
            // 
            // Grupa_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(723, 484);
            this.Controls.Add(this.info_sati);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.info_opis);
            this.Controls.Add(this.info_naslov);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Grupa_Info";
            this.Text = "Grupa_Info";
            this.Load += new System.EventHandler(this.Grupa_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info_naslov;
        private System.Windows.Forms.Label info_opis;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_brVolontera;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_izbrisiGrupu;
        private System.Windows.Forms.ToolStripMenuItem btn_izmjeni;
        private System.Windows.Forms.ToolStripMenuItem btn_izbrisiClana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info_sati;
    }
}