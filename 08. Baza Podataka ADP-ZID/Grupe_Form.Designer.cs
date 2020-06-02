namespace _08.Baza_Podataka_ADP_ZID
{
    partial class Grupe_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grupe_Form));
            this.data = new System.Windows.Forms.DataGridView();
            this.ikone = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.brojGrupa = new System.Windows.Forms.ToolStripStatusLabel();
            this.pretraga = new System.Windows.Forms.TextBox();
            this.btn_pretrazi = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_novaGrupa = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_izbrisiGrupu = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_osvjezi = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(222)))));
            this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data.Location = new System.Drawing.Point(11, 55);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.data.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.data.RowTemplate.Height = 50;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(741, 367);
            this.data.TabIndex = 0;
            this.data.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_CellMouseDoubleClick);
            // 
            // ikone
            // 
            this.ikone.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ikone.ImageStream")));
            this.ikone.TransparentColor = System.Drawing.Color.Transparent;
            this.ikone.Images.SetKeyName(0, "grupe_add.png");
            this.ikone.Images.SetKeyName(1, "grupe_dell.png");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brojGrupa});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(759, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // brojGrupa
            // 
            this.brojGrupa.BackColor = System.Drawing.Color.Transparent;
            this.brojGrupa.Name = "brojGrupa";
            this.brojGrupa.Size = new System.Drawing.Size(80, 17);
            this.brojGrupa.Text = "Broj grupa: 15";
            // 
            // pretraga
            // 
            this.pretraga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pretraga.Font = new System.Drawing.Font("Calibri", 8F);
            this.pretraga.Location = new System.Drawing.Point(11, 29);
            this.pretraga.Name = "pretraga";
            this.pretraga.Size = new System.Drawing.Size(657, 21);
            this.pretraga.TabIndex = 5;
            this.pretraga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pretraga_KeyDown);
            // 
            // btn_pretrazi
            // 
            this.btn_pretrazi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.btn_pretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pretrazi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pretrazi.ImageKey = "(none)";
            this.btn_pretrazi.ImageList = this.ikone;
            this.btn_pretrazi.Location = new System.Drawing.Point(672, 29);
            this.btn_pretrazi.Name = "btn_pretrazi";
            this.btn_pretrazi.Size = new System.Drawing.Size(73, 21);
            this.btn_pretrazi.TabIndex = 6;
            this.btn_pretrazi.Text = "Pretraži";
            this.btn_pretrazi.UseVisualStyleBackColor = false;
            this.btn_pretrazi.Click += new System.EventHandler(this.btn_pretrazi_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_novaGrupa,
            this.btn_izbrisiGrupu,
            this.btn_osvjezi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_novaGrupa
            // 
            this.btn_novaGrupa.Name = "btn_novaGrupa";
            this.btn_novaGrupa.Size = new System.Drawing.Size(115, 20);
            this.btn_novaGrupa.Text = "Dodaj novu grupu";
            this.btn_novaGrupa.Click += new System.EventHandler(this.btn_novaGrupa_Click);
            // 
            // btn_izbrisiGrupu
            // 
            this.btn_izbrisiGrupu.Name = "btn_izbrisiGrupu";
            this.btn_izbrisiGrupu.Size = new System.Drawing.Size(150, 20);
            this.btn_izbrisiGrupu.Text = "Izbriši selektovanu grupu";
            this.btn_izbrisiGrupu.Click += new System.EventHandler(this.btn_izbrisiGrupu_Click);
            // 
            // btn_osvjezi
            // 
            this.btn_osvjezi.Name = "btn_osvjezi";
            this.btn_osvjezi.Size = new System.Drawing.Size(81, 20);
            this.btn_osvjezi.Text = "Osvježi listu";
            this.btn_osvjezi.Click += new System.EventHandler(this.btn_osvjezi_Click);
            // 
            // Grupe_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(759, 447);
            this.Controls.Add(this.btn_pretrazi);
            this.Controls.Add(this.pretraga);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Grupe_Form";
            this.Text = "Grupe";
            this.Load += new System.EventHandler(this.Grupe_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.ImageList ikone;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel brojGrupa;
        private System.Windows.Forms.TextBox pretraga;
        private System.Windows.Forms.Button btn_pretrazi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_novaGrupa;
        private System.Windows.Forms.ToolStripMenuItem btn_izbrisiGrupu;
        private System.Windows.Forms.ToolStripMenuItem btn_osvjezi;
    }
}