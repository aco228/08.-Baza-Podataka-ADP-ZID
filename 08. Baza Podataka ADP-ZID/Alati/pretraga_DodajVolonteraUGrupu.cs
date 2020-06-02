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
    public partial class pretraga_DodajVolonteraUGrupu : Form
    {
        public pretraga_DodajVolonteraUGrupu(DataTable grupe, string ime_clana, string id_clana)
        {
            InitializeComponent();
            data = grupe;
            imeClana = ime_clana;
            idClana = id_clana;
        }
        public pretraga_DodajVolonteraUGrupu(string ime_clana, string id_clana)
        {
            InitializeComponent();
            imeClana = ime_clana;
            idClana = id_clana;
        }

        DataTable data;
        BazaPodataka BazaPodataka;
        string imeClana = "", idClana = "";

        private void pretraga_DodajVolonteraUGrupu_Load(object sender, EventArgs e)
        {
            BazaPodataka = new BazaPodataka();
            if (data == null) data = BazaPodataka.pretraga_getAllGrupe();
            opis.Text = "Dodaj volontera '"+imeClana+"' u grupu:";
            this.Text = "Dodavanje '"+imeClana+"' u grupu!";
            combo_grupe.DataSource = data;
            combo_grupe.DisplayMember = "ime_grupe";
        }

        private void btn_potvrdi_Click(object sender, EventArgs e)
        {
            string back = BazaPodataka.pretraga_dodajVolonteraUGrupu(combo_grupe.Text, idClana);
            if (back == "")
            {
                btn_potvrdi.Enabled = false;
                combo_grupe.Enabled = false;
                poruka.Text = "Volonter '" + imeClana + "' je ubacen u grupu '" + combo_grupe.Text + "'!";
            }
            else MessageBox.Show(back);
        }
    }
}
