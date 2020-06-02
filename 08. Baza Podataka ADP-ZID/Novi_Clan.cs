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
    public partial class Novi_Clan : Form
    {
        public Novi_Clan(string user)
        {
            InitializeComponent();
            userName = user;
        }
        public Novi_Clan(PodaciZa_NovogClana podacii)
        {
            InitializeComponent();
            podaci = podacii;
        }

        string userName = "";
        BazaPodataka BazaPodataka;

        // Varijable za modifikaciju volontera
        PodaciZa_NovogClana podaci = null;

        private void Novi_Clan_Load(object sender, EventArgs e)
        {
            BazaPodataka = new BazaPodataka();
            predefinisaneVrijednosti();
            if (podaci != null) raspakivanjePodataka();
        }
        private void predefinisaneVrijednosti(){
            noviClan_greska.Text = "";
            jasam_aktivan.SelectedIndex = 1;

            /* Jezici */
            jezik_razumijem_eng.SelectedIndex = 0;
            jezik_razumijem_fra.SelectedIndex = 0;
            jezik_razumijem_rus.SelectedIndex = 0;
            jezik_razumijem_ita.SelectedIndex = 0;
            jezik_razumijem_spa.SelectedIndex = 0;
            jezik_razumijem_ger.SelectedIndex = 0;
            jezik_razumijem_drugi.SelectedIndex = 0;
            
            jezik_pricam_eng.SelectedIndex = 0;
            jezik_pricam_fra.SelectedIndex = 0;
            jezik_pricam_rus.SelectedIndex = 0;
            jezik_pricam_ita.SelectedIndex = 0;
            jezik_pricam_spa.SelectedIndex = 0;
            jezik_pricam_ger.SelectedIndex = 0;
            jezik_pricam_drugi.SelectedIndex = 0;
            
            jezik_pisem_eng.SelectedIndex = 0;
            jezik_pisem_fra.SelectedIndex = 0;
            jezik_pisem_rus.SelectedIndex = 0;
            jezik_pisem_ita.SelectedIndex = 0;
            jezik_pisem_spa.SelectedIndex = 0;
            jezik_pisem_ger.SelectedIndex = 0;
            jezik_pisem_drugi.SelectedIndex = 0;

            /* Volontiranje u oblastima */
            oblasti_zastitaZdravlja.SelectedIndex = 0;
            oblasti_akcijeNaZastitiZivotneSredine.SelectedIndex = 0;
            oblasti_zastitaBiljakaZivotinja.SelectedIndex = 0;
            oblasti_humanitarniProgrami.SelectedIndex = 0;
            oblasti_razvojDemokratije.SelectedIndex = 0;
            oblasti_ravnopravnostPolova.SelectedIndex = 0;
            oblasti_promocijaMira.SelectedIndex = 0;
            oblasti_internacionalniKampovi.SelectedIndex = 0;
            oblasti_onlineVolontiranje.SelectedIndex = 0;
            oblasti_promocijaKultureZivljenja.SelectedIndex = 0;
            oblasti_promocijaPravaManjina.SelectedIndex = 0;
            oblasti_pomocUcenju.SelectedIndex = 0;
            oblasti_sportskeManifestacije.SelectedIndex = 0;
            oblasti_pruzanjePomociInvalidima.SelectedIndex = 0;
            oblasti_pruzanjePomociMentalnim.SelectedIndex = 0;
            oblasti_pruzanjePomociStarima.SelectedIndex = 0;
            oblasti_pruzanjePomociDrogasima.SelectedIndex = 0;
            oblasti_pruzanjePomociKockarima.SelectedIndex = 0;
            oblasti_istrazivackiProjekti.SelectedIndex = 0;
            oblasti_kancelarijskiPoslovi.SelectedIndex = 0;
            oblasti_organizacioniPoslovi.SelectedIndex = 0;
            oblasti_prevodjenje.SelectedIndex = 0;
            oblasti_kulturaUmjetnost.SelectedIndex = 0;
            oblasti_arheologija.SelectedIndex = 0;
            oblasti_obnovaRekonstrukcija.SelectedIndex = 0;
            oblasti_informacioneTehnologije.SelectedIndex = 0;
            oblasti_muzickeManifestacije.SelectedIndex = 0;
            oblasti_interkulturalnoUcenje.SelectedIndex = 0;

        }
        private void raspakivanjePodataka(){
            // JA SAM...
            jasam_imePrezime.Text = podaci.jasam_imePrezime;
            jasam_pol.Text = podaci.jasam_pol;
            jasam_rodjenje.Text = podaci.jasam_rodjenje;
            jasam_rodjenjeMjesto.Text = podaci.jasam_mjestoRodjenja;
            jasam_telefon.Text = podaci.jasam_telefon;
            jasam_email.Text = podaci.jasam_email;
            jasam_skype.Text = podaci.jasam_skype;
            jasam_facebook.Text = podaci.jasam_facebook;
            jasam_volonterskiSati.Text = podaci.jesam_volonterskiSati.ToString();
            jasam_vrijemeVolontiranja.Text = podaci.jasam_vrijemeVolontiranja;
            jasam_adresa.Text = podaci.jasam_adresa;
            //jasam_datumPostavljanjaUBazu.Text = "Upitnik postavljen u bazu " + podaci.jasam_vrijemeUnosaUBazu;
            jasam_datumPopunjavanjaUpitnika.Text = podaci.jasam_datumPopunjavanjaUpitnika;
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

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        //
        //// POTVRDA SLANJA PODATKA
        //
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            btnPotvrdi.Enabled = false;
            if(!provjeraVaznihInformacija()){
                PodaciZa_NovogClana slanje = pakovanje();
                if(podaci==null)
                {
                    // NOVI CLAN
                    string rezultat = BazaPodataka.noviClan_dodajNovogClana(slanje, userName);
                    if (rezultat == "") { MessageBox.Show("Volonter '" + jasam_imePrezime.Text + "' je dodat u bazu!"); this.Dispose(); }
                    else noviClan_greska.Text = rezultat;
                }
                else
                {
                    // MODIFIKACIJA POSTOJECEG CLANA
                    Volonter_Dosije VD;
                    string rezultat = BazaPodataka.noviClan_modifikacijaClana(slanje, Home_Form.userName);
                    if (rezultat == "")
                    {
                        VD = new Volonter_Dosije(podaci.jasam_idc);
                        VD.Show();
                        this.Dispose();
                    }
                    else noviClan_greska.Text = rezultat;
                }
            }
            btnPotvrdi.Enabled = true;
        }
        private bool provjeraVaznihInformacija(){
            int s;
            if (jasam_imePrezime.Text == "") { noviClan_greska.Text = "Niste upisali ime novog clana!"; return true; }
            else if (jasam_email.Text == "") { noviClan_greska.Text = "Niste upisali email adresu novog clana!"; return true; }
            else if (jasam_telefon.Text == "") { noviClan_greska.Text = "Niste upisali kontakt telefon novog clana!"; return true; }
            else if(!int.TryParse(jasam_volonterskiSati.Text, out s)){ noviClan_greska.Text = "Volonterski sati moraju biti broj!"; return true; }
            else if (jasam_adresa.Text == "") { noviClan_greska.Text = "Niste upisali adresu novog clana!"; return true; }
            return false;
        }

        //
        //  PAKOVANJE KLASE ZA SLANJE
        //
        private PodaciZa_NovogClana pakovanje()
        {
            PodaciZa_NovogClana back = new PodaciZa_NovogClana();
            if (podaci != null) back.jasam_idc = podaci.jasam_idc;

            /* JA SAM... */
                back.jasam_imePrezime = jasam_imePrezime.Text;
                back.jasam_pol = jasam_pol.Text;
                back.jasam_rodjenje = jasam_rodjenje.Text;
                back.jasam_brojGodina = Home_Form.racunanjeBrojaGodina(jasam_rodjenje.Text);
                back.jasam_email = jasam_email.Text;
                back.jasam_mjestoRodjenja = jasam_rodjenjeMjesto.Text;
                back.jasam_telefon = jasam_telefon.Text;
                back.jasam_skype = jasam_skype.Text;
                back.jasam_facebook = jasam_facebook.Text;
                back.jasam_aktivan = jasam_aktivan.Text;
                back.jasam_vrijemeVolontiranja = jasam_vrijemeVolontiranja.Text;
                back.jesam_volonterskiSati = Convert.ToInt32(jasam_volonterskiSati.Text);
                back.jasam_datumPopunjavanjaUpitnika = jasam_datumPopunjavanjaUpitnika.Text;
                back.jasam_adresa = jasam_adresa.Text;
            
            /* STATUS */
                back.status_profesija = status_profesija.Text;
                back.status_trenutniStatus = status_trenutniStatus.Text;
                back.status_pojasnjenjeStatusa = status_pojasnjenjeStatusa.Text;
                back.status_radnoIskustvo = status_radnoIskustvo.Text;

            /* A SADA... */
                back.asada_trenutnoPohadjam = asada_trenutnoPohadjam.Text;
                back.asada_honorarniAngazman = asada_honorarniAngazman.Text;
                back.asada_hobi = asada_hobi.Text;
                back.asada_omiljenjeStvari = asada_omiljeneStvari.Text;
                back.asada_omiljeniGradovi = asada_omiljeniGradovi.Text;

            /* VOLONTERSKO ISKUSTVO */
                back.viskustvo_kojaOrganizacija = viskustvo_kojaOrganizacija.Text;
                back.viskustvo_kojePrilike = viskustvo_kojePrilike.Text;
                back.viskustvo_opisNeVolonterskihAktivnosti = viskustvo_opisNeVolonterskihAktivnosti.Text;
                back.viskustvo_opisVolonterskihAktivnosti = viskustvo_opisVolonterskihAktivnosti.Text;
                back.viskustvo_trajanjeAngazmana = viskustvo_trajanjeAngazmana.Text;

            /* JEZIK */
                back.jezik_razumijem_eng = Convert.ToInt32(jezik_razumijem_eng.Text);
                back.jezik_razumijem_fra = Convert.ToInt32(jezik_razumijem_fra.Text);
                back.jezik_razumijem_rus = Convert.ToInt32(jezik_razumijem_rus.Text);
                back.jezik_razumijem_ita = Convert.ToInt32(jezik_razumijem_ita.Text);
                back.jezik_razumijem_spa = Convert.ToInt32(jezik_razumijem_spa.Text);
                back.jezik_razumijem_ger = Convert.ToInt32(jezik_razumijem_ger.Text);
                back.jezik_razumijem_drugi = Convert.ToInt32(jezik_razumijem_drugi.Text);

                back.jezik_pisem_eng = Convert.ToInt32(jezik_pisem_eng.Text);
                back.jezik_pisem_fra = Convert.ToInt32(jezik_pisem_fra.Text);
                back.jezik_pisem_rus = Convert.ToInt32(jezik_pisem_rus.Text);
                back.jezik_pisem_ita = Convert.ToInt32(jezik_pisem_ita.Text);
                back.jezik_pisem_spa = Convert.ToInt32(jezik_pisem_spa.Text);
                back.jezik_pisem_ger = Convert.ToInt32(jezik_pisem_ger.Text);
                back.jezik_pisem_drugi = Convert.ToInt32(jezik_pisem_drugi.Text);

                back.jezik_pricam_eng = Convert.ToInt32(jezik_pricam_eng.Text);
                back.jezik_pricam_fra = Convert.ToInt32(jezik_pricam_fra.Text);
                back.jezik_pricam_rus = Convert.ToInt32(jezik_pricam_rus.Text);
                back.jezik_pricam_ita = Convert.ToInt32(jezik_pricam_ita.Text);
                back.jezik_pricam_spa = Convert.ToInt32(jezik_pricam_spa.Text);
                back.jezik_pricam_ger = Convert.ToInt32(jezik_pricam_ger.Text);
                back.jezik_pricam_drugi = Convert.ToInt32(jezik_pricam_drugi.Text);

                back.jezik_drugi_ime = jezik_drugi_ime.Text;
            
            /* PODRUCJE INTERESOVANJA */
                back.podrucjeInteresovanja_jedan = podrucjeInteresovanja_jedan.Text;
                back.podrucjeInteresovanja_dva = podrucjeInteresovanja_dva.Text;
                back.podrucjeInteresovanja_tri = podrucjeInteresovanja_tri.Text;

            /* OBLASTI INTERESOVANJA */
                back.oblasti_zastitaZdravlja = Convert.ToInt32(oblasti_zastitaZdravlja.Text);
                back.oblasti_akcijeNaZastitiZivotneSredine = Convert.ToInt32(oblasti_akcijeNaZastitiZivotneSredine.Text);
                back.oblasti_zastitaBiljakaZivotinja = Convert.ToInt32(oblasti_zastitaBiljakaZivotinja.Text);
                back.oblasti_humanitarniProgrami = Convert.ToInt32(oblasti_humanitarniProgrami.Text);
                back.oblasti_razvojDemokratije = Convert.ToInt32(oblasti_razvojDemokratije.Text);
                back.oblasti_ravnopravnostPolova = Convert.ToInt32(oblasti_ravnopravnostPolova.Text);
                back.oblasti_promocijaMira = Convert.ToInt32(oblasti_promocijaMira.Text);
                back.oblasti_internacionalniKampovi = Convert.ToInt32(oblasti_internacionalniKampovi.Text);
                back.oblasti_onlineVolontiranje = Convert.ToInt32(oblasti_onlineVolontiranje.Text);
                back.oblasti_promocijaKultureZivljenja = Convert.ToInt32(oblasti_promocijaKultureZivljenja.Text);
                back.oblasti_promocijaPravaManjina = Convert.ToInt32(oblasti_promocijaPravaManjina.Text);
                back.oblasti_pomocUcenju = Convert.ToInt32(oblasti_pomocUcenju.Text);
                back.oblasti_sportskeManifestacije = Convert.ToInt32(oblasti_sportskeManifestacije.Text);
                back.oblasti_pruzanjePomociInvalidima = Convert.ToInt32(oblasti_pruzanjePomociInvalidima.Text);
                back.oblasti_pruzanjePomociMentalnim = Convert.ToInt32(oblasti_pruzanjePomociMentalnim.Text);
                back.oblasti_pruzanjePomociStarima = Convert.ToInt32(oblasti_pruzanjePomociStarima.Text);
                back.oblasti_pruzanjePomociDrogasima = Convert.ToInt32(oblasti_pruzanjePomociDrogasima.Text);
                back.oblasti_pruzanjePomociKockarima = Convert.ToInt32(oblasti_pruzanjePomociKockarima.Text);
                back.oblasti_istrazivackiProjekti = Convert.ToInt32(oblasti_istrazivackiProjekti.Text);
                back.oblasti_kancelarijskiPoslovi = Convert.ToInt32(oblasti_kancelarijskiPoslovi.Text);
                back.oblasti_organizacioniPoslovi = Convert.ToInt32(oblasti_organizacioniPoslovi.Text);
                back.oblasti_prevodjenje = Convert.ToInt32(oblasti_prevodjenje.Text);
                back.oblasti_kulturaUmjetnost = Convert.ToInt32(oblasti_kulturaUmjetnost.Text);
                back.oblasti_arheologija = Convert.ToInt32(oblasti_arheologija.Text);
                back.oblasti_obnovaRekonstrukcija = Convert.ToInt32(oblasti_obnovaRekonstrukcija.Text);
                back.oblasti_informacioneTehnologije = Convert.ToInt32(oblasti_informacioneTehnologije.Text);
                back.oblasti_muzickeManifestacije = Convert.ToInt32(oblasti_muzickeManifestacije.Text);
                back.oblasti_interkulturalnoUcenje = Convert.ToInt32(oblasti_interkulturalnoUcenje.Text);
            
            /* DODATNE INFORMACIJE */
                back.dodatneInformacije_angazman = dodatneInfo_angazman.Text;
                back.dodatneInformacije_dostupnost = dodatneInfo_dostupnost.Text;
                back.dodatneInformacije_obukaVolontera = dodatneInfo_obukaVolontera.Text;
                back.dodatneInfo_motivacijaVolontera = dodatneInfo_motivacijaVolontera.Text;
                back.dodatneInfo_dodatneInformacije = dodatneInfo_dodatneInformacije.Text;

                back.priprema();
            return back;
        }
    }

    //
    //  KLASA ZA SLANJE PODATAKA IZ NOVOG CLANA!
    //
    public class PodaciZa_NovogClana
    {
        public PodaciZa_NovogClana(){}
        // SPY MEHANIZAM
        public PodaciZa_NovogClana(string[] unos){
            jasam_idc = unos[0];
            jasam_imePrezime = unos[1];
            jasam_pol = unos[2];
            jasam_rodjenje = unos[3];
            jasam_brojGodina = unos[4];
            jasam_mjestoRodjenja = unos[5];
            jasam_adresa = unos[6];
            jasam_telefon = unos[7];
            jasam_email = unos[8];
            jasam_facebook = unos[9];
            jasam_skype = unos[10];
            jasam_vrijemeVolontiranja = unos[11];
            jasam_aktivan = unos[12];
            jesam_volonterskiSati = Convert.ToInt32(unos[13]);
            jasam_datumPopunjavanjaUpitnika = unos[14];
            jasam_vrijemeUnosaUBazu = unos[15];

            // STATUS ..
            status_profesija = unos[16];
            status_trenutniStatus = unos[17];
            status_pojasnjenjeStatusa = unos[18];
            status_radnoIskustvo = unos[19];

            // A SADA...
            asada_trenutnoPohadjam = unos[20];
            asada_honorarniAngazman = unos[21];
            asada_hobi = unos[22];
            asada_omiljenjeStvari = unos[23];
            asada_omiljeniGradovi = unos[24];

            // VOLONTERSKO ISKUSTVO
            viskustvo_kojaOrganizacija = unos[25];
            viskustvo_trajanjeAngazmana = unos[26];
            viskustvo_opisVolonterskihAktivnosti = unos[27];
            viskustvo_kojePrilike = unos[28];
            viskustvo_opisNeVolonterskihAktivnosti = unos[29];

            //POZNAVANJE JEZIKA
            jezik_drugi_ime = unos[30];
            jezik_razumijem_eng = Convert.ToInt32(unos[31]);
            jezik_razumijem_fra = Convert.ToInt32(unos[32]);
            jezik_razumijem_rus = Convert.ToInt32(unos[33]);
            jezik_razumijem_ita = Convert.ToInt32(unos[34]);
            jezik_razumijem_spa = Convert.ToInt32(unos[35]);
            jezik_razumijem_ger = Convert.ToInt32(unos[36]);
            jezik_razumijem_drugi = Convert.ToInt32(unos[37]);

            jezik_pricam_eng = Convert.ToInt32(unos[38]);
            jezik_pricam_fra = Convert.ToInt32(unos[39]);
            jezik_pricam_rus = Convert.ToInt32(unos[40]);
            jezik_pricam_ita = Convert.ToInt32(unos[41]);
            jezik_pricam_spa = Convert.ToInt32(unos[42]);
            jezik_pricam_ger = Convert.ToInt32(unos[43]);
            jezik_pricam_drugi = Convert.ToInt32(unos[44]);

            jezik_pisem_eng = Convert.ToInt32(unos[45]);
            jezik_pisem_fra = Convert.ToInt32(unos[46]);
            jezik_pisem_rus = Convert.ToInt32(unos[47]);
            jezik_pisem_ita = Convert.ToInt32(unos[48]);
            jezik_pisem_spa = Convert.ToInt32(unos[49]);
            jezik_pisem_ger = Convert.ToInt32(unos[50]);
            jezik_pisem_drugi = Convert.ToInt32(unos[51]);

            // PODRUCJE INTERESOVANJE
            podrucjeInteresovanja_jedan = unos[52];
            podrucjeInteresovanja_dva = unos[53];
            podrucjeInteresovanja_tri = unos[54];
                    
            // DODATNE INFORMACIJE
            dodatneInformacije_angazman = unos[55];
            dodatneInformacije_dostupnost = unos[56];
            dodatneInformacije_obukaVolontera = unos[57];
            dodatneInfo_motivacijaVolontera = unos[58];
            dodatneInfo_dodatneInformacije = unos[59];

            //OBLASTI
            oblasti_zastitaZdravlja = Convert.ToInt32(unos[60]);
            oblasti_akcijeNaZastitiZivotneSredine = Convert.ToInt32(unos[61]);
            oblasti_zastitaBiljakaZivotinja = Convert.ToInt32(unos[62]);
            oblasti_humanitarniProgrami = Convert.ToInt32(unos[63]);
            oblasti_razvojDemokratije = Convert.ToInt32(unos[64]);
            oblasti_ravnopravnostPolova = Convert.ToInt32(unos[65]);
            oblasti_promocijaMira = Convert.ToInt32(unos[66]);
            oblasti_internacionalniKampovi = Convert.ToInt32(unos[67]);
            oblasti_onlineVolontiranje = Convert.ToInt32(unos[68]);
            oblasti_promocijaKultureZivljenja = Convert.ToInt32(unos[69]);
            oblasti_promocijaPravaManjina = Convert.ToInt32(unos[70]);
            oblasti_pomocUcenju = Convert.ToInt32(unos[71]);
            oblasti_sportskeManifestacije = Convert.ToInt32(unos[72]);
            oblasti_pruzanjePomociInvalidima = Convert.ToInt32(unos[73]);
            oblasti_pruzanjePomociMentalnim = Convert.ToInt32(unos[74]);
            oblasti_pruzanjePomociStarima = Convert.ToInt32(unos[75]);
            oblasti_pruzanjePomociDrogasima = Convert.ToInt32(unos[76]);
            oblasti_pruzanjePomociKockarima = Convert.ToInt32(unos[77]);
            oblasti_istrazivackiProjekti = Convert.ToInt32(unos[78]);
            oblasti_kancelarijskiPoslovi = Convert.ToInt32(unos[79]);
            oblasti_organizacioniPoslovi = Convert.ToInt32(unos[80]);
            oblasti_prevodjenje = Convert.ToInt32(unos[81]);
            oblasti_kulturaUmjetnost = Convert.ToInt32(unos[82]);
            oblasti_arheologija = Convert.ToInt32(unos[83]);
            oblasti_obnovaRekonstrukcija = Convert.ToInt32(unos[84]);
            oblasti_informacioneTehnologije = Convert.ToInt32(unos[85]);
            oblasti_muzickeManifestacije = Convert.ToInt32(unos[86]);
            oblasti_interkulturalnoUcenje = Convert.ToInt32(unos[87]);
        }
        /* JA SAM.. */
        public string jasam_idc = "";
        public string jasam_imePrezime = "";
        public string jasam_pol = "";
        public string jasam_rodjenje = "";
        public string jasam_brojGodina = "0";
        public string jasam_mjestoRodjenja = "";
        public string jasam_telefon = "";
        public string jasam_email = "";
        public string jasam_skype = "";
        public string jasam_facebook = "";
        public string jasam_aktivan = "Aktivan";
        public string jasam_vrijemeVolontiranja = "";
        public int jesam_volonterskiSati = 0;
        public string jasam_datumPopunjavanjaUpitnika = "";
        public string jasam_adresa = "";
        public string jasam_vrijemeUnosaUBazu = "";


        /* STATUS */
        public string status_profesija = "";
        public string status_trenutniStatus = "";
        public string status_pojasnjenjeStatusa = "";
        public string status_radnoIskustvo = "";

        /* A SADA..*/
        public string asada_trenutnoPohadjam = "";
        public string asada_honorarniAngazman = "";
        public string asada_hobi = "";
        public string asada_omiljenjeStvari = "";
        public string asada_omiljeniGradovi = "";

        /* VOLONTERSKO ISKUSTVO */
        public string viskustvo_kojaOrganizacija = "";
        public string viskustvo_trajanjeAngazmana = "";
        public string viskustvo_opisVolonterskihAktivnosti = "";
        public string viskustvo_kojePrilike = "";
        public string viskustvo_opisNeVolonterskihAktivnosti = "";

        /* POZNAVANJE JEZIKA */
        public int jezik_razumijem_eng = 1;
        public int jezik_razumijem_fra = 1;
        public int jezik_razumijem_rus = 1;
        public int jezik_razumijem_ita = 1;
        public int jezik_razumijem_spa = 1;
        public int jezik_razumijem_ger = 1;
        public int jezik_razumijem_drugi = 1;
        
        public int jezik_pricam_eng = 1;
        public int jezik_pricam_fra = 1;
        public int jezik_pricam_rus = 1;
        public int jezik_pricam_ita = 1;
        public int jezik_pricam_spa = 1;
        public int jezik_pricam_ger = 1;
        public int jezik_pricam_drugi = 1;
        
        public int jezik_pisem_eng = 1;
        public int jezik_pisem_fra = 1;
        public int jezik_pisem_rus = 1;
        public int jezik_pisem_ita = 1;
        public int jezik_pisem_spa = 1;
        public int jezik_pisem_ger = 1;
        public int jezik_pisem_drugi = 1;

        public string jezik_drugi_ime = "";

        /* PODRUCJE INTERESOVANJA */
        public string podrucjeInteresovanja_jedan = "";
        public string podrucjeInteresovanja_dva = "";
        public string podrucjeInteresovanja_tri = "";

        /* OBLASTI INTERESOVANJA */
        public int oblasti_zastitaZdravlja = 1;
        public int oblasti_akcijeNaZastitiZivotneSredine = 1;
        public int oblasti_zastitaBiljakaZivotinja = 1;
        public int oblasti_humanitarniProgrami = 1;
        public int oblasti_razvojDemokratije = 1;
        public int oblasti_ravnopravnostPolova = 1;
        public int oblasti_promocijaMira = 1;
        public int oblasti_internacionalniKampovi = 1;
        public int oblasti_onlineVolontiranje = 1;
        public int oblasti_promocijaKultureZivljenja = 1;
        public int oblasti_promocijaPravaManjina = 1;
        public int oblasti_pomocUcenju = 1;
        public int oblasti_sportskeManifestacije = 1;
        public int oblasti_pruzanjePomociInvalidima = 1;
        public int oblasti_pruzanjePomociMentalnim = 1;
        public int oblasti_pruzanjePomociStarima = 1;
        public int oblasti_pruzanjePomociDrogasima = 1;
        public int oblasti_pruzanjePomociKockarima = 1;
        public int oblasti_istrazivackiProjekti = 1;
        public int oblasti_kancelarijskiPoslovi = 1;
        public int oblasti_organizacioniPoslovi = 1;
        public int oblasti_prevodjenje = 1;
        public int oblasti_kulturaUmjetnost = 1;
        public int oblasti_arheologija = 1;
        public int oblasti_obnovaRekonstrukcija = 1;
        public int oblasti_informacioneTehnologije = 1;
        public int oblasti_muzickeManifestacije = 1;
        public int oblasti_interkulturalnoUcenje = 1;

        /* DODATNE INFORMACIJE */
        public string dodatneInformacije_angazman = "";
        public string dodatneInformacije_dostupnost = "";
        public string dodatneInformacije_obukaVolontera = "";
        public string dodatneInfo_motivacijaVolontera = "";
        public string dodatneInfo_dodatneInformacije = "";

        public void priprema(){
            jasam_imePrezime = jasam_imePrezime.Replace('\'', '"');
            jasam_pol = jasam_pol.Replace('\'', '"');
            jasam_rodjenje = jasam_rodjenje.Replace('\'', '"');
            jasam_email = jasam_email.Replace('\'', '"');
            jasam_mjestoRodjenja = jasam_mjestoRodjenja.Replace('\'', '"');
            jasam_telefon = jasam_telefon.Replace('\'', '"');
            jasam_skype = jasam_skype.Replace('\'', '"');
            jasam_facebook = jasam_facebook.Replace('\'', '"');
            jasam_aktivan = jasam_aktivan.Replace('\'', '"');
            jasam_vrijemeVolontiranja = jasam_vrijemeVolontiranja.Replace('\'', '"');
            jasam_datumPopunjavanjaUpitnika = jasam_datumPopunjavanjaUpitnika.Replace('\'', '"');
            jasam_adresa = jasam_adresa.Replace('\'', '"');
            status_profesija = status_profesija.Replace('\'', '"');
            status_trenutniStatus = status_trenutniStatus.Replace('\'', '"');
            status_pojasnjenjeStatusa = status_pojasnjenjeStatusa.Replace('\'', '"');
            status_radnoIskustvo = status_radnoIskustvo.Replace('\'', '"');
            asada_trenutnoPohadjam = asada_trenutnoPohadjam.Replace('\'', '"');
            asada_honorarniAngazman = asada_honorarniAngazman.Replace('\'', '"');
            asada_hobi = asada_hobi.Replace('\'', '"');
            asada_omiljenjeStvari = asada_omiljenjeStvari.Replace('\'', '"');
            asada_omiljeniGradovi = asada_omiljeniGradovi.Replace('\'', '"');
            viskustvo_kojaOrganizacija = viskustvo_kojaOrganizacija.Replace('\'', '"');
            viskustvo_kojePrilike = viskustvo_kojePrilike.Replace('\'', '"');
            viskustvo_opisNeVolonterskihAktivnosti = viskustvo_opisNeVolonterskihAktivnosti.Replace('\'', '"');
            viskustvo_opisVolonterskihAktivnosti = viskustvo_opisVolonterskihAktivnosti.Replace('\'', '"');
            viskustvo_trajanjeAngazmana = viskustvo_trajanjeAngazmana.Replace('\'', '"');
            jezik_drugi_ime = jezik_drugi_ime.Replace('\'', '"');
            podrucjeInteresovanja_jedan = podrucjeInteresovanja_jedan.Replace('\'', '"');
            podrucjeInteresovanja_dva = podrucjeInteresovanja_dva.Replace('\'', '"');
            podrucjeInteresovanja_tri = podrucjeInteresovanja_tri.Replace('\'', '"');
            dodatneInformacije_angazman = dodatneInformacije_angazman.Replace('\'', '"');
            dodatneInformacije_dostupnost = dodatneInformacije_dostupnost.Replace('\'', '"');
            dodatneInformacije_obukaVolontera = dodatneInformacije_obukaVolontera.Replace('\'', '"');
            dodatneInfo_motivacijaVolontera = dodatneInfo_motivacijaVolontera.Replace('\'', '"');
            dodatneInfo_dodatneInformacije = dodatneInfo_dodatneInformacije.Replace('\'', '"');
        }
    }
}
