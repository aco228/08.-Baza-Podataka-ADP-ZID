using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using ADOX;
using System.IO;


namespace _08.Baza_Podataka_ADP_ZID
{
    class BazaPodataka_Backup
    {
        public BazaPodataka_Backup(){}
        public BazaPodataka_Backup(string put){
            lokacijaFajla = put;
            connection_string = "provider=Microsoft.Jet.OleDb.4.0;Data Source=" + lokacijaFajla;
        }

        string connection_string = "";
        public string lokacijaFajla = "";
        public string imeFajla = "";
        OleDbConnection conn;

        public bool tryConnect(){
            if (connect()) return false;
            else { close(); return true; }
        }
        private bool connect(){
            try{
                conn = new OleDbConnection(connection_string);
                conn.Open();
                return false;
            }
            catch (Exception) { return true; }
        }
        private void close() { try { conn.Close(); } catch(Exception){}}

        #region KREIRAJ NOVU BAZU
        /////////////////////////////////////////////////////////////////////////////////////////////////
        //
        //  KREIRAJ NOVI BACKUP
        //
        public void kreiraj_novuBazu(){
            kreiraj_fajlBaze();
            kreirajTablu_javne_clan();
            kreirajTablu_Grupe();
            kreirajTablu_PripadnostGrupi();
        }
        private void kreiraj_fajlBaze(){
            var cat = new ADOX.Catalog();
            lokacijaFajla = AppDomain.CurrentDomain.BaseDirectory + "Resursi\\Backup\\bazaBackup_ _" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_ _" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + ".mdb;";
            imeFajla = "bazaBackup_ _" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_ _" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + ".mdb;";
            connection_string = "provider=Microsoft.Jet.OleDb.4.0;Data Source=" + lokacijaFajla;
            cat.Create(connection_string);
            cat = null;
        }
        private void kreirajTablu_javne_clan(){
            if (connect()) return;
            OleDbCommand komanda = new OleDbCommand("CREATE TABLE [clan]("+
                                                    "    [idc] integer,"+
                                                    "    [ime_prezime] text,"+
                                                    "    [pol] text,"+
                                                    "    [datum_rodjenja] text, "+
                                                    "    [broj_godina] integer,"+
                                                    "    [mjesto_rodjenja ] text,"+
                                                    "    [adresa_stanovanja] text,"+
                                                    "    [kontakt_telefon] text,"+
                                                    "    [email] text,"+
                                                    "    [facebook] text,"+
                                                    "    [skype] text,"+
                                                    "    [vrijemeVolontiranja] text,"+
                                                    "    [status_aktivnosti] text,"+
                                                    "    [brojVolonterskihSati] integer,"+
                                                    "    [datumPopunjavanjaUpitnika] text,"+
                                                    "    [vrijemeUnosaUBazu] text,"+
                                                    "    [profesija] text,"+
                                                    "    [trenutni_status] text,"+
                                                    "    [pojasnjenje_statusa] text,"+
                                                    "    [dosadanje_radno_iskustvo] text,"+
                                                    "    [trenutno_pohadjam] text,"+
                                                    "    [honorarni_angazman] text,"+
                                                    "    [hobi] text,"+
                                                    "    [omiljenje_stvari] text,"+
                                                    "    [omiljeni_gradovi] text,"+
                                                    "    [volontirao_uOrganizaciji] text,"+
                                                    "    [volontirao_trajanjeAngazmana] text,"+
                                                    "    [volontirao_opisAktivnosti] text,"+
                                                    "    [nevolontirao_uKojimPrilikama] text,"+
                                                    "    [nevolontirao_kojeAktivnosti] text,"+
                                                    "    [engleski_razumijem] text, [engleski_pricam] text, [engleski_pisem] text,"+
                                                    "    [francuski_razumijem] text, [francuski_pricam] text, [francuski_pisem] text,"+
                                                    "    [ruski_razumijem] text, [ruski_pricam] text, [ruski_pisem] text,"+
                                                    "    [italijanski_razumijem] text, [italijanski_pricam] text, [italijanski_pisem] text,"+
                                                    "    [spanski_razumijem] text, [spanski_pricam] text, [spanski_pisem] text,"+
                                                    "    [njemacki_razumijem] text, [njemacki_pricam] text, [njemacki_pisem] text,"+
                                                    "    [drugiJezik_ime] text, [drugiJezik_razumijem] text, [drugiJezik_pricam] text, [drugiJezik_pisem] text,"+
                                                    "    [interesovanje1] text,"+
                                                    "    [interesovanje2] text,"+
                                                    "    [interesovanje3] text,"+
                                                    "    [oblasti_zastitaZdravlja] text,"+
                                                    "    [oblasti_akcijeNaZastitiZivotneSredine] text,"+
                                                    "    [oblasti_zastitaBiljakaZivotinja] text,"+
                                                    "    [oblasti_humanitarniProgrami] text,"+
                                                    "    [oblasti_razvojDemokratije] text,"+
                                                    "    [oblasti_ravnopravnostPolova] text,"+
                                                    "    [oblasti_promocijaMira] text,"+
                                                    "    [oblasti_internacionalniKampovi] text,"+
                                                    "    [oblasti_onlineVolontiranje] text,"+
                                                    "    [oblasti_promocijaKultureZivljenja] text,"+
                                                    "    [oblasti_promocijaPravaManjina] text,"+
                                                    "    [oblasti_pomocUcenje] text,"+
                                                    "    [oblasti_sportskeManifestracije] text,"+
                                                    "    [oblasti_pomocInvalidima] text,"+
                                                    "    [oblasti_pomocMentalnima] text,"+
                                                    "    [oblasti_pomocStarima] text,"+
                                                    "    [oblasti_pomocDrogasima] text,"+
                                                    "    [oblasti_pomocKockarima] text,"+
                                                    "    [oblasti_istrazivackiRadovi] text,"+
                                                    "    [oblasti_kancelarijskiPoslovi] text,"+
                                                    "    [oblasti_organizacioniPoslovi] text,"+
                                                    "    [oblasti_prevodjenje] text,"+
                                                    "    [oblasti_kulturaUmjetnost] text,"+
                                                    "    [oblasti_arheologija] text,"+
                                                    "    [oblasti_obnovaRekonstrukcija] text,"+
                                                    "    [oblasti_informacioneTehnologije] text,"+
                                                    "    [oblasti_muzickeManifestacije] text,"+
                                                    "    [oblasti_interkulturalnoUcenje] text,"+
                                                    "    [angazman] text,"+
                                                    "    [dostupnost] text,"+
                                                    "    [obuke] text,"+
                                                    "    [motivacijaVolontera] text,"+
                                                    "    [dodatneInformacije] text"+
                                                    ");", conn);
            komanda.ExecuteNonQuery();
            close();
        }
        private void kreirajTablu_Grupe(){
            if (connect()) return;
            OleDbCommand komanda = new OleDbCommand("CREATE TABLE [grupa]("+
	                                                "    [idgr] integer,"+
	                                                "    [ime_grupe] text,"+
	                                                "    [br_sati] integer,"+
	                                                "    [opis_grupe] text"+
                                                    ");", conn);
            komanda.ExecuteNonQuery();
            close();
        }
        private void kreirajTablu_PripadnostGrupi(){
            if (connect()) return;
            OleDbCommand komanda = new OleDbCommand("CREATE TABLE [pripadnosti_grupi]("+
	                                                "    [idpg] integer,"+
	                                                "    [ime_grupe] text,"+
	                                                "    [idclana] integer"+
                                                    ");", conn);
            komanda.ExecuteNonQuery();
            close();
        }
        #endregion

        #region KREIRANJE PODATAKA BAZE
        //
        //
        //
        public string noviClan_dodajNovogClana(PodaciZa_NovogClana data){
                if (data == null) return "Greška sa poslatim podacima!";
                string back = "Nemoguća konekcija sa bazom!";
                if (!connect())
                {
                    string d1 = "INSERT INTO clan (idc, ime_prezime, pol, datum_rodjenja, mjesto_rodjenja, kontakt_telefon, email, facebook, skype, vrijemeVolontiranja, status_aktivnosti, datumPopunjavanjaUpitnika, brojVolonterskihSati, adresa_stanovanja, broj_godina,";
                    string d2 = "profesija, trenutni_status, pojasnjenje_statusa, dosadanje_radno_iskustvo, ";
                    string d3 = "trenutno_pohadjam, honorarni_angazman, hobi,omiljenje_stvari, omiljeni_gradovi, ";
                    string d4 = "volontirao_uOrganizaciji, volontirao_trajanjeAngazmana, volontirao_opisAktivnosti, nevolontirao_kojeAktivnosti, nevolontirao_uKojimPrilikama,";
                    string d5 = "engleski_pisem, engleski_pricam, engleski_razumijem, ruski_pisem, ruski_pricam, ruski_razumijem, ";
                    string d6 = "francuski_pisem, francuski_pricam, francuski_razumijem, spanski_pisem, spanski_pricam, spanski_razumijem, ";
                    string d7 = "njemacki_pisem, njemacki_pricam, njemacki_razumijem, italijanski_pisem, italijanski_pricam, italijanski_razumijem, ";
                    string d8 = "drugiJezik_ime, drugiJezik_pisem, drugiJezik_pricam, drugiJezik_razumijem,";
                    string d9 = "interesovanje1, interesovanje2, interesovanje3,";
                    string d10 = "oblasti_zastitaZdravlja, oblasti_akcijeNaZastitiZivotneSredine, oblasti_zastitaBiljakaZivotinja, oblasti_humanitarniProgrami, oblasti_razvojDemokratije, oblasti_ravnopravnostPolova, oblasti_promocijaMira, oblasti_internacionalniKampovi, oblasti_onlineVolontiranje, oblasti_promocijaKultureZivljenja, oblasti_promocijaPravaManjina, oblasti_pomocUcenje, oblasti_sportskeManifestracije,";
                    string d11 = "oblasti_pomocInvalidima, oblasti_pomocMentalnima, oblasti_pomocStarima, oblasti_pomocDrogasima, oblasti_pomocKockarima, oblasti_istrazivackiRadovi, oblasti_kancelarijskiPoslovi, oblasti_organizacioniPoslovi, oblasti_prevodjenje, oblasti_kulturaUmjetnost, oblasti_arheologija, oblasti_obnovaRekonstrukcija, oblasti_informacioneTehnologije, oblasti_muzickeManifestacije,oblasti_interkulturalnoUcenje,";
                    string d12 = "angazman, dostupnost, obuke, motivacijaVolontera, dodatneInformacije) VALUES (";
                    
                    string o1 = "" + data.jasam_idc + ", " + "'" + data.jasam_imePrezime + "', " + "'" + data.jasam_pol + "', " + "'" + data.jasam_rodjenje + "', " + "'" + data.jasam_mjestoRodjenja + "', " + "'" + data.jasam_telefon + "', " + "'" + data.jasam_email + "', " + "'" + data.jasam_facebook + "', " + "'" + data.jasam_skype + "', " + "'" + data.jasam_vrijemeVolontiranja + "'," + "'" + data.jasam_aktivan + "'," + "'" + data.jasam_datumPopunjavanjaUpitnika + "'," + data.jesam_volonterskiSati + ',' + "'" + data.jasam_adresa + "'," + "" + data.jasam_brojGodina + ",";
                    string o2 = "'" + data.status_profesija + "', " + "'" + data.status_trenutniStatus + "', " + "'" + data.status_pojasnjenjeStatusa + "', " + "'" + data.status_radnoIskustvo + "',";
                    string o3 = "'" + data.asada_trenutnoPohadjam + "', " + "'" + data.asada_honorarniAngazman + "', " + "'" + data.asada_hobi + "', " + "'" + data.asada_omiljenjeStvari + "'," + "'" + data.asada_omiljeniGradovi + "',";
                    string o4 = "'" + data.viskustvo_kojaOrganizacija + "'," + "'" + data.viskustvo_trajanjeAngazmana + "'," + "'" + data.viskustvo_opisVolonterskihAktivnosti + "'," + "'" + data.viskustvo_kojePrilike + "'," + "'" + data.viskustvo_opisNeVolonterskihAktivnosti + "',";
                    string o5 = "'" + data.jezik_pisem_eng + "'," + "'" + data.jezik_pricam_eng + "'," + "'" + data.jezik_razumijem_eng + "'," + "'" + data.jezik_pisem_rus + "'," + "'" + data.jezik_pricam_rus + "'," + "'" + data.jezik_razumijem_rus + "',";
                    string o6 = "'" + data.jezik_pisem_fra + "'," + "'" + data.jezik_pricam_fra + "'," + "'" + data.jezik_razumijem_fra + "'," + "'" + data.jezik_pisem_spa + "'," + "'" + data.jezik_pricam_spa + "'," + "'" + data.jezik_razumijem_spa + "',";
                    string o7 = "'" + data.jezik_pisem_ger + "'," + "'" + data.jezik_pricam_ger + "'," + "'" + data.jezik_razumijem_ger + "'," + "'" + data.jezik_pisem_ita + "'," + "'" + data.jezik_pricam_ita + "'," + "'" + data.jezik_razumijem_ita + "',";
                    string o8 = "'" + data.jezik_drugi_ime + "'," + "'" + data.jezik_pisem_drugi + "'," + "'" + data.jezik_pricam_drugi + "'," + "'" + data.jezik_razumijem_drugi + "',";
                    string o9 = "'" + data.podrucjeInteresovanja_jedan + "'," + "'" + data.podrucjeInteresovanja_dva + "'," + "'" + data.podrucjeInteresovanja_tri + "',";
                    string o10 = "'" + data.oblasti_zastitaZdravlja + "'," + "'" + data.oblasti_akcijeNaZastitiZivotneSredine + "'," + "'" + data.oblasti_zastitaBiljakaZivotinja + "'," +"'" + data.oblasti_humanitarniProgrami + "'," +"'" + data.oblasti_razvojDemokratije + "'," +"'" + data.oblasti_ravnopravnostPolova + "'," +"'" + data.oblasti_promocijaMira + "'," +"'" + data.oblasti_internacionalniKampovi + "'," +"'" + data.oblasti_onlineVolontiranje + "'," +"'" + data.oblasti_promocijaKultureZivljenja + "'," +"'" + data.oblasti_promocijaPravaManjina + "'," +"'" + data.oblasti_pomocUcenju + "'," +"'" + data.oblasti_sportskeManifestacije + "',";
                    string o11 = "'" + data.oblasti_pruzanjePomociInvalidima + "'," +"'" + data.oblasti_pruzanjePomociMentalnim + "'," +"'" + data.oblasti_pruzanjePomociStarima + "'," +"'" + data.oblasti_pruzanjePomociDrogasima + "'," +"'" + data.oblasti_pruzanjePomociKockarima + "'," +"'" + data.oblasti_istrazivackiProjekti + "'," +"'" + data.oblasti_kancelarijskiPoslovi + "'," +"'" + data.oblasti_organizacioniPoslovi + "'," +"'" + data.oblasti_prevodjenje + "'," +"'" + data.oblasti_kulturaUmjetnost + "'," +"'" + data.oblasti_arheologija + "'," +"'" + data.oblasti_obnovaRekonstrukcija + "'," +"'" + data.oblasti_informacioneTehnologije + "'," +"'" + data.oblasti_muzickeManifestacije + "',"+"'" + data.oblasti_interkulturalnoUcenje + "',";
                    string o12 = "'" + data.dodatneInformacije_angazman + "'," + "'" + data.dodatneInformacije_dostupnost + "'," + "'" + data.dodatneInformacije_obukaVolontera + "', " + "'" + data.dodatneInfo_motivacijaVolontera + "'," + "'" + data.dodatneInfo_dodatneInformacije + "'";
                 
                    try{
                        OleDbCommand komanda = new OleDbCommand(d1+d2+d3+d4+d5+d6+d7+d8+d9+d10+d11+d12+o1+o2+o3+o4+o5+o6+o7+o8+o9+o10+o11+o12+");", conn);
                        komanda.ExecuteNonQuery();
                        back = "";
                    }catch (Exception) { back = "Greška. Baza je vjerovatno preopterećena. Pokušajte ponovo!";  }
                    close(); 
                } return back;
            }

            public bool grupe_dodajNovuGrupu(string idgr, string ime, string opis, string br_sati){
                if (!connect())
                {
                    OleDbCommand komanda = new OleDbCommand("INSERT INTO grupa(idgr, ime_grupe, opis_grupe, br_sati) VALUES ("+idgr+", '"+ime+"', '"+opis+"'," + br_sati + ");", conn);
                    komanda.ExecuteNonQuery();
                    close(); return true;
                }
                else return false;
            }

            public string pretraga_dodajVolonteraUGrupu(string idpg, string imeGrupe, string idVolontera){
                string back = "Greska sa bazom";
                if(!connect()){
                    OleDbCommand komanda = new OleDbCommand("INSERT INTO pripadnosti_grupi(idpg, ime_grupe, idclana) VALUES("+idpg+", '"+imeGrupe+"', '"+idVolontera+"');", conn);
                    komanda.ExecuteNonQuery();
                    close(); back = "";
                } return back;
            }
        #endregion

        #region PREUZIMANJE PODATAKA
        public int[] preuzimanjeIndeksa_clanova(){
            if (connect()) return null;
            int []back = null;
            try{
                OleDbCommand komanda = new OleDbCommand("SELECT COUNT(*) FROM clan;", conn);
                OleDbDataReader reader = komanda.ExecuteReader();
                if(reader.Read()) back = new int[Convert.ToInt32(reader[0].ToString())];

                reader.Close(); komanda = new OleDbCommand("SELECT [idc] FROM clan;", conn);
                reader = komanda.ExecuteReader();
                for(int i = 0; i < back.Length; i++){
                    if (reader.Read()) back[i] = Convert.ToInt32(reader[0]);
                    else back[i] = -1;
                } 
                reader.Close(); close();
            } catch(Exception){}
            return back;
        }
        public int[] preuzimanjeIndeksa_grupa(){
            if (connect()) return null;
            int []back = null;
            try{
                OleDbCommand komanda = new OleDbCommand("SELECT COUNT(*) FROM grupa;", conn);
                OleDbDataReader reader = komanda.ExecuteReader();
                if(reader.Read()) back = new int[Convert.ToInt32(reader[0].ToString())];

                reader.Close(); komanda = new OleDbCommand("SELECT [idgr] FROM grupa;", conn);
                reader = komanda.ExecuteReader();
                for(int i = 0; i < back.Length; i++){
                    if (reader.Read()) back[i] = Convert.ToInt32(reader[0]);
                    else back[i] = -1;
                } 
                reader.Close(); close();
            } catch(Exception){}
            return back;
        }
        public int[] preuzimanjeIndeksa_pripadnost(string grupa){
            if (connect()) return null;
            int []back = null;
            try{
                OleDbCommand komanda = new OleDbCommand("SELECT COUNT(*) FROM pripadnosti_grupi WHERE ime_grupe="+grupa+";", conn);
                OleDbDataReader reader = komanda.ExecuteReader();
                if(reader.Read()) back = new int[Convert.ToInt32(reader[0].ToString())];

                reader.Close(); komanda = new OleDbCommand("SELECT [idpg] FROM pripadnosti_grupi WHERE ime_grupe="+grupa+";", conn);
                reader = komanda.ExecuteReader();
                for(int i = 0; i < back.Length; i++){
                    if (reader.Read()) back[i] = Convert.ToInt32(reader[0]);
                    else back[i] = -1;
                } 
                reader.Close(); close();
            } catch(Exception){}
            return back;
        }
            public PodaciZa_NovogClana dosije_preuzmiPodatke(string idClana){
                PodaciZa_NovogClana back = null;
                if(!connect()){
                    string query = "SELECT idc, ime_prezime, pol, datum_rodjenja, mjesto_rodjenja, adresa_stanovanja, kontakt_telefon, email, facebook, skype, vrijemeVolontiranja, status_aktivnosti, brojVolonterskihSati, datumPopunjavanjaUpitnika, vrijemeUnosaUBazu, broj_godina, " + 
                                            "profesija, trenutni_status, pojasnjenje_statusa, dosadanje_radno_iskustvo,"+
                                            "trenutno_pohadjam, honorarni_angazman, hobi, omiljenje_stvari, omiljeni_gradovi,"+
                                            "volontirao_uOrganizaciji, volontirao_trajanjeAngazmana, volontirao_opisAktivnosti, nevolontirao_uKojimPrilikama, nevolontirao_kojeAktivnosti,"+
                                            "engleski_pisem, engleski_pricam, engleski_razumijem, ruski_pisem, ruski_pricam, ruski_razumijem, "+
                                            "francuski_pisem, francuski_pricam, francuski_razumijem, spanski_pisem, spanski_pricam, spanski_razumijem, "+
                                            "njemacki_pisem, njemacki_pricam, njemacki_razumijem, italijanski_pisem, italijanski_pricam, italijanski_razumijem, "+
                                            "drugiJezik_ime, drugiJezik_pisem, drugiJezik_pricam, drugiJezik_razumijem,"+
                                            "interesovanje1, interesovanje2, interesovanje3,"+
                                            "oblasti_zastitaZdravlja, oblasti_akcijeNaZastitiZivotneSredine, oblasti_zastitaBiljakaZivotinja, oblasti_humanitarniProgrami, oblasti_razvojDemokratije, oblasti_ravnopravnostPolova, oblasti_promocijaMira, oblasti_internacionalniKampovi, oblasti_onlineVolontiranje, oblasti_promocijaKultureZivljenja, oblasti_promocijaPravaManjina, oblasti_pomocUcenje, oblasti_sportskeManifestracije,"+
                                            "oblasti_pomocInvalidima, oblasti_pomocMentalnima, oblasti_pomocStarima, oblasti_pomocDrogasima, oblasti_pomocKockarima, oblasti_istrazivackiRadovi, oblasti_kancelarijskiPoslovi, oblasti_organizacioniPoslovi, oblasti_prevodjenje, oblasti_kulturaUmjetnost, oblasti_arheologija, oblasti_obnovaRekonstrukcija, oblasti_informacioneTehnologije, oblasti_muzickeManifestacije, oblasti_interkulturalnoUcenje,"+
                                            "angazman, dostupnost, obuke, motivacijaVolontera, dodatneInformacije "+
                                   "FROM clan WHERE idc="+idClana+";";
                    OleDbCommand komanda = new OleDbCommand(query, conn);
                    OleDbDataReader read = komanda.ExecuteReader();

                    // OBRADA PODATAKA PRIJE SLANJA
                    if(read.Read()){
                        // JA SAM..
                        back = new PodaciZa_NovogClana();
                        back.jasam_idc = read["idc"].ToString();
                        back.jasam_imePrezime = read["ime_prezime"].ToString();
                        back.jasam_pol = read["pol"].ToString();
                        back.jasam_rodjenje = read["datum_rodjenja"].ToString();
                        back.jasam_brojGodina = read["broj_godina"].ToString();
                        back.jasam_mjestoRodjenja = read["mjesto_rodjenja"].ToString();
                        back.jasam_adresa = read["adresa_stanovanja"].ToString();
                        back.jasam_telefon = read["kontakt_telefon"].ToString();
                        back.jasam_email = read["email"].ToString();
                        back.jasam_facebook = read["facebook"].ToString();
                        back.jasam_skype = read["skype"].ToString();
                        back.jasam_vrijemeVolontiranja = read["vrijemeVolontiranja"].ToString();
                        back.jasam_aktivan = read["status_aktivnosti"].ToString();
                        back.jesam_volonterskiSati = Convert.ToInt32(read["brojVolonterskihSati"]);
                        back.jasam_datumPopunjavanjaUpitnika = read["datumPopunjavanjaUpitnika"].ToString();
                        back.jasam_vrijemeUnosaUBazu = read["vrijemeUnosaUBazu"].ToString();

                        // STATUS ..
                        back.status_profesija = read["profesija"].ToString();
                        back.status_trenutniStatus = read["trenutni_status"].ToString();
                        back.status_pojasnjenjeStatusa = read["pojasnjenje_statusa"].ToString();
                        back.status_radnoIskustvo = read["dosadanje_radno_iskustvo"].ToString();
                        
                        // A SADA...
                        back.asada_trenutnoPohadjam = read["trenutno_pohadjam"].ToString();
                        back.asada_honorarniAngazman = read["honorarni_angazman"].ToString();
                        back.asada_hobi = read["hobi"].ToString();
                        back.asada_omiljenjeStvari = read["omiljenje_stvari"].ToString();
                        back.asada_omiljeniGradovi = read["omiljeni_gradovi"].ToString();

                        // VOLONTERSKO ISKUSTVO
                        back.viskustvo_kojaOrganizacija = read["volontirao_uOrganizaciji"].ToString();
                        back.viskustvo_trajanjeAngazmana = read["volontirao_trajanjeAngazmana"].ToString();
                        back.viskustvo_opisVolonterskihAktivnosti = read["volontirao_opisAktivnosti"].ToString();
                        back.viskustvo_kojePrilike = read["nevolontirao_uKojimPrilikama"].ToString();
                        back.viskustvo_opisNeVolonterskihAktivnosti = read["nevolontirao_kojeAktivnosti"].ToString();
                        
                        //POZNAVANJE JEZIKA
                        back.jezik_drugi_ime = read["drugiJezik_ime"].ToString();
                        back.jezik_razumijem_eng = Convert.ToInt32(read["engleski_razumijem"]);
                        back.jezik_razumijem_fra = Convert.ToInt32(read["francuski_razumijem"]);
                        back.jezik_razumijem_rus = Convert.ToInt32(read["ruski_razumijem"]);
                        back.jezik_razumijem_ita = Convert.ToInt32(read["italijanski_razumijem"]);
                        back.jezik_razumijem_spa = Convert.ToInt32(read["spanski_razumijem"]);
                        back.jezik_razumijem_ger = Convert.ToInt32(read["njemacki_razumijem"]);
                        back.jezik_razumijem_drugi = Convert.ToInt32(read["drugiJezik_razumijem"]);

                        back.jezik_pricam_eng = Convert.ToInt32(read["engleski_pricam"]);
                        back.jezik_pricam_fra = Convert.ToInt32(read["francuski_pricam"]);
                        back.jezik_pricam_rus = Convert.ToInt32(read["ruski_pricam"]);
                        back.jezik_pricam_ita = Convert.ToInt32(read["italijanski_pricam"]);
                        back.jezik_pricam_spa = Convert.ToInt32(read["spanski_pricam"]);
                        back.jezik_pricam_ger = Convert.ToInt32(read["njemacki_pricam"]);
                        back.jezik_pricam_drugi = Convert.ToInt32(read["drugiJezik_pricam"]);

                        back.jezik_pisem_eng = Convert.ToInt32(read["engleski_pisem"]);
                        back.jezik_pisem_fra = Convert.ToInt32(read["francuski_pisem"]);
                        back.jezik_pisem_rus = Convert.ToInt32(read["ruski_pisem"]);
                        back.jezik_pisem_ita = Convert.ToInt32(read["italijanski_pisem"]);
                        back.jezik_pisem_spa = Convert.ToInt32(read["spanski_pisem"]);
                        back.jezik_pisem_ger = Convert.ToInt32(read["njemacki_pisem"]);
                        back.jezik_pisem_drugi = Convert.ToInt32(read["drugiJezik_pisem"]);

                        // PODRUCJE INTERESOVANJE
                        back.podrucjeInteresovanja_jedan = read["interesovanje1"].ToString();
                        back.podrucjeInteresovanja_dva = read["interesovanje2"].ToString();
                        back.podrucjeInteresovanja_tri = read["interesovanje3"].ToString();
                    
                        // DODATNE INFORMACIJE
                        back.dodatneInformacije_angazman = read["angazman"].ToString();
                        back.dodatneInformacije_dostupnost = read["dostupnost"].ToString();
                        back.dodatneInformacije_obukaVolontera = read["obuke"].ToString();
                        back.dodatneInfo_motivacijaVolontera = read["motivacijaVolontera"].ToString();
                        back.dodatneInfo_dodatneInformacije = read["dodatneInformacije"].ToString();

                        //OBLASTI
                        back.oblasti_zastitaZdravlja = Convert.ToInt32(read["oblasti_zastitaZdravlja"]);
                        back.oblasti_akcijeNaZastitiZivotneSredine = Convert.ToInt32(read["oblasti_akcijeNaZastitiZivotneSredine"]);          
                        back.oblasti_zastitaBiljakaZivotinja = Convert.ToInt32(read["oblasti_zastitaBiljakaZivotinja"]);    
                        back.oblasti_humanitarniProgrami = Convert.ToInt32(read["oblasti_humanitarniProgrami"]);
                        back.oblasti_razvojDemokratije = Convert.ToInt32(read["oblasti_razvojDemokratije"]);
                        back.oblasti_ravnopravnostPolova = Convert.ToInt32(read["oblasti_ravnopravnostPolova"]);
                        back.oblasti_promocijaMira = Convert.ToInt32(read["oblasti_promocijaMira"]);
                        back.oblasti_internacionalniKampovi = Convert.ToInt32(read["oblasti_internacionalniKampovi"]);
                        back.oblasti_onlineVolontiranje = Convert.ToInt32(read["oblasti_onlineVolontiranje"]);
                        back.oblasti_promocijaKultureZivljenja = Convert.ToInt32(read["oblasti_promocijaKultureZivljenja"]);      
                        back.oblasti_promocijaPravaManjina = Convert.ToInt32(read["oblasti_promocijaPravaManjina"]);  
                        back.oblasti_pomocUcenju = Convert.ToInt32(read["oblasti_pomocUcenje"]);                              
                        back.oblasti_sportskeManifestacije = Convert.ToInt32(read["oblasti_sportskeManifestracije"]);  
                        back.oblasti_pruzanjePomociInvalidima = Convert.ToInt32(read["oblasti_pomocInvalidima"]);     
                        back.oblasti_pruzanjePomociMentalnim = Convert.ToInt32(read["oblasti_pomocMentalnima"]);    
                        back.oblasti_pruzanjePomociStarima = Convert.ToInt32(read["oblasti_pomocStarima"]);  
                        back.oblasti_pruzanjePomociDrogasima = Convert.ToInt32(read["oblasti_pomocDrogasima"]);    
                        back.oblasti_pruzanjePomociKockarima = Convert.ToInt32(read["oblasti_pomocKockarima"]);    
                        back.oblasti_istrazivackiProjekti = Convert.ToInt32(read["oblasti_istrazivackiRadovi"]); 
                        back.oblasti_kancelarijskiPoslovi = Convert.ToInt32(read["oblasti_kancelarijskiPoslovi"]); 
                        back.oblasti_organizacioniPoslovi = Convert.ToInt32(read["oblasti_organizacioniPoslovi"]); 
                        back.oblasti_prevodjenje = Convert.ToInt32(read["oblasti_prevodjenje"]);                              
                        back.oblasti_kulturaUmjetnost = Convert.ToInt32(read["oblasti_kulturaUmjetnost"]);
                        back.oblasti_arheologija = Convert.ToInt32(read["oblasti_arheologija"]);                              
                        back.oblasti_obnovaRekonstrukcija = Convert.ToInt32(read["oblasti_obnovaRekonstrukcija"]); 
                        back.oblasti_informacioneTehnologije = Convert.ToInt32(read["oblasti_informacioneTehnologije"]);    
                        back.oblasti_muzickeManifestacije= Convert.ToInt32(read["oblasti_muzickeManifestacije"]);
                        back.oblasti_interkulturalnoUcenje = Convert.ToInt32(read["oblasti_interkulturalnoUcenje"]);
                    }
                    close();
                } return back;
            }
        public string[] admin_backup_podaciGrupe(int indeks){
            if(connect()) return null;
            string[]back = new string[3];
            OleDbCommand komanda = new OleDbCommand("SELECT ime_grupe, opis_grupe, br_sati FROM grupa WHERE idgr="+indeks+";", conn);
            OleDbDataReader reader = komanda.ExecuteReader();
            if (!reader.Read()) return null;
            back[0] = reader[0].ToString();
            back[1] = reader[1].ToString();
            back[2] = reader[2].ToString();
            close();
            return back;
        }
        public string[] admin_backup_podaciPripadnostGrupi(int indeks){
            if(connect()) return null;
            string[]back = new string[2];
            OleDbCommand komanda = new OleDbCommand("SELECT ime_grupe, idclana FROM pripadnosti_grupi WHERE idpg="+indeks+";", conn);
            OleDbDataReader reader = komanda.ExecuteReader();
            if (!reader.Read()) return null;
            back[0] = reader[0].ToString();
            back[1] = reader[1].ToString();
            close();
            return back;
        }
        #endregion
    }
}
