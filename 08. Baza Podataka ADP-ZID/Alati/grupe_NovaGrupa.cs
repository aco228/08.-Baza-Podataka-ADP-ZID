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
    public partial class grupe_NovaGrupa : Form
    {
        public grupe_NovaGrupa(string user)
        {
            InitializeComponent();
            userName = user;
        }
        public grupe_NovaGrupa(Grupe_Form GF, string user)
        {
            InitializeComponent();
            Grupe_Form = GF;
            userName = user;
        }
        public grupe_NovaGrupa(Grupa_Info GI, string imegrupe, string opisgrupe, int br_sati)
        {
            InitializeComponent();
            Grupa_Info = GI;
            userName = Home_Form.userName;
            ime_grupe = imegrupe; opis_grupe = opisgrupe;
            novaGrupa = false;
            broj_sati = br_sati;
        }

        bool novaGrupa = true; string ime_grupe = "", opis_grupe = ""; int broj_sati;
        Grupa_Info Grupa_Info;
        BazaPodataka BazaPodataka;
        Grupe_Form Grupe_Form= null;
        string userName = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            BazaPodataka = new BazaPodataka();
            if(!novaGrupa) {
                // Ako se modifikuje postojeca grupe
                imeGrupe.Text = ime_grupe; opisGrupe.Text = opis_grupe; br_sati.Value = broj_sati;
                imeGrupe.Enabled = false;
            }
            greska.Text = "";
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if(novaGrupa)
            {
                // DODAVANJE NOVE GRUPE
                if (imeGrupe.Text == "") greska.Text = "Niste unijeli ime grupe!";
                else {
                    if (BazaPodataka.grupe_dodajNovuGrupu(imeGrupe.Text, opisGrupe.Text, br_sati.Value.ToString(), userName)) { 
                        if(Grupe_Form != null) Grupe_Form.loadTable(); 
                        this.Dispose(); 
                    } else greska.Text = "Postoji grupa sa ovim imenom!";
                }
            } 
            else 
            {
                // MODIFIKOVANJE POSTOJECE GRUPE
                if(BazaPodataka.grupe_modifikacijeGrupe(ime_grupe, opisGrupe.Text, userName, br_sati.Value.ToString())){
                    Grupa_Info GI = new Grupa_Info(ime_grupe, opisGrupe.Text, br_sati.Value.ToString()); GI.Show(); this.Dispose();
                } else MessageBox.Show("Greska sa bazom. Pokusajte kasnije");
            }
        }
    }
}
