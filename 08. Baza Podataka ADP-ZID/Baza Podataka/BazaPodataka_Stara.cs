using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace _08.Baza_Podataka_ADP_ZID
{
    class BazaPodataka_Stara
    {
        public BazaPodataka_Stara(string put)
        {
            put_fajla = put;
        }
        string put_fajla;
        OleDbConnection conn;

        private bool connect(){
            try{
                conn = new OleDbConnection("Provider= Microsoft.Jet.OLEDB.4.0;Data source=\""+put_fajla+"\";Persist Security Info=False"); conn.Open();
                return false;
            }
            catch (Exception) { return true; }
        }
        private void close() { try { conn.Close(); } catch(Exception){} }

        public bool pokusaj_konekciju(){
            bool back = connect();
            if (!back) close();
            return back;
        }

        public int[] preuzimanjeIndeksa(){
            if (connect()) return null;
            int []back = null;
            try{
                OleDbCommand komanda = new OleDbCommand("SELECT COUNT(*) FROM db;", conn);
                OleDbDataReader reader = komanda.ExecuteReader();
                if(reader.Read()) back = new int[Convert.ToInt32(reader[0].ToString())];

                reader.Close(); komanda = new OleDbCommand("SELECT [No] FROM db;", conn);
                reader = komanda.ExecuteReader();
                for(int i = 0; i < back.Length; i++){
                    if (reader.Read()) back[i] = Convert.ToInt32(reader[0]);
                    else back[i] = -1;
                } 
                reader.Close(); close();
            } catch(Exception){}
            return back;
        }

        public PodaciZa_NovogClana preuzmiClana(int indeks){
            if (connect()) return null;
            PodaciZa_NovogClana back = null;
            OleDbCommand komanda = new OleDbCommand("SELECT " +
                                "[Ime] ,"+ /* 0 */
                                "[Prezime] ,"+ /* 1 */
                                "[Pol] ,"+ /* 2 */
                                "[Adresa i mjesto stanovanja] ,"+ /* 3 */
                                "[Kontakttelefon] ,"+ /* 4 */
                                "[e-mail adresa] ,"+ /* 5 */
                                "[Facebook profile] ,"+ /* 6 */
                                "Format([Datum rođenja], \"DD.MM.YYYY\") ,"+ /* 7 */
                                "[Mjesto rođenja] ,"+ /* 8 */
                                "[Dali li bi ste se angažovali na volonterskim aktivnostima kod dr] ,"+ /* 9 */
                                "[Servis/Komentari] ,"+ /* 10 */
                                "[Skype] ,"+ /* 11 */
                                "[Profesia] ,"+ /* 12 */
                                "[Trenutni status] ,"+ /* 13 */
                                "[Pojašnjenje trenutnog statusa] ,"+ /* 14 */
                                "[Dosadašnje radno iskustvo] ,"+ /* 15 */
                                "[Honorarni angažman] ,"+ /* 16 */
                                "[Ukoliko ste volontirali kroz organizacije] ,"+  /* 17 */
                                "[Engleski-razumijem] ,"+  /* 18 */
                                "[Engleski-pričam] ,"+  /* 19 */
                                "[Engleski-pišem] ,"+  /* 20 */
                                "[Francuski-razumijem] ,"+  /* 21 */
                                "[Francuski-pričam] ,"+  /* 22 */
                                "[Francuski-pišem] ,"+  /* 23 */
                                "[Ruski-razumijem] ,"+  /* 24 */
                                "[Ruski-pričam] ,"+  /* 25 */
                                "[Ruski-pišem] ,"+  /* 26 */
                                "[Italijanski-razumijem] ,"+  /* 27 */
                                "[Italijanski-pričam] ,"+  /* 28 */
                                "[Italijanski-pišem] ,"+  /* 29 */
                                "[Španski-razumijem] ,"+  /* 30 */
                                "[Španski-pričam] ,"+  /* 31 */
                                "[Španski-pišem] ,"+  /* 32 */
                                "[Njemački-razumijem] ,"+  /* 33 */
                                "[Njemački-pričam] ,"+  /* 34 */
                                "[Njemački-pišem] ,"+  /* 35 */
                                "[Drugi jezik] ,"+  /* 36 */
                                "[Područje interesovanja1] ,"+  /* 37 */
                                "[Područje interesovanja2] ,"+  /* 38 */
                                "[Područje interesovanja3] ,"+  /* 39 */
                                "[akcije na zaštiti životne sredine] ,"+  /* 40 */
                                "[zaštita zdravlja] ,"+  /* 41 */
                                "[zaštita biljaka i životinja] ,"+  /* 42 */
                                "[humanitarni programi] ,"+  /* 43 */
                                "[razvoj demokratije] ,"+  /* 44 */
                                "[ravnopravnost polova] ,"+  /* 45 */
                                "[promocija mira, međuetničkog i vjerskog sklada1] ,"+  /* 46 */
                                "[internacionalni kampovi] ,"+  /* 47 */
                                "[interkulturalno učenje] ,"+  /* 48 */
                                "[online volontiranje] ,"+  /* 49 */
                                "[promocija kulture življenja] ,"+  /* 50 */
                                "[promocija manjinskih prava] ,"+  /* 51 */
                                "[pomoć u učenje] ,"+  /* 52 */
                                "[Pružanje pomoći djeci i omladini sa fizičkim invaliditetom] ,"+  /* 53 */
                                "[Pružanje pomoći djeci i omladini sa mentalnim smetnjama] ,"+  /* 54 */
                                "[Pružanje pomoći starim osobama] ,"+  /* 55 */
                                "[Pružanje pomoći korisnicima psihoaktivnih supstanci] ,"+  /* 56 */
                                "[Podrška kod nehemijskih zavisnosti] ,"+  /* 57 */
                                "[istraživački projekt] ,"+  /* 58 */
                                "[Kancelarijski poslovi] ,"+  /* 59 */
                                "[organizacioni poslovi] ,"+  /* 60 */
                                "[Prevođenje] ,"+  /* 61 */
                                "[Kultura i umjetnost] ,"+  /* 62 */
                                "[arheologija] ,"+  /* 63 */
                                "[obnova i rekonstrukcija] ,"+  /* 64 */
                                "[informacione tehnologije] ,"+  /* 65 */
                                "[muzičke manifestacije] ,"+  /* 66 */
                                "[sportske manifestacije] ,"+  /* 67 */
                                "[samoinicijativa] ,"+  /* 68 */
                                "[Motivacija Max1] ,"+  /* 69 */
                                "[Motivacija Max2] ,"+  /* 70 */
                                "[Motivacija Max3] ,"+  /* 71 */
                                "[sati/ dana] ,"+  /* 72 */
                                "Format([Datum popunjavanja upitnika], \"DD.MM.YYYY\") "+  /* 73 */
                                " FROM db WHERE [No]="+indeks+";", conn);
            OleDbDataReader reader = komanda.ExecuteReader();
            if(!reader.Read()) {close(); return null; }
            back = new PodaciZa_NovogClana();

            back.jasam_imePrezime = reader[0].ToString() + " " + reader[1].ToString();
            back.jasam_adresa = reader[3].ToString();
            back.jasam_datumPopunjavanjaUpitnika = reader[73].ToString();
            back.jasam_email = reader[5].ToString();
            back.jasam_facebook = reader[6].ToString();
            back.jasam_mjestoRodjenja = reader[8].ToString();
            back.jasam_pol = getPol(reader[2].ToString());
            //back.jasam_rodjenje = getDate(reader[7].ToString());
            back.jasam_rodjenje = reader[7].ToString();
            back.jasam_brojGodina = Home_Form.racunanjeBrojaGodina(back.jasam_rodjenje);
            back.jasam_skype = reader[11].ToString();
            back.jasam_telefon = reader[4].ToString();
            back.jasam_vrijemeVolontiranja = reader[72].ToString();

            back.status_pojasnjenjeStatusa = reader[14].ToString();
            back.status_profesija = reader[12].ToString();
            back.status_radnoIskustvo = reader[15].ToString();
            back.status_trenutniStatus = reader[13].ToString();

            back.asada_honorarniAngazman = reader[16].ToString();
            //back.viskustvo_kojaOrganizacija = reader[17].ToString();
            // 11/4/1992 12:

            if(reader[18].ToString()!="") back.jezik_razumijem_eng = Convert.ToInt32(reader[18].ToString());
            if(reader[19].ToString()!="") back.jezik_pricam_eng = Convert.ToInt32(reader[19].ToString());
            if(reader[20].ToString()!="") back.jezik_pisem_eng = Convert.ToInt32(reader[20].ToString());
            if(reader[21].ToString()!="") back.jezik_razumijem_fra = Convert.ToInt32(reader[21].ToString());
            if(reader[22].ToString()!="") back.jezik_pricam_fra = Convert.ToInt32(reader[22].ToString());
            if(reader[23].ToString()!="") back.jezik_pisem_fra = Convert.ToInt32(reader[23].ToString());
            if(reader[24].ToString()!="") back.jezik_razumijem_rus = Convert.ToInt32(reader[24].ToString());
            if(reader[25].ToString()!="") back.jezik_pricam_rus = Convert.ToInt32(reader[25].ToString());
            if(reader[26].ToString()!="") back.jezik_pisem_rus = Convert.ToInt32(reader[26].ToString());
            if(reader[27].ToString()!="") back.jezik_razumijem_ita = Convert.ToInt32(reader[27].ToString());
            if(reader[28].ToString()!="") back.jezik_pricam_ita = Convert.ToInt32(reader[28].ToString());
            if(reader[29].ToString()!="") back.jezik_pisem_ita = Convert.ToInt32(reader[29].ToString());
            if(reader[30].ToString()!="") back.jezik_razumijem_spa = Convert.ToInt32(reader[30].ToString());
            if(reader[31].ToString()!="") back.jezik_pricam_spa = Convert.ToInt32(reader[31].ToString());
            if(reader[32].ToString()!="") back.jezik_pisem_spa = Convert.ToInt32(reader[32].ToString());
            if(reader[33].ToString()!="") back.jezik_razumijem_ger = Convert.ToInt32(reader[33].ToString());
            if(reader[34].ToString()!="") back.jezik_pricam_ger = Convert.ToInt32(reader[34].ToString());
            if(reader[35].ToString()!="") back.jezik_pisem_ger = Convert.ToInt32(reader[35].ToString());
            back.jezik_drugi_ime = reader[36].ToString();
            
            back.podrucjeInteresovanja_jedan = reader[37].ToString();
            back.podrucjeInteresovanja_dva = reader[38].ToString();
            back.podrucjeInteresovanja_tri = reader[39].ToString();

            if(reader[40].ToString()!="") back.oblasti_akcijeNaZastitiZivotneSredine = Convert.ToInt32(reader[40].ToString());
            if(reader[63].ToString()!="") back.oblasti_arheologija = Convert.ToInt32(reader[63].ToString());
            if(reader[43].ToString()!="") back.oblasti_humanitarniProgrami = Convert.ToInt32(reader[43].ToString());
            if(reader[65].ToString()!="") back.oblasti_informacioneTehnologije = Convert.ToInt32(reader[65].ToString());
            if(reader[48].ToString()!="") back.oblasti_interkulturalnoUcenje = Convert.ToInt32(reader[48].ToString());
            if(reader[47].ToString()!="") back.oblasti_internacionalniKampovi = Convert.ToInt32(reader[47].ToString());
            if(reader[58].ToString()!="") back.oblasti_istrazivackiProjekti = Convert.ToInt32(reader[58].ToString());
            if(reader[59].ToString()!="") back.oblasti_kancelarijskiPoslovi = Convert.ToInt32(reader[59].ToString());
            if(reader[63].ToString()!="") back.oblasti_kulturaUmjetnost = Convert.ToInt32(reader[63].ToString());
            if(reader[66].ToString()!="") back.oblasti_muzickeManifestacije = Convert.ToInt32(reader[66].ToString());
            if(reader[64].ToString()!="") back.oblasti_obnovaRekonstrukcija = Convert.ToInt32(reader[64].ToString());
            if(reader[49].ToString()!="") back.oblasti_onlineVolontiranje = Convert.ToInt32(reader[49].ToString());
            if(reader[60].ToString()!="") back.oblasti_organizacioniPoslovi = Convert.ToInt32(reader[60].ToString());
            if(reader[52].ToString()!="") back.oblasti_pomocUcenju = Convert.ToInt32(reader[52].ToString());
            if(reader[61].ToString()!="") back.oblasti_prevodjenje = Convert.ToInt32(reader[61].ToString());
            if(reader[50].ToString()!="") back.oblasti_promocijaKultureZivljenja = Convert.ToInt32(reader[50].ToString());
            if(reader[46].ToString()!="") back.oblasti_promocijaMira = Convert.ToInt32(reader[46].ToString());
            if(reader[51].ToString()!="") back.oblasti_promocijaPravaManjina = Convert.ToInt32(reader[51].ToString());
            if(reader[56].ToString()!="") back.oblasti_pruzanjePomociDrogasima = Convert.ToInt32(reader[56].ToString());
            if(reader[53].ToString()!="") back.oblasti_pruzanjePomociInvalidima = Convert.ToInt32(reader[53].ToString());
            if(reader[57].ToString()!="") back.oblasti_pruzanjePomociKockarima = Convert.ToInt32(reader[57].ToString());
            if(reader[54].ToString()!="") back.oblasti_pruzanjePomociMentalnim = Convert.ToInt32(reader[54].ToString());
            if(reader[55].ToString()!="") back.oblasti_pruzanjePomociStarima = Convert.ToInt32(reader[55].ToString());
            if(reader[45].ToString()!="") back.oblasti_ravnopravnostPolova = Convert.ToInt32(reader[45].ToString());
            if(reader[44].ToString()!="") back.oblasti_razvojDemokratije = Convert.ToInt32(reader[44].ToString());
            if(reader[67].ToString()!="") back.oblasti_sportskeManifestacije = Convert.ToInt32(reader[67].ToString());
            if(reader[42].ToString()!="") back.oblasti_zastitaBiljakaZivotinja = Convert.ToInt32(reader[42].ToString());
            if(reader[41].ToString()!="") back.oblasti_zastitaZdravlja = Convert.ToInt32(reader[41].ToString());
            
            back.dodatneInfo_motivacijaVolontera = reader[69].ToString() + "\r\n" + reader[70].ToString() + "\r\n" + reader[71].ToString();
            back.dodatneInfo_dodatneInformacije = reader[10].ToString();
            back.priprema();

            close(); return back;
        }
        private string getPol(string unos){
            if (unos == "M") return "Muski";
            if (unos == "Z" || unos=="Ž") return "Zenski";
            else return unos;
        }
        private string getDate(string unos){
            if (unos.Length <= 9) return unos;
            return unos;
            return unos.Substring(0, unos.Length - 8);
        }

    }
}
