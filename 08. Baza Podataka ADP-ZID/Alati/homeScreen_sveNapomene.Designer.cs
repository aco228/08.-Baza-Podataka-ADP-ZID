namespace _08.Baza_Podataka_ADP_ZID
{
    partial class homeScreen_sveNapomene
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_izbrisiSve = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_izbrisiSelektovan = new System.Windows.Forms.ToolStripMenuItem();
            this.dataNapomene = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNapomene)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_izbrisiSve,
            this.btn_izbrisiSelektovan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_izbrisiSve
            // 
            this.btn_izbrisiSve.Name = "btn_izbrisiSve";
            this.btn_izbrisiSve.Size = new System.Drawing.Size(129, 20);
            this.btn_izbrisiSve.Text = "Izbrisi sve napomene";
            this.btn_izbrisiSve.Click += new System.EventHandler(this.btn_izbrisiSve_Click);
            // 
            // btn_izbrisiSelektovan
            // 
            this.btn_izbrisiSelektovan.Name = "btn_izbrisiSelektovan";
            this.btn_izbrisiSelektovan.Size = new System.Drawing.Size(176, 20);
            this.btn_izbrisiSelektovan.Text = "Izbrisi selektovanu napomenu";
            this.btn_izbrisiSelektovan.Click += new System.EventHandler(this.btn_izbrisiSelektovan_Click);
            // 
            // dataNapomene
            // 
            this.dataNapomene.AllowUserToAddRows = false;
            this.dataNapomene.AllowUserToDeleteRows = false;
            this.dataNapomene.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataNapomene.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNapomene.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataNapomene.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(222)))));
            this.dataNapomene.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataNapomene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNapomene.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataNapomene.Location = new System.Drawing.Point(3, 27);
            this.dataNapomene.MultiSelect = false;
            this.dataNapomene.Name = "dataNapomene";
            this.dataNapomene.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataNapomene.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.dataNapomene.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNapomene.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.dataNapomene.RowTemplate.Height = 50;
            this.dataNapomene.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataNapomene.Size = new System.Drawing.Size(741, 367);
            this.dataNapomene.TabIndex = 4;
            // 
            // homeScreen_sveNapomene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 397);
            this.Controls.Add(this.dataNapomene);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "homeScreen_sveNapomene";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Javne napomene";
            this.Load += new System.EventHandler(this.homeScreen_sveNapomene_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNapomene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_izbrisiSve;
        private System.Windows.Forms.ToolStripMenuItem btn_izbrisiSelektovan;
        private System.Windows.Forms.DataGridView dataNapomene;
    }
}