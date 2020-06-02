using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace _08.Baza_Podataka_ADP_ZID
{
    class BazaPodataka
    {
        SqlConnection conn;

        public string db_greska = "";

        string SYSTEM_PORUKA = "<(SYSTEM)> ";
        string SYSTEM_USER = "SYSTEM";

        public BazaPodataka(bool test = false){
            if (Home_Form.baza_konekcija != "") return;

            string put_konektor = "Resursi\\System\\0.CONFIGX";
            string put_program = System.Reflection.Assembly.GetEntryAssembly().Location;
            string []zadnji_clan = put_program.Split('\\');
            put_program = put_program.Substring(0, put_program.Length - zadnji_clan[zadnji_clan.Length-1].Length);
            
            Kripcija kripcija = new Kripcija();
            string[] podaci = File.ReadAllLines(put_program + put_konektor);
            if(podaci.Length!=1) { db_greska = "Greška sa konektorom!!"; return; }
            Home_Form.baza_konekcija = "Server=" +  kripcija.dekodiraj(podaci[0]) + ",1433;Network Library=DBMSSOCN;Initial Catalog=adpzid_baza;User Id=adpzid_user;Password=adpzid_pass;";
            

            // Test baze podatak (vraca true ako baza funkcionise)
            if(test){ connect(); close(); }
        }

        private bool connect(){
            try{
                conn = new SqlConnection(Home_Form.baza_konekcija); conn.Open();
                return false;
            }catch (Exception) { db_greska = "Greška pri konekciji sa bazom podataka!"; return true; }
        }
        private void close() { try { conn.Close(); } catch(Exception){} }

        #region Home_Page_Login

            public string homePage_login(string u, string p){
                string back = "";
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("SELECT sifra, privilegije FROM administratori WHERE username='"+u+"';", conn);
                    SqlDataReader sda = komanda.ExecuteReader();
                    if (sda.Read())
                    {
                        if (sda["sifra"].ToString() != p) back = "Pogresna sifra";
                        else back = sda["privilegije"].ToString();
                    }
                    else back = "Korisnik ne postoji!";
                    close();
                } return back;
            }

        #endregion

        #region Home_Screen

            public string[] preuzmi_napomene(){
                string [] back = {"", ""};
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("SET ROWCOUNT 8; SELECT autor, tekst FROM javne_napomene ORDER BY idjn DESC;", conn);
                    SqlDataReader reader = komanda.ExecuteReader();
                    int br = 0; while (reader.Read()){
                        if (br == 8) break; else br++;
                        back[0] += reader["autor"].ToString().Replace("\r\n", " ") + ":\r\n";
                        back[1] += reader["tekst"].ToString().Replace("\r\n", " ") + "\r\n";
                    }
                    close();
                } return back;
            }
            public void postaviNapomenu(string user, string tekst){
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("INSERT INTO javne_napomene(autor, tekst) VALUES ('" + user + "', '" + tekst + "');", conn);
                    komanda.ExecuteNonQuery();
                    close();
                }
            }
            public DataTable preuzmi_sveNapomene(){
                DataTable back = null;
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("SELECT idjn AS Indeks, autor AS Autor, datum AS Datum, tekst AS Tekst FROM javne_napomene ORDER BY idjn DESC;", conn);
                    SqlDataAdapter reader = new SqlDataAdapter(komanda);
                    back = new DataTable();  reader.Fill(back);
                    close();
                } return back;
            }
            public void izbrisiSveNapomene(string user){
                if(!connect()){
                    string q1 = "DROP TABLE dbo.javne_napomene;";
                    string q2 = "CREATE TABLE javne_napomene( idjn int primary key identity, autor varchar(20) not null, tekst varchar(300) not null, datum datetime default CURRENT_TIMESTAMP);";
                    string q3 = "INSERT INTO javne_napomene(autor, tekst) VALUES ('" + SYSTEM_USER + "', '"+SYSTEM_PORUKA+" Korisnik "+user+" izbrisao sve javne napomene!');";
                    SqlCommand komanda = new SqlCommand(q1+q2+q3, conn);
                    komanda.ExecuteNonQuery();
                    close();
                }
            }
            public void izbrisiOdredjenuNapomenu(string id){
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("DELETE FROM javne_napomene WHERE idjn='"+id+"';", conn);
                    komanda.ExecuteNonQuery();
                    close();
                }
            }

        #endregion

        #region NOVI_CLAN
            public string noviClan_dodajNovogClana(PodaciZa_NovogClana data, string user, bool postavi_novost = true){
                if (data == null) return "Greška sa poslatim podacima!";
                string back = "Nemoguća konekcija sa bazom!";
                if (!connect())
                {
                    string d1 = "INSERT INTO clan (ime_prezime, pol, datum_rodjenja, mjesto_rodjenja, kontakt_telefon, email, facebook, skype, vrijemeVolontiranja, status_aktivnosti, datumPopunjavanjaUpitnika, brojVolonterskihSati, adresa_stanovanja, broj_godina,";
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
                    
                    string o1 = "'" + data.jasam_imePrezime + "', " + "'" + data.jasam_pol + "', " + "'" + data.jasam_rodjenje + "', " + "'" + data.jasam_mjestoRodjenja + "', " + "'" + data.jasam_telefon + "', " + "'" + data.jasam_email + "', " + "'" + data.jasam_facebook + "', " + "'" + data.jasam_skype + "', " + "'" + data.jasam_vrijemeVolontiranja + "'," + "'" + data.jasam_aktivan + "'," + "'" + data.jasam_datumPopunjavanjaUpitnika + "'," + data.jesam_volonterskiSati + ',' + "'" + data.jasam_adresa + "'," + "" + data.jasam_brojGodina + ",";
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
                        SqlCommand komanda = new SqlCommand(d1+d2+d3+d4+d5+d6+d7+d8+d9+d10+d11+d12+o1+o2+o3+o4+o5+o6+o7+o8+o9+o10+o11+o12+");", conn);
                        komanda.ExecuteNonQuery();
                        if(postavi_novost){
                            komanda = new SqlCommand("INSERT INTO javne_napomene(autor, tekst) VALUES ('"+SYSTEM_USER+"', '"+SYSTEM_PORUKA+" "+user+" je dodao novog volontera: "+data.jasam_imePrezime+"');", conn);
                            komanda.ExecuteNonQuery();
                        }
                        back = "";
                    }catch (Exception) { back = "Greška. Baza je vjerovatno preopterećena. Pokušajte ponovo!";  }
                    close(); 
                } return back;
            }

            public string noviClan_modifikacijaClana(PodaciZa_NovogClana back, string user){
                string backPoruka = "Greska sa bazom;";
                if(!connect()){
                    string query = "UPDATE clan SET "+
                             "ime_prezime='"+ back.jasam_imePrezime +"'," +
                             "pol='"+ back.jasam_pol +"'," +
                             "datum_rodjenja='"+ back.jasam_rodjenje +"'," +
                             "broj_godina='"+ back.jasam_brojGodina +"'," +
                             "mjesto_rodjenja='"+ back.jasam_mjestoRodjenja +"'," +
                             "adresa_stanovanja='"+ back.jasam_adresa +"'," +
                             "kontakt_telefon='"+ back.jasam_telefon +"'," +
                             "email='"+ back.jasam_email +"'," +
                             "facebook='"+ back.jasam_facebook +"'," +
                             "skype='"+ back.jasam_skype +"'," +
                             "vrijemeVolontiranja='"+ back.jasam_vrijemeVolontiranja +"'," +
                             "status_aktivnosti='"+ back.jasam_aktivan +"'," +
                             "brojVolonterskihSati="+ back.jesam_volonterskiSati +"," + 
                             "datumPopunjavanjaUpitnika='"+ back.jasam_datumPopunjavanjaUpitnika +"'," +
                             "vrijemeUnosaUBazu='"+ back.jasam_vrijemeUnosaUBazu +"'," +

                             "profesija='"+ back.status_profesija +"'," +
                             "trenutni_status='"+ back.status_trenutniStatus +"'," +
                             "pojasnjenje_statusa='"+ back.status_pojasnjenjeStatusa +"'," +
                             "dosadanje_radno_iskustvo='"+ back.status_radnoIskustvo +"'," +

                             "trenutno_pohadjam='"+ back.asada_trenutnoPohadjam +"'," +
                             "honorarni_angazman='"+ back.asada_honorarniAngazman +"'," +
                             "hobi='"+ back.asada_hobi +"'," +
                             "omiljenje_stvari='"+ back.asada_omiljenjeStvari +"'," +
                             "omiljeni_gradovi='"+ back.asada_omiljeniGradovi +"'," +

                            // VOLONTERSKO ISKUSTVO
                             "volontirao_uOrganizaciji='"+ back.viskustvo_kojaOrganizacija +"'," +
                             "volontirao_trajanjeAngazmana='"+ back.viskustvo_trajanjeAngazmana +"'," +
                             "volontirao_opisAktivnosti='"+ back.viskustvo_opisVolonterskihAktivnosti +"'," +
                             "nevolontirao_uKojimPrilikama='"+ back.viskustvo_kojePrilike +"'," +
                             "nevolontirao_kojeAktivnosti='"+ back.viskustvo_opisNeVolonterskihAktivnosti +"'," +

                            //POZNAVANJE JEZIKA
                             "drugiJezik_ime='"+ back.jezik_drugi_ime +"'," +
                             "engleski_razumijem='"+ back.jezik_razumijem_eng +"'," + 
                             "francuski_razumijem='"+ back.jezik_razumijem_fra +"'," + 
                             "ruski_razumijem='"+ back.jezik_razumijem_rus +"'," + 
                             "italijanski_razumijem='"+ back.jezik_razumijem_ita +"'," + 
                             "spanski_razumijem='"+ back.jezik_razumijem_spa +"'," + 
                             "njemacki_razumijem='"+ back.jezik_razumijem_ger +"'," + 
                             "drugiJezik_razumijem='"+ back.jezik_razumijem_drugi +"'," + 

                             "engleski_pricam='"+ back.jezik_pricam_eng +"'," + 
                             "francuski_pricam='"+ back.jezik_pricam_fra +"'," + 
                             "ruski_pricam='"+ back.jezik_pricam_rus +"'," + 
                             "italijanski_pricam='"+ back.jezik_pricam_ita +"'," + 
                             "spanski_pricam='"+ back.jezik_pricam_spa +"'," + 
                             "njemacki_pricam='"+ back.jezik_pricam_ger +"'," + 
                             "drugiJezik_pricam='"+ back.jezik_pricam_drugi +"'," + 

                             "engleski_pisem='"+ back.jezik_pisem_eng +"'," + 
                             "francuski_pisem='"+ back.jezik_pisem_fra +"'," + 
                             "ruski_pisem='"+ back.jezik_pisem_rus +"'," + 
                             "italijanski_pisem='"+ back.jezik_pisem_ita +"'," + 
                             "spanski_pisem='"+ back.jezik_pisem_spa +"'," + 
                             "njemacki_pisem='"+ back.jezik_pisem_ger +"'," + 
                             "drugiJezik_pisem='"+ back.jezik_pisem_drugi +"'," + 

                             "interesovanje1='"+ back.podrucjeInteresovanja_jedan +"'," +
                             "interesovanje2='"+ back.podrucjeInteresovanja_dva +"'," +
                             "interesovanje3='"+ back.podrucjeInteresovanja_tri +"'," +
                    
                             "angazman='"+ back.dodatneInformacije_angazman +"'," +
                             "dostupnost='"+ back.dodatneInformacije_dostupnost +"'," +
                             "obuke='"+ back.dodatneInformacije_obukaVolontera +"'," +
                             "motivacijaVolontera='"+ back.dodatneInfo_motivacijaVolontera +"'," +
                             "dodatneInformacije='"+ back.dodatneInfo_dodatneInformacije +"'," +

                            //OBLASTI
                             "oblasti_zastitaZdravlja='"+ back.oblasti_zastitaZdravlja +"'," + 
                             "oblasti_akcijeNaZastitiZivotneSredine='"+ back.oblasti_akcijeNaZastitiZivotneSredine +"'," +           
                             "oblasti_zastitaBiljakaZivotinja='"+ back.oblasti_zastitaBiljakaZivotinja +"'," +     
                             "oblasti_humanitarniProgrami='"+ back.oblasti_humanitarniProgrami +"'," + 
                             "oblasti_razvojDemokratije='"+ back.oblasti_razvojDemokratije +"'," + 
                             "oblasti_ravnopravnostPolova='"+ back.oblasti_ravnopravnostPolova +"'," + 
                             "oblasti_promocijaMira='"+ back.oblasti_promocijaMira +"'," + 
                             "oblasti_internacionalniKampovi='"+ back.oblasti_internacionalniKampovi +"'," + 
                             "oblasti_onlineVolontiranje='"+ back.oblasti_onlineVolontiranje +"'," + 
                             "oblasti_promocijaKultureZivljenja='"+ back.oblasti_promocijaKultureZivljenja +"'," +       
                             "oblasti_promocijaPravaManjina='"+ back.oblasti_promocijaPravaManjina +"'," +   
                             "oblasti_pomocUcenje='"+ back.oblasti_pomocUcenju +"'," + 
                             "oblasti_sportskeManifestracije='"+ back.oblasti_sportskeManifestacije +"'," +   
                             "oblasti_pomocInvalidima='"+ back.oblasti_pruzanjePomociInvalidima +"'," +      
                             "oblasti_pomocMentalnima='"+ back.oblasti_pruzanjePomociMentalnim +"'," +     
                             "oblasti_pomocStarima='"+ back.oblasti_pruzanjePomociStarima +"'," +   
                             "oblasti_pomocDrogasima='"+ back.oblasti_pruzanjePomociDrogasima +"'," +     
                             "oblasti_pomocKockarima='"+ back.oblasti_pruzanjePomociKockarima +"'," +     
                             "oblasti_istrazivackiRadovi='"+ back.oblasti_istrazivackiProjekti +"'," +  
                             "oblasti_kancelarijskiPoslovi='"+ back.oblasti_kancelarijskiPoslovi +"'," +  
                             "oblasti_organizacioniPoslovi='"+ back.oblasti_organizacioniPoslovi +"'," +  
                             "oblasti_prevodjenje='"+ back.oblasti_prevodjenje +"'," + 
                             "oblasti_kulturaUmjetnost='"+ back.oblasti_kulturaUmjetnost +"'," + 
                             "oblasti_arheologija='"+ back.oblasti_arheologija +"'," + 
                             "oblasti_obnovaRekonstrukcija='"+ back.oblasti_obnovaRekonstrukcija +"'," +  
                             "oblasti_informacioneTehnologije='"+ back.oblasti_informacioneTehnologije +"'," +     
                            "oblasti_muzickeManifestacije='"+ back.oblasti_muzickeManifestacije +"'," + 
                             "oblasti_interkulturalnoUcenje='"+ back.oblasti_interkulturalnoUcenje +"'" + 
                             " WHERE idc="+back.jasam_idc+";";
                    try{
                        SqlCommand komanda = new SqlCommand(query, conn);
                        komanda.ExecuteNonQuery();
                        komanda = new SqlCommand("INSERT INTO javne_napomene(autor, tekst) VALUES ('"+SYSTEM_USER+"', '"+SYSTEM_PORUKA+" "+user+" je promijenio podatke za "+back.jasam_imePrezime+"');", conn);
                        komanda.ExecuteNonQuery();
                        backPoruka = "";
                    }  catch(Exception){backPoruka = "Greska! Mozda je baza preopterecena. Pokusajte kasnije!";}
                    close(); 
                } return backPoruka;
            }
            public string noviClan_idPoslednjeg(){
                string back = "";
                if (connect()) return "";
                SqlCommand komanda = new SqlCommand("SELECT MAX(idc) FROM clan;", conn);
                SqlDataReader reader = komanda.ExecuteReader();
                if (reader.Read()) back = reader[0].ToString();
                close();
                return back;
            }
        #endregion

        #region GRUPE
            public DataTable grupe_getAllGrupe(string pretraga = ""){
                DataTable back = null;
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("SELECT idgr AS 'Indeks', ime_grupe AS 'Ime Grupe', opis_grupe AS 'Opis Grupe', br_sati AS 'Broj sati' FROM grupa WHERE ime_grupe LIKE '%"+pretraga+"%' OR opis_grupe LIKE '%"+pretraga+"%' ORDER BY idgr DESC", conn);
                    SqlDataAdapter ada = new SqlDataAdapter(komanda);
                    back = new DataTable(); ada.Fill(back);
                    close();
                } return back;
            }
            public bool grupe_dodajNovuGrupu(string ime, string opis, string br_sati, string user, bool postaviNovost = true){
                if (!connect())
                {
                    // Provjera da li postoji grupa sa ovim imenom
                    SqlCommand komanda = new SqlCommand("SELECT ime_grupe br FROM grupa WHERE ime_grupe='"+ime+"';", conn);
                    SqlDataReader read = komanda.ExecuteReader();
                    if(read.Read()) { close(); return false; }

                    // Dodavanje grupe
                    read.Close();
                    komanda = new SqlCommand("INSERT INTO grupa(ime_grupe, opis_grupe, br_sati) VALUES ('"+ime+"', '"+opis+"'," + br_sati + ");", conn);
                    komanda.ExecuteNonQuery();
                    if(postaviNovost){
                        komanda = new SqlCommand("INSERT INTO javne_napomene(autor, tekst) VALUES ('"+SYSTEM_USER+"', '"+SYSTEM_PORUKA+" "+user+" je dodao grupu "+ime+" ');", conn);
                        komanda.ExecuteNonQuery();
                    }
                    close(); return true;
                }
                else return false;
            }
            public void grupe_izbrisiGrupu(string id, string ime, string user){
                if (!connect())
                {
                    SqlCommand komanda = new SqlCommand("DELETE FROM grupa WHERE ime_grupe='"+ime+"';", conn);
                    komanda.ExecuteNonQuery();
                    komanda = new SqlCommand("DELETE FROM pripadnosti_grupi WHERE ime_grupe='"+ime+"';", conn);
                    komanda.ExecuteNonQuery();
                    komanda = new SqlCommand("INSERT INTO javne_napomene(autor, tekst) VALUES ('"+SYSTEM_USER+"', '"+SYSTEM_PORUKA+" "+user+" je izbrisao grupu "+ime+" ');", conn);
                    komanda.ExecuteNonQuery();
                    close(); 
                }
            }

            //
            //  PREUZIMANJE PODATAKA ZA BAZU_INFO
            //
            public DataTable grupe_preuzmiClanoveGrupe(string imegrupe){
                DataTable back = null;
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("SELECT idc AS 'Indeks',   broj_godina AS 'Godine', ime_prezime AS 'Ime i prezime', kontakt_telefon AS 'Kontakt telefon', email AS 'Email', adresa_stanovanja AS 'Adresa', brojVolonterskihSati AS 'Sati', status_aktivnosti AS 'Aktivnost' FROM clan AS c, pripadnosti_grupi AS p WHERE c.idc=p.idclana AND p.ime_grupe='" + imegrupe + "';", conn);
                    SqlDataAdapter ada = new SqlDataAdapter(komanda);
                    back = new DataTable(); ada.Fill(back); 
                    close();
                } return back;
            }
            public bool grupe_modifikacijeGrupe(string ime_grupe, string opis_grupe, string username, string br_sati){
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("UPDATE grupa SET opis_grupe='"+opis_grupe+"', br_sati="+br_sati+" WHERE ime_grupe='"+ime_grupe+"';", conn);
                    komanda.ExecuteNonQuery();
                    komanda = new SqlCommand("INSERT INTO javne_napomene(autor, tekst) VALUES ('"+SYSTEM_USER+"', '"+SYSTEM_PORUKA+" Korisnik "+username+" je izmjenio opis grupe "+ime_grupe+"');", conn);
                    komanda.ExecuteNonQuery();
                    close(); return true;
                } return false;
            }
            public void grupe_brisanjeClanaIzGrupe(string ime_grupe, string id_clana){
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("DELETE FROM pripadnosti_grupi WHERE ime_grupe='"+ime_grupe+"' AND idclana='"+id_clana+"';", conn);
                    komanda.ExecuteNonQuery();
                    close();
                }
            }
        #endregion

        #region PRETRAGA
            public DataTable pretraga_unos(string unos, bool grupa = false, char akt = 's'){
                DataTable back = null;
                if (!connect())
                {
                    string baza = ""; string aktivnost = "";
                    if (akt == 'a') aktivnost = " status_aktivnosti='Aktivan' AND";
                    else if (akt == 'n') aktivnost = " status_aktivnosti='Neaktivan' AND";
                    else if (akt == 't') aktivnost = " status_aktivnosti='Tu i tamo' AND";
                    //System.Windows.Forms.MessageBox.Show(aktivnost+" aaa");

                    if (!grupa) baza = "SELECT idc AS 'Indeks', broj_godina AS 'Godine', ime_prezime AS 'Ime i prezime', kontakt_telefon AS 'Kontakt telefon', email AS 'Email', adresa_stanovanja AS 'Adresa', brojVolonterskihSati AS 'Sati', status_aktivnosti AS 'Aktivnost'  FROM clan WHERE "+aktivnost+
                                       " (ime_prezime LIKE '%" + unos + "%' OR email LIKE '%" + unos + "%' OR kontakt_telefon LIKE '%" + unos + "%' OR adresa_stanovanja LIKE '%" + unos + "%' OR profesija LIKE '%" + unos + "%' OR trenutni_status LIKE '%"+unos+"%' OR trenutno_pohadjam LIKE '%"+unos+"%' OR interesovanje1 LIKE '%"+unos+"%' OR interesovanje2 LIKE '%"+unos+"%' OR interesovanje3 LIKE '%"+unos+"%') ORDER BY ime_prezime;";
                    else {}

                    try{
                        SqlCommand komanda = new SqlCommand(baza, conn);
                        SqlDataAdapter ada = new SqlDataAdapter(komanda);
                        back = new DataTable(); ada.Fill(back);
                    } catch(Exception){}
                    close(); 
                } return back;
            }
            public DataTable pretraga_getAllGrupe(){
                DataTable back = null;
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("SELECT ime_grupe FROM grupa;", conn);
                    SqlDataAdapter ada = new SqlDataAdapter(komanda);
                    back = new DataTable(); ada.Fill(back); 
                    close();
                } return back;
            }
            public string pretraga_dodajVolonteraUGrupu(string imeGrupe, string idVolontera){
                string back = "Greska sa bazom";
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("SELECT idpg FROM pripadnosti_grupi WHERE ime_grupe='"+imeGrupe+"' AND idclana="+idVolontera+";", conn);
                    SqlDataReader read = komanda.ExecuteReader();
                    if(read.Read()) { close(); return "Volonter se vec nalazi u toj grupi"; }

                    read.Close(); komanda = new SqlCommand("INSERT INTO pripadnosti_grupi(ime_grupe, idclana) VALUES('"+imeGrupe+"', '"+idVolontera+"');", conn);
                    komanda.ExecuteNonQuery();
                    close(); back = "";
                } return back;
            }
        #endregion

        #region DOSIJE_VOLONTER
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
                    SqlCommand komanda = new SqlCommand(query, conn);
                    SqlDataReader read = komanda.ExecuteReader();

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
            public string dosije_preuzmiPodatke_SPY(){
                string back = "";
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
                                   "FROM clan;";
                    SqlCommand komanda = new SqlCommand(query, conn);
                    SqlDataReader read = komanda.ExecuteReader();

                    // OBRADA PODATAKA PRIJE SLANJA
                    while(read.Read()){
                        back += read["idc"].ToString();
                        back += "^" + read["ime_prezime"].ToString();
                        back += "^" + read["pol"].ToString();
                        back += "^" + read["datum_rodjenja"].ToString();
                        back += "^" + read["broj_godina"].ToString();
                        back += "^" + read["mjesto_rodjenja"].ToString();
                        back += "^" + read["adresa_stanovanja"].ToString();
                        back += "^" + read["kontakt_telefon"].ToString();
                        back += "^" + read["email"].ToString();
                        back += "^" + read["facebook"].ToString();
                        back += "^" + read["skype"].ToString();
                        back += "^" + read["vrijemeVolontiranja"].ToString();
                        back += "^" + read["status_aktivnosti"].ToString();
                        back += "^" + Convert.ToInt32(read["brojVolonterskihSati"]);
                        back += "^" + read["datumPopunjavanjaUpitnika"].ToString();
                        back += "^" + read["vrijemeUnosaUBazu"].ToString();

                        // STATUS ..
                        back += "^" + read["profesija"].ToString();
                        back += "^" + read["trenutni_status"].ToString();
                        back += "^" + read["pojasnjenje_statusa"].ToString();
                        back += "^" + read["dosadanje_radno_iskustvo"].ToString();
                        
                        // A SADA...
                        back += "^" + read["trenutno_pohadjam"].ToString();
                        back += "^" + read["honorarni_angazman"].ToString();
                        back += "^" + read["hobi"].ToString();
                        back += "^" + read["omiljenje_stvari"].ToString();
                        back += "^" + read["omiljeni_gradovi"].ToString();

                        // VOLONTERSKO ISKUSTVO
                        back += "^" + read["volontirao_uOrganizaciji"].ToString();
                        back += "^" + read["volontirao_trajanjeAngazmana"].ToString();
                        back += "^" + read["volontirao_opisAktivnosti"].ToString();
                        back += "^" + read["nevolontirao_uKojimPrilikama"].ToString();
                        back += "^" + read["nevolontirao_kojeAktivnosti"].ToString();
                        
                        //POZNAVANJE JEZIKA
                        back += "^" + read["drugiJezik_ime"].ToString();
                        back += "^" + Convert.ToInt32(read["engleski_razumijem"]);
                        back += "^" + Convert.ToInt32(read["francuski_razumijem"]);
                        back += "^" + Convert.ToInt32(read["ruski_razumijem"]);
                        back += "^" + Convert.ToInt32(read["italijanski_razumijem"]);
                        back += "^" + Convert.ToInt32(read["spanski_razumijem"]);
                        back += "^" + Convert.ToInt32(read["njemacki_razumijem"]);
                        back += "^" + Convert.ToInt32(read["drugiJezik_razumijem"]);

                        back += "^" + Convert.ToInt32(read["engleski_pricam"]);
                        back += "^" + Convert.ToInt32(read["francuski_pricam"]);
                        back += "^" + Convert.ToInt32(read["ruski_pricam"]);
                        back += "^" + Convert.ToInt32(read["italijanski_pricam"]);
                        back += "^" + Convert.ToInt32(read["spanski_pricam"]);
                        back += "^" + Convert.ToInt32(read["njemacki_pricam"]);
                        back += "^" + Convert.ToInt32(read["drugiJezik_pricam"]);

                        back += "^" + Convert.ToInt32(read["engleski_pisem"]);
                        back += "^" + Convert.ToInt32(read["francuski_pisem"]);
                        back += "^" + Convert.ToInt32(read["ruski_pisem"]);
                        back += "^" + Convert.ToInt32(read["italijanski_pisem"]);
                        back += "^" + Convert.ToInt32(read["spanski_pisem"]);
                        back += "^" + Convert.ToInt32(read["njemacki_pisem"]);
                        back += "^" + Convert.ToInt32(read["drugiJezik_pisem"]);

                        // PODRUCJE INTERESOVANJE
                        back += "^" + read["interesovanje1"].ToString();
                        back += "^" + read["interesovanje2"].ToString();
                        back += "^" + read["interesovanje3"].ToString();
                    
                        // DODATNE INFORMACIJE
                        back += "^" + read["angazman"].ToString();
                        back += "^" + read["dostupnost"].ToString();
                        back += "^" + read["obuke"].ToString();
                        back += "^" + read["motivacijaVolontera"].ToString();
                        back += "^" + read["dodatneInformacije"].ToString();

                        //OBLASTI
                        back += "^" + Convert.ToInt32(read["oblasti_zastitaZdravlja"]);
                        back += "^" + Convert.ToInt32(read["oblasti_akcijeNaZastitiZivotneSredine"]);          
                        back += "^" + Convert.ToInt32(read["oblasti_zastitaBiljakaZivotinja"]);    
                        back += "^" + Convert.ToInt32(read["oblasti_humanitarniProgrami"]);
                        back += "^" + Convert.ToInt32(read["oblasti_razvojDemokratije"]);
                        back += "^" + Convert.ToInt32(read["oblasti_ravnopravnostPolova"]);
                        back += "^" + Convert.ToInt32(read["oblasti_promocijaMira"]);
                        back += "^" + Convert.ToInt32(read["oblasti_internacionalniKampovi"]);
                        back += "^" + Convert.ToInt32(read["oblasti_onlineVolontiranje"]);
                        back += "^" + Convert.ToInt32(read["oblasti_promocijaKultureZivljenja"]);      
                        back += "^" + Convert.ToInt32(read["oblasti_promocijaPravaManjina"]);  
                        back += "^" + Convert.ToInt32(read["oblasti_pomocUcenje"]);                              
                        back += "^" + Convert.ToInt32(read["oblasti_sportskeManifestracije"]);  
                        back += "^" + Convert.ToInt32(read["oblasti_pomocInvalidima"]);     
                        back += "^" + Convert.ToInt32(read["oblasti_pomocMentalnima"]);    
                        back += "^" + Convert.ToInt32(read["oblasti_pomocStarima"]);  
                        back += "^" + Convert.ToInt32(read["oblasti_pomocDrogasima"]);    
                        back += "^" + Convert.ToInt32(read["oblasti_pomocKockarima"]);    
                        back += "^" + Convert.ToInt32(read["oblasti_istrazivackiRadovi"]); 
                        back += "^" + Convert.ToInt32(read["oblasti_kancelarijskiPoslovi"]); 
                        back += "^" + Convert.ToInt32(read["oblasti_organizacioniPoslovi"]); 
                        back += "^" + Convert.ToInt32(read["oblasti_prevodjenje"]);                              
                        back += "^" + Convert.ToInt32(read["oblasti_kulturaUmjetnost"]);
                        back += "^" + Convert.ToInt32(read["oblasti_arheologija"]);                              
                        back += "^" + Convert.ToInt32(read["oblasti_obnovaRekonstrukcija"]); 
                        back += "^" + Convert.ToInt32(read["oblasti_informacioneTehnologije"]);    
                        back += "^" + Convert.ToInt32(read["oblasti_muzickeManifestacije"]);
                        back += "^" + Convert.ToInt32(read["oblasti_interkulturalnoUcenje"]);
                        back += "$";
                    }
                    close();
                } return back;
            }
            public string dosije_preuzmiGrupe_SPY(){
                string back = "";
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("SELECT ime_grupe, idclana FROM pripadnosti_grupi;", conn);
                    SqlDataReader reader = komanda.ExecuteReader();
                    while(reader.Read()){
                        back +=       reader[0].ToString();
                        back += "^" + reader[1].ToString();
                        back += "$";
                    }
                    close(); 
                } return back;
            }

            public DataTable dosije_komentariGet(string idclan){
                DataTable back = null;
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("SELECT idnv AS 'Indeks', autor AS 'Autor', napomena AS 'Napomena', datum AS 'Datum' FROM napomena_volonter WHERE idclan='"+idclan+"' ORDER BY idnv DESC;", conn);
                    SqlDataAdapter ada = new SqlDataAdapter(komanda);
                    back = new DataTable(); ada.Fill(back);
                    close(); 
                } return back;
            }            
            public string dosije_komentariGet_SPY(){
                string back = "";
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("SELECT idclan, autor, napomena FROM napomena_volonter;", conn);
                    SqlDataReader reader = komanda.ExecuteReader();
                    while(reader.Read()){
                        back +=       reader[0].ToString();
                        back += "^" + reader[1].ToString();
                        back += "^" + reader[2].ToString();
                        back += "$";
                    }
                    close(); 
                } return back;
            }
            public void dosije_dodajKomentar(string user, string idclana, string napomena){
                if(!connect()){
                    napomena = napomena.Replace('\'', '"');
                    SqlCommand komanda = new SqlCommand("INSERT INTO napomena_volonter(autor, idclan, napomena) VALUES ('"+user+"', "+idclana+", '"+napomena+"');", conn);
                    komanda.ExecuteNonQuery();
                    close();
                }
            }
            public void dosije_izbrisiKomentar(string idnv){
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("DELETE FROM napomena_volonter WHERE idnv='"+idnv+"';", conn);
                    komanda.ExecuteNonQuery();
                    close();
                }
            }
            public DataTable dosije_grupeVolontera(string idclana){
                DataTable back = null;
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("SELECT ime_grupe AS 'Naziv grupe' FROM pripadnosti_grupi WHERE idclana='"+idclana+"';", conn);
                    SqlDataAdapter ada = new SqlDataAdapter(komanda);
                    back = new DataTable(); ada.Fill(back);
                    close(); 
                } return back;
            }
            public bool dosije_izbrisiVolontera(string idclana, string ime_clana, string user){
                bool back = false;
                if(!connect()){
                    SqlCommand komanda = new SqlCommand("DELETE FROM clan WHERE idc="+idclana+";", conn);
                    komanda.ExecuteNonQuery();
                    komanda = new SqlCommand("DELETE FROM pripadnosti_grupi WHERE idclana="+idclana+";", conn);
                    komanda.ExecuteNonQuery();
                    komanda = new SqlCommand("DELETE FROM napomena_volonter WHERE idclan="+idclana+";", conn);
                    komanda.ExecuteNonQuery();
                    komanda = new SqlCommand("INSERT INTO javne_napomene(autor, tekst) VALUES ('"+SYSTEM_USER+"', '"+SYSTEM_PORUKA+" Korisnik "+user+" je izbrisao volontera "+ime_clana+"!');", conn);
                    komanda.ExecuteNonQuery();
                    close();
                } return back;
            }
        #endregion

        #region STATISTIKA
            public int[] statistika_get(){
                int[] back = null;
                if (connect()) return null;
                back = new int[7];

                // Ukupan broj volontera
                SqlCommand komanda = new SqlCommand("SELECT COUNT(*) AS 'Broj' FROM clan;", conn);
                SqlDataReader reader = komanda.ExecuteReader();
                if (reader.Read()) back[0] = Convert.ToInt32(reader["Broj"]);
                reader.Close();

                // Broj muskaraca
                komanda = new SqlCommand("SELECT COUNT(*) AS 'Broj' FROM clan WHERE pol='Muski';", conn);
                reader = komanda.ExecuteReader();
                if (reader.Read()) back[1] = Convert.ToInt32(reader["Broj"]);
                reader.Close();

                // Broj zena
                komanda = new SqlCommand("SELECT COUNT(*) AS 'Broj' FROM clan WHERE pol='Zenski';", conn);
                reader = komanda.ExecuteReader();
                if (reader.Read()) back[2] = Convert.ToInt32(reader["Broj"]);
                reader.Close();

                // Broj drugih
                komanda = new SqlCommand("SELECT COUNT(*) AS 'Broj' FROM clan WHERE pol!='Zenski' AND pol!='Muski';", conn);
                reader = komanda.ExecuteReader();
                if (reader.Read()) back[3] = Convert.ToInt32(reader["Broj"]);
                reader.Close();

                // Broj aktivnih
                komanda = new SqlCommand("SELECT COUNT(*) AS 'Broj' FROM clan WHERE status_aktivnosti='Aktivan';", conn);
                reader = komanda.ExecuteReader();
                if (reader.Read()) back[4] = Convert.ToInt32(reader["Broj"]);
                reader.Close();

                // Broj neaktivnih
                komanda = new SqlCommand("SELECT COUNT(*) AS 'Broj' FROM clan WHERE status_aktivnosti='Neaktivan';", conn);
                reader = komanda.ExecuteReader();
                if (reader.Read()) back[5] = Convert.ToInt32(reader["Broj"]);
                reader.Close();

                // Broj Tu i tamo
                komanda = new SqlCommand("SELECT COUNT(*) AS 'Broj' FROM clan WHERE status_aktivnosti='Tu i tamo';", conn);
                reader = komanda.ExecuteReader();
                if (reader.Read()) back[6] = Convert.ToInt32(reader["Broj"]);
                reader.Close();

                close();
                return back;
            }
        #endregion

        #region ADMINISTRACIJA
            public string[] admin_getMemoriju(){
                if (connect()) return null;
                string[] back = new string[2];
                SqlCommand komanda = new SqlCommand("exec sp_spaceused;", conn);
                SqlDataReader reader = komanda.ExecuteReader();
                if(!reader.Read()) { close(); return null; }
                back[0] = reader[1].ToString();
                back[1] = reader[2].ToString();
                close(); return back;
            }
            public DataTable admin_getNalozi(){
                DataTable back = null;
                if (connect()) return null;
                SqlCommand komanda = new SqlCommand("SELECT username AS 'Username',  dodatne_informacije AS 'Dodatne Informacije', privilegije AS 'Privilegije' FROM administratori WHERE idad>1;", conn);
                SqlDataAdapter ada = new SqlDataAdapter(komanda);
                back = new DataTable(); ada.Fill(back);
                close();
                return back;
            }
            public string admin_dodajNalog(string user, string pass, string info, string privi){
                string back = "";
                if (connect()) return "Greska sa bazom podataka";
                SqlCommand komanda = new SqlCommand("SELECT username FROM administratori WHERE username='"+user+"';", conn);
                SqlDataReader reader = komanda.ExecuteReader();
                if(reader.Read()) { back = "Vec postoji nalog sa ovim imenom"; close(); return back; }
                reader.Close();
                komanda = new SqlCommand("INSERT INTO administratori(username, sifra, dodatne_informacije, privilegije) VALUES ('"+user+"', '"+pass+"', '"+info+"', '"+privi+"');", conn);
                komanda.ExecuteNonQuery();
                close();
                return back;
            }
            public void admin_izbrisiNalog(string user){
                if (connect()) return;
                SqlCommand komanda = new SqlCommand("DELETE FROM administratori WHERE username='"+user+"';", conn);
                komanda.ExecuteNonQuery();
                close();
            }

            // BAZA PODATAKA
            public void admin_bazaBrisanjeSvihVolontera(string user){
                if (connect()) return;
                SqlCommand komanda = new SqlCommand("IF OBJECT_ID('dbo.clan', 'U') IS NOT NULL DROP TABLE dbo.clan;" +
                    "CREATE TABLE clan( " +
                    "idc int primary key identity," +
                    "ime_prezime varchar(150) not null," +
                    "pol varchar(8)," +
                    "datum_rodjenja varchar(150) default ''," +
	                "broj_godina int default 0,"+
                    "mjesto_rodjenja varchar(100) default ''," +
                    "adresa_stanovanja varchar(100) default ''," +
                    "kontakt_telefon varchar(30) default ''," +
                    "email varchar(80) default ''," +
                    "facebook varchar(100) default ''," +
                    "skype varchar(100) default ''," +
                    "vrijemeVolontiranja text default ''," +
                    "status_aktivnosti varchar(15)," +
                    "brojVolonterskihSati int default 0," +
                    "datumPopunjavanjaUpitnika varchar(150) default ''," +
                    "vrijemeUnosaUBazu date default getdate()," +

                    "profesija varchar(150) default ''," +
                    "trenutni_status varchar(30) default ''," +
                    "pojasnjenje_statusa text default ''," +
                    "dosadanje_radno_iskustvo text default ''," +

                    "trenutno_pohadjam varchar(350) default ''," +
                    "honorarni_angazman varchar(350) default ''," +
                    "hobi varchar(150) default ''," +
                    "omiljenje_stvari text default ''," +
                    "omiljeni_gradovi text default ''," +

                    "volontirao_uOrganizaciji varchar(150) default ''," +
                    "volontirao_trajanjeAngazmana varchar(250) default ''," +
                    "volontirao_opisAktivnosti text default ''," +
                    "nevolontirao_uKojimPrilikama text default ''," +
                    "nevolontirao_kojeAktivnosti text default ''," +
                        
                    "engleski_razumijem char default '1', engleski_pricam char default '1', engleski_pisem char default '1', "+   
                    "francuski_razumijem char default '1', francuski_pricam char default '1', francuski_pisem char default '1',"+
                    "ruski_razumijem char default '1', ruski_pricam char default '1', ruski_pisem char default '1',"+
                    "italijanski_razumijem char default '1', italijanski_pricam char default '1', italijanski_pisem char default '1',"+
                    "spanski_razumijem char default '1', spanski_pricam char default '1', spanski_pisem char default '1',"+
                    "njemacki_razumijem char default '1', njemacki_pricam char default '1', njemacki_pisem char default '1',"+
                    "drugiJezik_ime varchar(20), drugiJezik_razumijem char default '1', drugiJezik_pricam char default '1', drugiJezik_pisem char default '1',"+
                        
                    "interesovanje1 varchar(150) default ''," +
                    "interesovanje2 varchar(150) default ''," +
                    "interesovanje3 varchar(150) default ''," +

                    "oblasti_zastitaZdravlja char default '1'," +
                    "oblasti_akcijeNaZastitiZivotneSredine char default '1'," +
                    "oblasti_zastitaBiljakaZivotinja char default '1'," +
                    "oblasti_humanitarniProgrami char default '1'," +
                    "oblasti_razvojDemokratije char default '1'," +
                    "oblasti_ravnopravnostPolova char default '1'," +
                    "oblasti_promocijaMira char default '1'," +
                    "oblasti_internacionalniKampovi char default '1'," +
                    "oblasti_onlineVolontiranje char default '1'," +
                    "oblasti_promocijaKultureZivljenja char default '1'," +
                    "oblasti_promocijaPravaManjina char default '1'," +
                    "oblasti_pomocUcenje char default '1'," +
                    "oblasti_sportskeManifestracije char default '1'," +
                    "oblasti_pomocInvalidima char default '1'," +
                    "oblasti_pomocMentalnima char default '1'," +
                    "oblasti_pomocStarima char default '1'," +
                    "oblasti_pomocDrogasima char default '1'," +
                    "oblasti_pomocKockarima char default '1'," +
                    "oblasti_istrazivackiRadovi char default '1'," +
                    "oblasti_kancelarijskiPoslovi char default '1'," +
                    "oblasti_organizacioniPoslovi char default '1'," +
                    "oblasti_prevodjenje char default '1'," +
                    "oblasti_kulturaUmjetnost char default '1'," +
                    "oblasti_arheologija char default '1'," +
                    "oblasti_obnovaRekonstrukcija char default '1'," +
                    "oblasti_informacioneTehnologije char default '1'," +
                    "oblasti_muzickeManifestacije char default '1'," +
                    "oblasti_interkulturalnoUcenje char default '1'," +

                    "angazman text default ''," +
                    "dostupnost text default ''," +
                    "obuke text default ''," +
                    "motivacijaVolontera text default ''," +
                    "dodatneInformacije text default '' " +
                    ");", conn);
                komanda.ExecuteNonQuery();
                komanda = new SqlCommand("IF OBJECT_ID('dbo.pripadnosti_grupi', 'U') IS NOT NULL DROP TABLE dbo.pripadnosti_grupi;"+
                                        "CREATE TABLE pripadnosti_grupi("+
	                                    "    idpg int primary key identity,"+
	                                    "    ime_grupe varchar(100) not null,"+
	                                    "    idclana int not null"+
                                        ");", conn);
                komanda.ExecuteNonQuery();
                komanda = new SqlCommand("IF OBJECT_ID('dbo.napomena_volonter', 'U') IS NOT NULL DROP TABLE dbo.napomena_volonter;"+
                                        "CREATE TABLE napomena_volonter("+
	                                    "    idnv int primary key identity,"+
	                                    "    autor varchar(20) not null,"+
	                                    "    idclan int not null,"+
	                                    "    napomena text,"+
                                        "    datum datetime default CURRENT_TIMESTAMP"+
                                        ");", conn);
                komanda.ExecuteNonQuery();
                komanda = new SqlCommand("INSERT INTO javne_napomene(autor, tekst) VALUES ('"+SYSTEM_USER+"', '"+SYSTEM_PORUKA+" Korisnik "+user+" je izbrisao sve volontere iz baze');", conn);
                komanda.ExecuteNonQuery();
                close();
            }
            public void admin_bazaBrisanjeSvihGrupa(string user){
                if (connect()) return;
                SqlCommand komanda = new SqlCommand("IF OBJECT_ID('dbo.grupa', 'U') IS NOT NULL DROP TABLE dbo.grupa;"+
                                                    "CREATE TABLE grupa("+
	                                                "    idgr int primary key identity,"+
	                                                "    ime_grupe varchar(100) not null,"+
	                                                "    br_sati int default 0,"+
	                                                "    opis_grupe text"+
                                                    ");", conn);
                komanda.ExecuteNonQuery();
                komanda = new SqlCommand("IF OBJECT_ID('dbo.pripadnosti_grupi', 'U') IS NOT NULL DROP TABLE dbo.pripadnosti_grupi;"+
                                        "CREATE TABLE pripadnosti_grupi("+
	                                    "    idpg int primary key identity,"+
	                                    "    ime_grupe varchar(100) not null,"+
	                                    "    idclana int not null"+
                                        ");", conn);
                komanda = new SqlCommand("INSERT INTO javne_napomene(autor, tekst) VALUES ('"+SYSTEM_USER+"', '"+SYSTEM_PORUKA+" Korisnik "+user+" je izbrisao sve grupe iz baze');", conn);
                komanda.ExecuteNonQuery();
                close();
            }
            public int[] admin_bazaUpdateGodina_preuzimanje(){
                if (connect()) return null;
                int[] back = null;
                SqlCommand komanda = new SqlCommand("SELECT COUNT(*) AS 'br' FROM clan;", conn);
                SqlDataReader reader = komanda.ExecuteReader();
                if (!reader.Read()) return null;

                back = new int[Convert.ToInt32(reader["br"])]; reader.Close();
                komanda = new SqlCommand("SELECT idc FROM clan;", conn);
                reader = komanda.ExecuteReader();
                for(int i = 0; i < back.Length; i++){
                    if (reader.Read()) back[i] = Convert.ToInt32(reader["idc"]);
                }
                close();
                return back;
            }
            public void admin_bazaUpdateGodina_update(int idc){
                if (connect()) return;
                SqlCommand komanda = new SqlCommand("SELECT datum_rodjenja FROM clan WHERE idc="+idc+";", conn);
                SqlDataReader reader = komanda.ExecuteReader(); if (!reader.Read()) return;
                komanda = new SqlCommand("UPDATE clan SET broj_godina="+Home_Form.racunanjeBrojaGodina(reader["datum_rodjenja"].ToString())+" WHERE idc="+idc+";", conn);
                reader.Close(); komanda.ExecuteNonQuery();
                close();
            }

            #region BACK UP
                //
                // BACKUP BAZE PODAYAKA
                //
                public int[] admin_backup_indeksiGrupa(){
                    if (connect()) return null;
                    int[] back = null;
                    SqlCommand komanda = new SqlCommand("SELECT COUNT(*) AS 'br' FROM grupa;", conn);
                    SqlDataReader reader = komanda.ExecuteReader();
                    if (!reader.Read()) return null;

                    back = new int[Convert.ToInt32(reader["br"])]; reader.Close();
                    komanda = new SqlCommand("SELECT idgr FROM grupa;", conn);
                    reader = komanda.ExecuteReader();
                    for(int i = 0; i < back.Length; i++){
                        if (reader.Read()) back[i] = Convert.ToInt32(reader["idgr"]);
                    }
                    close();
                    return back;
                }
                public int[] admin_backup_indeksiPripadnostGrupi(){
                    if (connect()) return null;
                    int[] back = null;
                    SqlCommand komanda = new SqlCommand("SELECT COUNT(*) AS 'br' FROM pripadnosti_grupi;", conn);
                    SqlDataReader reader = komanda.ExecuteReader();
                    if (!reader.Read()) return null;

                    back = new int[Convert.ToInt32(reader["br"])]; reader.Close();
                    komanda = new SqlCommand("SELECT idpg FROM pripadnosti_grupi;", conn);
                    reader = komanda.ExecuteReader();
                    for(int i = 0; i < back.Length; i++){
                        if (reader.Read()) back[i] = Convert.ToInt32(reader["idpg"]);
                    }
                    close();
                    return back;
                }
                public string[] admin_backup_podaciGrupe(int indeks){
                    if(connect()) return null;
                    string[]back = new string[4];
                    SqlCommand komanda = new SqlCommand("SELECT idgr, ime_grupe, opis_grupe, br_sati FROM grupa WHERE idgr="+indeks+";", conn);
                    SqlDataReader reader = komanda.ExecuteReader();
                    if (!reader.Read()) return null;
                    back[0] = reader[0].ToString();
                    back[1] = reader[1].ToString();
                    back[2] = reader[2].ToString();
                    back[3] = reader[3].ToString();
                    close();
                    return back;
                }
                public string[] admin_backup_podaciPripadnostGrupi(int indeks){
                    if(connect()) return null;
                    string[]back = new string[3];
                    SqlCommand komanda = new SqlCommand("SELECT idpg, ime_grupe, idclana FROM pripadnosti_grupi WHERE idpg="+indeks+";", conn);
                    SqlDataReader reader = komanda.ExecuteReader();
                    if (!reader.Read()) return null;
                    back[0] = reader[0].ToString();
                    back[1] = reader[1].ToString();
                    back[2] = reader[2].ToString();
                    close();
                    return back;
                }

            #endregion

        #endregion

        #region POMOC
            public string pomoc_refresh(){
                // PROVJERA RESURSA
                string[] fajlovi = { "data", "dodatne_informacije", "grupe", "novi_volonter", "pretraga" };
                for(int i = 0; i < fajlovi.Length; i++){
                    if (!File.Exists(@"Resursi\Pomoc\" + fajlovi[i] + ".CONFIGX")) return "Greska sa resursima. Neki od fajlova vezanih za pomoc ne postoje!";
                }
                string date = File.ReadAllLines(@"Resursi\Pomoc\data.CONFIGX")[0];
                
                if (connect()) return "Greska sa bazom";
                SqlCommand komanda = new SqlCommand("SELECT datum FROM pomoc WHERE idpom=1;", conn);
                SqlDataReader reader = komanda.ExecuteReader();
                if (!reader.Read()) { close(); return "Greska sa podacima iz baze! (datum)"; }
                if(reader["datum"].ToString() != date){
                    File.WriteAllText(@"Resursi\Pomoc\data.CONFIGX", reader["datum"].ToString());
                    reader.Close();
                    komanda = new SqlCommand("SELECT dodatne_informacije, grupe, novi_volonter, pretraga FROM pomoc WHERE idpom=1;", conn);
                    reader = komanda.ExecuteReader(); if(!reader.Read()) { close(); return "Greska sa podacima iz baze! (data)"; }
                    File.WriteAllText(@"Resursi\Pomoc\dodatne_informacije.CONFIGX", reader["dodatne_informacije"].ToString());
                    File.WriteAllText(@"Resursi\Pomoc\novi_volonter.CONFIGX", reader["novi_volonter"].ToString());
                    File.WriteAllText(@"Resursi\Pomoc\pretraga.CONFIGX", reader["pretraga"].ToString());
                    File.WriteAllText(@"Resursi\Pomoc\grupe.CONFIGX", reader["grupe"].ToString());
                }
                close();
                return "";
            }
            public bool pomoc_update(string dodatne, string grupe, string novi, string pretraga){
                if (connect()) return false;
                string unos = "";
                if(dodatne!="") unos = "dodatne_informacije='"+dodatne+"'";
                else if(grupe!="")  unos = "grupe='"+grupe+"'";
                else if(novi!="")  unos = "novi_volonter='"+novi+"'";
                else if(pretraga!="")  unos = "pretraga='"+pretraga+"'";

                SqlCommand komanda = new SqlCommand("UPDATE pomoc  SET "+unos+", datum=CURRENT_TIMESTAMP WHERE idpom=1;", conn);
                komanda.ExecuteNonQuery();
                close(); return true;
            }
        #endregion
    }
}
