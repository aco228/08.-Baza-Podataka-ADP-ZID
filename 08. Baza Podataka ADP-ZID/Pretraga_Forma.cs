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
    public partial class Pretraga_Forma : Form
    {
        public Pretraga_Forma(string user)
        {
            InitializeComponent();
            userName = user;
        }

        BazaPodataka BazaPodataka;
        string userName = "";
        string naslov_forme = "Pretraga volontera";

        private void Pretraga_Forma_Load(object sender, EventArgs e)
        {
            BazaPodataka = new BazaPodataka();
            combo_aktivnost.SelectedIndex = 0;
            populateComboGrupa();
            this.Text = naslov_forme;
            this.Show(); Application.DoEvents();
            loadTable("");
        }
        DataTable combo_grupe_table = null;
        private void populateComboGrupa(){
            combo_grupe_table = BazaPodataka.pretraga_getAllGrupe();
            if (combo_grupe_table != null) {
                combo_grupe.Items.Insert(0, "Sve grupe");
                for(int i = 1; i <= combo_grupe_table.Rows.Count; i++){
                    combo_grupe.Items.Insert(i, combo_grupe_table.Rows[i-1]["ime_grupe"].ToString());
                }
                combo_grupe.SelectedIndex = 0;
           }
        }
        private void worker_preuzimanjePodataka_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void loadTable(string unos, bool grupa = false, char aktivnost = 's'){
            loading_panel.Visible = true; 
            DataTable dt = BazaPodataka.pretraga_unos(unos, grupa, aktivnost);
            if (dt == null) { MessageBox.Show("Greška sa preuzimanjem podataka. \r\nMožda je baza preopterećena. \r\nPokušajte kasnije!"); this.Dispose();  return; }
            data.DataSource = dt;
            DataGridViewColumn kolona = data.Columns[0]; kolona.Width = 35; // indeks
                               kolona = data.Columns[1]; kolona.Width = 30; // godine
                               kolona = data.Columns[3]; kolona.Width = 85; // telefon
                               kolona = data.Columns[6]; kolona.Width = 30; // sati
                               kolona = data.Columns[7]; kolona.Visible = false; // aktivnost

            status_brojRezultata.Text = "Broj prikazanih volontera je " + data.Rows.Count.ToString();
            data_bojanjeTable();
            loading_panel.Visible = false;
        }
        private void loadGrupaTable(){
            loading_panel.Visible = true; 
            DataTable dt = BazaPodataka.grupe_preuzmiClanoveGrupe(combo_grupe.Text);
            if (dt == null) { MessageBox.Show("Greška sa preuzimanjem podataka. \r\nMožda je baza preopterećena. \r\nPokušajte kasnije!"); this.Dispose();  return; }
            data.DataSource = dt;
            DataGridViewColumn kolona = data.Columns[0]; kolona.Width = 35; // indeks
                               kolona = data.Columns[1]; kolona.Width = 30; // godine
                               kolona = data.Columns[3]; kolona.Width = 85; // telefon
                               kolona = data.Columns[6]; kolona.Width = 30; // sati
                               kolona = data.Columns[7]; kolona.Visible = false; // aktivnost

            status_brojRezultata.Text = "Broj prikazanih volontera je " + data.Rows.Count.ToString();
            data_bojanjeTable();
            loading_panel.Visible = false;
        }
        private void data_Sorted(object sender, EventArgs e) { data_bojanjeTable(); }
        private void data_bojanjeTable(){
            foreach (DataGridViewRow row in data.Rows)
            { 
                switch(row.Cells[7].Value.ToString()){
                    case "Aktivan": row.DefaultCellStyle.BackColor = Color.FromArgb(214, 255, 226); break;
                    case "Neaktivan": row.DefaultCellStyle.BackColor = Color.FromArgb(255, 225, 225); break;
                    case "Tu i tamo": row.DefaultCellStyle.BackColor = Color.FromArgb(249, 255, 206); break;
                }
            }
        }

        //
        //  BTN_PRETRAGA
        //
        private void btn_pretraga_Click(object sender, EventArgs e) { pretraga(); }
        private void pretraga_unos_KeyDown(object sender, KeyEventArgs e) { if(e.KeyCode == Keys.Enter) pretraga(); }
        private void pretraga()
        {
            if(GRUPA_SELEKTOVANA){
                this.Text = naslov_forme + " - Sortiranje grupa";
                loadGrupaTable();
            } else {
                this.Text = naslov_forme + " - Rezultati za unos '" + pretraga_unos.Text + "'";
                loadTable(pretraga_unos.Text, false, getAktivnost());
            }
        }
        private char getAktivnost(){
            if (combo_aktivnost.Text == "Aktivan") return 'a';
            else if(combo_aktivnost.Text == "Neaktivan") return 'n';
            else if(combo_aktivnost.Text == "Tu i tamo") return 't';
            else return 's';
        }

        // Mehanizam za grupu. Ako se selektuje grupa onda se vrsi sortiranje jedino na osnovu grupe!
        bool GRUPA_SELEKTOVANA = false;
        private void combo_grupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_grupe.Text == "Sve grupe"){
                GRUPA_SELEKTOVANA = false;
                combo_aktivnost.Enabled = true;
                pretraga_unos.Enabled = true;
            } else {
                GRUPA_SELEKTOVANA = true;
                combo_aktivnost.Enabled = false;
                pretraga_unos.Enabled = false;
            }
        }

        private void btn_noviClan_Click(object sender, EventArgs e)
        {
            Novi_Clan NC = new Novi_Clan(Home_Form.userName);
            NC.Show();
        }
        private void btn_novaGrupa_Click(object sender, EventArgs e)
        {
            grupe_NovaGrupa GN = new grupe_NovaGrupa(Home_Form.userName);
            GN.Show();
        }

        private void btn_grupe_Click(object sender, EventArgs e)
        {
            Grupe_Form GF = new Grupe_Form(Home_Form.userName);
            GF.Show();
        }
        private void btn_dodajVolontera_Click(object sender, EventArgs e)
        {
            if (data.Rows.Count == 0) return;
            string imeClana = data.SelectedRows[0].Cells[2].Value.ToString();
            string idClana = data.SelectedRows[0].Cells[0].Value.ToString();
            pretraga_DodajVolonteraUGrupu dodaj = new pretraga_DodajVolonteraUGrupu(combo_grupe_table, imeClana, idClana);
            dodaj.Show();
        }
        private void btn_vazneInformacije_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kriterijumi za pretragu su:\r\n\r\n"+
                            "Ime i prezime,\r\n"+
                            "Email adresa,\r\n"+
                            "Adresa stanovanja,\r\n"+
                            "Profesija,\r\n"+
                            "Trenutni status,\r\n"+
                            "Trenutno pohađam,\r\n"+
                            "Interesovanje 1,\r\n"+
                            "Interesovanje 2,\r\n"+
                            "Interesovanje 3");
        }
        //
        //  OTVARANJE DOSIJEA ZA VOLONTERA
        //
        private void data_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Volonter_Dosije VD = new Volonter_Dosije(data.SelectedRows[0].Cells[0].Value.ToString());
            VD.Show();
        }
        private void data_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter){
                Volonter_Dosije VD = new Volonter_Dosije(data.SelectedRows[0].Cells[0].Value.ToString());
                VD.Show();
            }
        }
                
    }
}
