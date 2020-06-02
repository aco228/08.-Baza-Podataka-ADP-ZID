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
    public partial class Volonter_Dosije : Form
    {
        public Volonter_Dosije(string idClana)
        {
            InitializeComponent();
            id_clana = idClana;
        }

        string id_clana = "";
        BazaPodataka BazaPodataka;
        PodaciZa_NovogClana podaci;

        private void Volonter_Dosije_Load(object sender, EventArgs e)
        {
            BazaPodataka = new BazaPodataka();
            // PREUZIMANJE PODATAKA iZ BAZE
            this.Show(); Application.DoEvents();
            podaci = BazaPodataka.dosije_preuzmiPodatke(id_clana);
            if (podaci == null)
            {
                // GRESKA SA PREUZIMANJEM PODATAKA
                loading_greska.Visible = true;
                return;
            }

            // Postavljanje boje statusa u zavisnosti od aktivnosti
            loading_panel.Visible = false; loading_panel.Dispose();
            raspakivanjePodataka();
            updateStatus();
            updateKomentari();
            updateGrupe();
            this.Text = "Dosije volontera - " + podaci.jasam_imePrezime;
        }

        private void raspakivanjePodataka(){
            // JA SAM...
            jasam_imePrezime.Text = podaci.jasam_imePrezime;
            jasam_pol.Text = podaci.jasam_pol;
            jasam_rodjenje.Text = podaci.jasam_rodjenje + " (" + podaci.jasam_brojGodina + " godina)";
            jasam_rodjenjeMjesto.Text = podaci.jasam_mjestoRodjenja;
            jasam_telefon.Text = podaci.jasam_telefon;
            jasam_email.Text = podaci.jasam_email;
            jasam_skype.Text = podaci.jasam_skype;
            jasam_facebook.Text = podaci.jasam_facebook;
            jasam_volonterskiSati.Text = podaci.jesam_volonterskiSati.ToString();
            jasam_vrijemeVolontiranja.Text = podaci.jasam_vrijemeVolontiranja;
            jasam_adresa.Text = podaci.jasam_adresa;
            jasam_datumPostavljanjaUBazu.Text = "Upitnik postavljen u bazu " + podaci.jasam_vrijemeUnosaUBazu;
            jasam_datumPopunjavanjaUpitnika.Text = "Upitnik popunjen " + podaci.jasam_datumPopunjavanjaUpitnika;
            jasam_aktivan.Text = podaci.jasam_aktivan;

            //STATUS...
            status_profesija.Text = podaci.status_profesija;
            status_trenutniStatus.Text = podaci.status_trenutniStatus;
            status_radnoIskustvo.Text = podaci.status_radnoIskustvo;
            status_pojasnjenjeStatusa.Text = podaci.status_pojasnjenjeStatusa;

            //A SADA...
            asada_hobi.Text = podaci.asada_hobi;
            asada_honorarniAngazman.Text = podaci.asada_honorarniAngazman;
            asada_omiljeneStvari.Text = podaci.asada_omiljenjeStvari;
            asada_omiljeniGradovi.Text = podaci.asada_omiljeniGradovi;
            asada_trenutnoPohadjam.Text = podaci.asada_trenutnoPohadjam;

            // VOLONTERSKO ISKUSTVO
            viskustvo_kojaOrganizacija.Text = podaci.viskustvo_kojaOrganizacija;
            viskustvo_kojePrilike.Text = podaci.viskustvo_kojePrilike;
            viskustvo_opisNeVolonterskihAktivnosti.Text = podaci.viskustvo_opisNeVolonterskihAktivnosti;
            viskustvo_opisVolonterskihAktivnosti.Text = podaci.viskustvo_opisVolonterskihAktivnosti;
            viskustvo_trajanjeAngazmana.Text = podaci.viskustvo_trajanjeAngazmana;

            //POZNAVANJE JEZIKA
            jezik_drugi_ime.Text = podaci.jezik_drugi_ime;
            jezik_razumijem_eng.Text = podaci.jezik_razumijem_eng.ToString();
            jezik_razumijem_fra.Text = podaci.jezik_razumijem_fra.ToString();
            jezik_razumijem_rus.Text = podaci.jezik_razumijem_rus.ToString();
            jezik_razumijem_ita.Text = podaci.jezik_razumijem_ita.ToString();
            jezik_razumijem_spa.Text = podaci.jezik_razumijem_spa.ToString();
            jezik_razumijem_ger.Text = podaci.jezik_razumijem_ger.ToString();
            jezik_razumijem_drugi.Text = podaci.jezik_razumijem_drugi.ToString();
            
            jezik_pricam_eng.Text = podaci.jezik_pricam_eng.ToString();
            jezik_pricam_fra.Text = podaci.jezik_pricam_fra.ToString();
            jezik_pricam_rus.Text = podaci.jezik_pricam_rus.ToString();
            jezik_pricam_ita.Text = podaci.jezik_pricam_ita.ToString();
            jezik_pricam_spa.Text = podaci.jezik_pricam_spa.ToString();
            jezik_pricam_ger.Text = podaci.jezik_pricam_ger.ToString();
            jezik_pricam_drugi.Text = podaci.jezik_pricam_drugi.ToString();
            
            jezik_pisem_eng.Text = podaci.jezik_pisem_eng.ToString();
            jezik_pisem_fra.Text = podaci.jezik_pisem_fra.ToString();
            jezik_pisem_rus.Text = podaci.jezik_pisem_rus.ToString();
            jezik_pisem_ita.Text = podaci.jezik_pisem_ita.ToString();
            jezik_pisem_spa.Text = podaci.jezik_pisem_spa.ToString();
            jezik_pisem_ger.Text = podaci.jezik_pisem_ger.ToString();
            jezik_pisem_drugi.Text = podaci.jezik_pisem_drugi.ToString();

            //PODRUCJE INTERESOVANJA
            podrucjeInteresovanja_jedan.Text = podaci.podrucjeInteresovanja_jedan;
            podrucjeInteresovanja_dva.Text = podaci.podrucjeInteresovanja_dva;
            podrucjeInteresovanja_tri.Text = podaci.podrucjeInteresovanja_tri;

            // DODATNE INFORMACIJE
            dodatneInfo_angazman.Text = podaci.dodatneInformacije_angazman;
            dodatneInfo_dodatneInformacije.Text = podaci.dodatneInfo_dodatneInformacije;
            dodatneInfo_dostupnost.Text = podaci.dodatneInformacije_dostupnost;
            dodatneInfo_motivacijaVolontera.Text = podaci.dodatneInfo_motivacijaVolontera;
            dodatneInfo_obukaVolontera.Text = podaci.dodatneInformacije_obukaVolontera;

            //OBLASTI                
            oblasti_zastitaZdravlja.Text = podaci.oblasti_zastitaZdravlja.ToString();
            oblasti_akcijeNaZastitiZivotneSredine.Text = podaci.oblasti_akcijeNaZastitiZivotneSredine.ToString();
            oblasti_zastitaBiljakaZivotinja.Text = podaci.oblasti_zastitaBiljakaZivotinja.ToString();
            oblasti_humanitarniProgrami.Text = podaci.oblasti_humanitarniProgrami.ToString();
            oblasti_razvojDemokratije.Text = podaci.oblasti_razvojDemokratije.ToString();
            oblasti_ravnopravnostPolova.Text = podaci.oblasti_ravnopravnostPolova.ToString();
            oblasti_promocijaMira.Text = podaci.oblasti_promocijaMira.ToString();
            oblasti_internacionalniKampovi.Text = podaci.oblasti_internacionalniKampovi.ToString();
            oblasti_onlineVolontiranje.Text = podaci.oblasti_onlineVolontiranje.ToString();
            oblasti_promocijaKultureZivljenja.Text = podaci.oblasti_promocijaKultureZivljenja.ToString();
            oblasti_promocijaPravaManjina.Text = podaci.oblasti_promocijaPravaManjina.ToString();
            oblasti_pomocUcenju.Text = podaci.oblasti_pomocUcenju.ToString();
            oblasti_sportskeManifestacije.Text = podaci.oblasti_sportskeManifestacije.ToString();
            oblasti_pruzanjePomociInvalidima.Text = podaci.oblasti_pruzanjePomociInvalidima.ToString();
            oblasti_pruzanjePomociMentalnim.Text = podaci.oblasti_pruzanjePomociMentalnim.ToString();
            oblasti_pruzanjePomociStarima.Text = podaci.oblasti_pruzanjePomociStarima.ToString();
            oblasti_pruzanjePomociDrogasima.Text = podaci.oblasti_pruzanjePomociDrogasima.ToString();
            oblasti_pruzanjePomociKockarima.Text = podaci.oblasti_pruzanjePomociKockarima.ToString();
            oblasti_istrazivackiProjekti.Text = podaci.oblasti_istrazivackiProjekti.ToString();
            oblasti_kancelarijskiPoslovi.Text = podaci.oblasti_kancelarijskiPoslovi.ToString();
            oblasti_organizacioniPoslovi.Text = podaci.oblasti_organizacioniPoslovi.ToString();
            oblasti_prevodjenje.Text = podaci.oblasti_prevodjenje.ToString();
            oblasti_kulturaUmjetnost.Text = podaci.oblasti_kulturaUmjetnost.ToString();
            oblasti_arheologija.Text = podaci.oblasti_arheologija.ToString();
            oblasti_obnovaRekonstrukcija.Text = podaci.oblasti_obnovaRekonstrukcija.ToString();
            oblasti_informacioneTehnologije.Text = podaci.oblasti_informacioneTehnologije.ToString();
            oblasti_muzickeManifestacije.Text = podaci.oblasti_muzickeManifestacije.ToString();
            oblasti_interkulturalnoUcenje.Text = podaci.oblasti_interkulturalnoUcenje.ToString();
        }

        private void updateStatus(){
            if(jasam_aktivan.Text=="Aktivan"){
                this.jasam_aktivan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            } else if(jasam_aktivan.Text=="Neaktivan"){
                this.jasam_aktivan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            } else if(jasam_aktivan.Text=="Tu i tamo"){
                this.jasam_aktivan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(255)))), ((int)(((byte)(206)))));
            }
        }

        //
        // KOMENTARI O VOLONTERU
        //
        private void updateKomentari()
        {
            DataTable dt = BazaPodataka.dosije_komentariGet(id_clana);
            if (dt == null) return;
            koment_data.DataSource = dt;
            DataGridViewColumn kolona = koment_data.Columns[0]; kolona.Width = 30;
                               kolona = koment_data.Columns[1]; kolona.Width = 50;
                               kolona = koment_data.Columns[3]; kolona.Width = 90;
        }
        private void koment_btnPosalji_Click(object sender, EventArgs e)
        {
            if (koment_unos.Text == "") return;
            BazaPodataka.dosije_dodajKomentar(Home_Form.userName, id_clana, koment_unos.Text);
            koment_unos.Text="";
            updateKomentari();
        }
        private void koment_btnOsvjezi_Click(object sender, EventArgs e)
        {
            updateKomentari();
        }
        private void koment_btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (koment_data.Rows.Count == 0) return;
            if(MessageBox.Show("Da li ste sigurni da zelite da selektovanu napomenu", "Potvrda brisanja", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                BazaPodataka.dosije_izbrisiKomentar(koment_data.SelectedRows[0].Cells[0].Value.ToString());
                updateKomentari();
            }
        }

        //
        //  Grupe
        //
        private void updateGrupe()
        {
            if (podaci == null) return;
            grupe_komentar.Text = "Grupe u kojima se nalazi " + podaci.jasam_imePrezime;
            DataTable dt = BazaPodataka.dosije_grupeVolontera(id_clana);
            if (dt == null) return;
            grupe_data.DataSource = dt;
        }

        //
        //  FUNKCIONALNOST
        //
        private void btn_edit_Click(object sender, EventArgs e)
        {
            Novi_Clan NC = new Novi_Clan(podaci);
            NC.Show(); this.Dispose();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(Home_Form.userPRI!="da"){MessageBox.Show("Nemate privilegije!"); return; }
            if(MessageBox.Show("Da li ste sigurni da zelite da izbrisete volontera ('"+podaci.jasam_imePrezime+"')?", "Potvrda brisanja", MessageBoxButtons.OKCancel) == DialogResult.OK){
                BazaPodataka.dosije_izbrisiVolontera(id_clana, podaci.jasam_imePrezime, Home_Form.userName);
                this.Dispose();
            }
        }
        private void btn_dodajUGrupu_Click(object sender, EventArgs e)
        {
            pretraga_DodajVolonteraUGrupu pr = new pretraga_DodajVolonteraUGrupu(podaci.jasam_imePrezime, id_clana);
            pr.Show();
        }

    }
}
