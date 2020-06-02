using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _08.Baza_Podataka_ADP_ZID
{
    public partial class Grupe_Form : Form
    {
        public Grupe_Form(string user)
        {
            InitializeComponent();
            userName = user;
        }

        BazaPodataka BazaPodataka;
        string userName = "";
        grupe_NovaGrupa novaGrupa;

        private void Grupe_Form_Load(object sender, EventArgs e)
        {
            BazaPodataka = new BazaPodataka();
            this.Show(); Application.DoEvents();
            loadTable();
        }

        public void loadTable(string pretraga = ""){
            DataTable dt = BazaPodataka.grupe_getAllGrupe(pretraga);
            if(dt!=null)data.DataSource = dt;
            brojGrupa.Text = "Ukupan broj grupa je "+data.Rows.Count.ToString();
            DataGridViewColumn kolona = data.Columns[0]; kolona.Width = 50;
            kolona = data.Columns[3]; kolona.Width = 80;
        }

        private void btn_novaGrupa_Click(object sender, EventArgs e)
        {
            if(Home_Form.userPRI!="da"){MessageBox.Show("Nemate privilegije!"); return; }
            novaGrupa = new grupe_NovaGrupa(this, userName); novaGrupa.Show();
        }

        private void btn_izbrisiGrupu_Click(object sender, EventArgs e)
        {
            if (data.Rows.Count == 0) return;
            if(Home_Form.userPRI!="da"){MessageBox.Show("Nemate privilegije!"); return; }
            if(MessageBox.Show("Da li ste sigurni da zelite da izbrisete sledecu grupu:\r\n\"" + data.SelectedRows[0].Cells[1].Value.ToString() + "\"", "Potvrda brisanja", MessageBoxButtons.OKCancel) == DialogResult.OK){
                BazaPodataka.grupe_izbrisiGrupu(data.SelectedRows[0].Cells[0].Value.ToString(), data.SelectedRows[0].Cells[1].Value.ToString(), userName);
                loadTable();
            }

        }
          
        private void data_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Grupa_Info GF = new Grupa_Info(data.SelectedRows[0].Cells[1].Value.ToString(), 
                                           data.SelectedRows[0].Cells[2].Value.ToString(),
                                           data.SelectedRows[0].Cells[3].Value.ToString());
            GF.Show();
        }

        private void btn_osvjezi_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        // PRETRAGA GRUPA
        private void btn_pretrazi_Click(object sender, EventArgs e) { loadTable(pretraga.Text); }
        private void pretraga_KeyDown(object sender, KeyEventArgs e) {if (e.KeyCode == Keys.Enter) loadTable(pretraga.Text); }

    }
}
