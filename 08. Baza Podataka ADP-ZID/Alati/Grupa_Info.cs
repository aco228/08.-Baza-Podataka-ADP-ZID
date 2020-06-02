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
    public partial class Grupa_Info : Form
    {
        public Grupa_Info(string naslov, string opis, string br_sati)
        {
            InitializeComponent();
            ime_grupe = naslov; opis_grupe = opis; broj_sati = br_sati;
        }

        string ime_grupe;
        string opis_grupe;
        string broj_sati;
        BazaPodataka BazaPodataka;

        private void Grupa_Info_Load(object sender, EventArgs e)
        {
            this.Text = "Informacije o grupi: " + ime_grupe;
            info_naslov.Text = ime_grupe; info_opis.Text = opis_grupe; info_sati.Text = broj_sati;
            BazaPodataka = new BazaPodataka();
            loadTable();
        }
        private void loadTable(){
            DataTable dt = BazaPodataka.grupe_preuzmiClanoveGrupe(ime_grupe);
            if (dt != null) data.DataSource = dt;
            DataGridViewColumn kolona = data.Columns[7]; kolona.Visible = false;
                               kolona = data.Columns[5]; kolona.Visible = false;
                               kolona = data.Columns[1]; kolona.Visible = false;
            status_brVolontera.Text = "Broj volontera u grupi je " + data.Rows.Count.ToString();
        }
        
        // Izmjeni podatke o grupi
        private void btn_izmjeni_Click(object sender, EventArgs e)
        {
            grupe_NovaGrupa GP = new grupe_NovaGrupa(this, ime_grupe, opis_grupe, Convert.ToInt32(broj_sati)); GP.Show();
            this.Dispose();
        }
        public void promjeniOpis(string opis){info_opis.Text = opis; }

        // Izbrisi grupu
        private void btn_izbrisiGrupu_Click(object sender, EventArgs e)
        {
            if(Home_Form.userPRI!="da"){MessageBox.Show("Nemate privilegije!"); return; }
            if(MessageBox.Show("Da li ste sigurni da zelite da izbrisete ovu grupu ('"+ime_grupe+"')?", "Potvrda brisanja", MessageBoxButtons.OKCancel) == DialogResult.OK){
                BazaPodataka.grupe_izbrisiGrupu("0", ime_grupe, Home_Form.userName);
                this.Dispose();
            }
        }

        // Izbrisi volontera iz grupe
        private void btn_izbrisiClana_Click(object sender, EventArgs e)
        {
            if (data.Rows.Count == 0) return;
            string ime = data.SelectedRows[0].Cells[1].Value.ToString();
            string id = data.SelectedRows[0].Cells[0].Value.ToString();
            if(MessageBox.Show("Da li ste sigurni da izbacite volontera "+ime+"?", "Potvrda brisanja", MessageBoxButtons.OKCancel) == DialogResult.OK){
                BazaPodataka.grupe_brisanjeClanaIzGrupe(ime_grupe, id);
                loadTable();
            }
        }
        
        private void data_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Volonter_Dosije VD = new Volonter_Dosije(data.SelectedRows[0].Cells[0].Value.ToString());
            VD.Show();
        }
    }
}
