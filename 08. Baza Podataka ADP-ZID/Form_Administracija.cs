using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _08.Baza_Podataka_ADP_ZID
{
    public partial class Form_Administracija : Form
    {
        public Form_Administracija(Home_Form HF)
        {
            InitializeComponent();
            Home_Form = HF;
        }

        BazaPodataka BazaPodataka;
        Home_Form Home_Form;
        private void Form_Administracija_Load(object sender, EventArgs e)
        {
            admin_status.Text = "Ulogovani ste kao '"+Home_Form.userName+"'";
            pozadinskaSlika_load();
            if(Home_Form.userPRI=="da"){
                BazaPodataka = new BazaPodataka();
                loadAdmini();
                pomoc_ucitavanje();
                if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Resursi\\Backup\\")) bazaLoad();
                else tabControl.TabPages.Remove(tab_bazaPodataka);
            } else {
                tabControl.TabPages.Remove(tab_nalozi);
                tabControl.TabPages.Remove(tab_bazaPodataka);
                tabControl.TabPages.Remove(tab_PomocDodatne);
                tabControl.TabPages.Remove(tab_PomocGrupe);
                tabControl.TabPages.Remove(tab_PomocNovi);
                tabControl.TabPages.Remove(tab_PomocPretraga);
            }
        }

        private void loadAdmini(){
            DataTable dt = BazaPodataka.admin_getNalozi();
            if(dt==null){}
            admin_data.DataSource = dt;
        }

        private void admin_btnDell_Click(object sender, EventArgs e)
        {
            if (admin_data.SelectedRows[0].Cells[0].Value.ToString() == Home_Form.userName) return;
             if(MessageBox.Show("Da li ste sigurni da zelite da izbrisete nalog:\r\n\"" + admin_data.SelectedRows[0].Cells[0].Value.ToString() + "\"", "Potvrda brisanja", MessageBoxButtons.OKCancel) == DialogResult.OK)
             {
                 BazaPodataka.admin_izbrisiNalog(admin_data.SelectedRows[0].Cells[0].Value.ToString());
                 loadAdmini();
             }
        }
        private void admin_btnAdd_Click(object sender, EventArgs e)
        {
            if(admin_user.Text == "") {admin_error.Text = "Niste upisali username"; return; }
            if(admin_pass.Text == "") {admin_error.Text = "Niste upisali sifru"; return; }
            string privilegije = "ne"; if (admin_privilegije.Checked) privilegije = "da";
            string rezultat = BazaPodataka.admin_dodajNalog(admin_user.Text, admin_pass.Text, admin_info.Text, privilegije);
            if (rezultat != "") { admin_error.Text = rezultat; return; }
            loadAdmini();
            admin_user.Text = ""; admin_pass.Text = ""; admin_info.Text = ""; admin_privilegije.Checked = false;
        }

        #region POMOC SEKCIJA
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //
        // POMOC SEKCIJA
        //
        private void pomoc_ucitavanje()
        {
            string[] fajlovi = { "dodatne_informacije", "grupe", "novi_volonter", "pretraga" };   
            if(BazaPodataka.pomoc_refresh()!=""){
                btn_pomocPretraga.Enabled = false;
                pomoc_btnGrupe.Enabled = false;
                pomoc_btnNoviVolonter.Enabled = false;
                pomoc_btnDodatneInfo.Enabled = false;
                return;
            }
            pomoc_dodatneInformacije.Text = File.ReadAllText(@"Resursi\Pomoc\" + fajlovi[0] + ".CONFIGX");
            pomoc_grupe.Text = File.ReadAllText(@"Resursi\Pomoc\" + fajlovi[1] + ".CONFIGX");
            pomoc_noviVolonter.Text = File.ReadAllText(@"Resursi\Pomoc\" + fajlovi[2] + ".CONFIGX");
            pomoc_pretragaVolontera.Text = File.ReadAllText(@"Resursi\Pomoc\" + fajlovi[3] + ".CONFIGX");
        }
        private void btn_pomocPretraga_Click(object sender, EventArgs e)
        {
            if (!BazaPodataka.pomoc_update("", "", "", pomoc_pretragaVolontera.Text)) MessageBox.Show("Greska sa bazom. Pokusajte ponovo");
            else MessageBox.Show("Promjena izvrsena");
        }
        private void pomoc_btnGrupe_Click(object sender, EventArgs e)
        {
            if (!BazaPodataka.pomoc_update("", pomoc_grupe.Text, "", "")) MessageBox.Show("Greska sa bazom. Pokusajte ponovo");
            else MessageBox.Show("Promjena izvrsena");
        }
        private void pomoc_btnNoviVolonter_Click(object sender, EventArgs e)
        {
            if (!BazaPodataka.pomoc_update("", "", pomoc_noviVolonter.Text, "")) MessageBox.Show("Greska sa bazom. Pokusajte ponovo");
            else MessageBox.Show("Promjena izvrsena");
        }
        private void pomoc_btnDodatneInfo_Click(object sender, EventArgs e)
        {
            if (!BazaPodataka.pomoc_update(pomoc_dodatneInformacije.Text, "", "", "")) MessageBox.Show("Greska sa bazom. Pokusajte ponovo");
            else MessageBox.Show("Promjena izvrsena");
        }
        #endregion

        #region POZADINSKA SLIKA
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //
        //  POZADINSKA SLIKA
        //
        string boje_pozadina;
        string boje_adresaSlike;
        private void pozadinskaSlika_load(){
            string put = System.Reflection.Assembly.GetEntryAssembly().Location;
            string []zadnji_clan = put.Split('\\');
            put = put.Substring(0, put.Length - zadnji_clan[zadnji_clan.Length-1].Length);
            string[] podaci = File.ReadAllLines(put + "\\Resursi\\System\\1.CONFIGX");
            
            if(podaci.Length==2){
                boje_adresaSlike = podaci[0];
                boje_promjeniSliku();

                boje_pozadina = podaci[1];
                boje_promjeniPozadinu();
            }

            //BOJE KLIK
            this.boje_crvena.Click += new System.EventHandler(this.boje_klik);
            this.boje_plava.Click += new System.EventHandler(this.boje_klik);
            this.boje_ljubicasta.Click += new System.EventHandler(this.boje_klik);
            this.boje_zelena.Click += new System.EventHandler(this.boje_klik);
            this.boje_zuta.Click += new System.EventHandler(this.boje_klik);
        }
        private void boje_promjeniPozadinu(){
            switch(boje_pozadina){
                   case "crvena": boje_picture.BackColor = Color.FromArgb(105, 51, 51); break;
                   case "ljubicasta": boje_picture.BackColor = Color.FromArgb(105, 51, 102); break;
                   case "plava": boje_picture.BackColor = Color.FromArgb(51, 56, 105); break;
                   case "zelena": boje_picture.BackColor = Color.FromArgb(56, 105, 51); break;
                   case "zuta": boje_picture.BackColor = Color.FromArgb(105, 104, 51); break;
               }
        }
        private void boje_promjeniSliku(){
            try{  boje_picture.Image = new Bitmap(boje_adresaSlike);}
            catch (Exception) { boje_picture.Image = null;  }
        }
        private void boje_klik(object sender, EventArgs e){
            var poslao = (Label)sender;
            boje_pozadina = poslao.Text;
            boje_promjeniPozadinu();
        }

        // izbrisi sliku
        private void boje_izbrisiSliku_Click(object sender, EventArgs e)
        {
            boje_adresaSlike = "";
            boje_promjeniSliku();
        }
        // postavi sliku
        private void boje_pronadji_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                boje_adresaSlike = ofd.FileName;
                boje_promjeniSliku();
            }
        }
        //potvrda
        private void boje_potvrdi_Click(object sender, EventArgs e)
        {
            StreamWriter w = new StreamWriter(@"Resursi\System\1.CONFIGX", false);
            w.WriteLine(boje_adresaSlike);
            w.WriteLine(boje_pozadina);
            w.Close();
            //MessageBox.Show("Promjena sačuvana. Restartujte aplikaciju!");
            Home_Form.ucitaj_backgroundSlika();
        }
        #endregion

        #region BAZA PODATAKA
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //
        // BAZA PODATAKA
        //

        // POSTOJECA BAAZA PODATAKA 
        private void baza_brisanjeVolontera_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Da li ste sigurni da želite da izbrišete sve volontere", "Potvrda brisanja", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK){
                BazaPodataka.admin_bazaBrisanjeSvihVolontera(Home_Form.userName);
                MessageBox.Show("Svi volonteri su izbrisani!");
            }
        }
        private void baza_brisanjeGrupa_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Da li ste sigurni da želite da izbrišete sve grupe", "Potvrda brisanja", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK){
                BazaPodataka.admin_bazaBrisanjeSvihGrupa(Home_Form.userName);
                MessageBox.Show("Sve grupe su izbrisane!");
            }
        }
        int[] baza_update_indeksi = null;
        private void baza_updateGodina_Click(object sender, EventArgs e)
        {
            baza_update_indeksi = BazaPodataka.admin_bazaUpdateGodina_preuzimanje();
            if (baza_update_indeksi == null) return;
            baza_updateGodina.Text = "Obrada " + baza_update_indeksi.Length + " volontera...";
            baza_updateGodina_loader.Visible = true; 
            baza_updateGodina_loader.Maximum = baza_update_indeksi.Length;
            baza_updateGodina.Enabled = false;
            baza_worker_updateGodina.RunWorkerAsync();
        }        
        private void baza_worker_updateGodina_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 0; i < baza_update_indeksi.Length; i++){
                BazaPodataka.admin_bazaUpdateGodina_update(baza_update_indeksi[i]);
                baza_worker_updateGodina.ReportProgress(i);
            }
        }
        private void baza_worker_updateGodina_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            baza_updateGodina_loader.Value = e.ProgressPercentage;
        }
        private void baza_worker_updateGodina_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            baza_updateGodina.Text = "Update godina volontera";
            baza_updateGodina.Enabled = true;
            baza_updateGodina_loader.Visible = false;
            MessageBox.Show("Godine volontera su updejtovane!");
        }

        // PREUZIMANJE STARE BAZE PODATAKA
        BazaPodataka_Stara BazaPodataka_Stara;
        int[] baza_stara_indeksi = null;
        private void baza_stara_ucitaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Microsoft Access Baza podataka (*.mdb)|*.mdb";
            if(ofd.ShowDialog()== DialogResult.OK){
                BazaPodataka_Stara = new BazaPodataka_Stara(ofd.FileName);
                if(!BazaPodataka_Stara.pokusaj_konekciju()){ // Provjera konekcije sa starom bazom
                    // Stara baza je okej
                    baza_stara_info.Text = "Pruzimanje podataka iz baze. Sačekajte....";
                    baza_stara_info.Visible = true;
                    baza_stara_indeksi = BazaPodataka_Stara.preuzimanjeIndeksa();

                    if(baza_stara_indeksi==null){ // Preuzimanje indeksa iz stare baze
                        MessageBox.Show("Greška sa preuzimanjem podataka iz baze!");
                        BazaPodataka_Stara = null;
                        baza_stara_info.Visible = false;
                    } else {
                        baza_stara_info.Text = "U selektovanoj bazi nalazi se "+baza_stara_indeksi.Length+" volontera. Volonteri će biti nadodati na postojeću bazu";
                        baza_stara_loader.Visible = true; baza_stara_loader.Maximum = baza_stara_indeksi.Length;
                        baza_stara_preuzmi.Visible = true;
                        baza_stara_ponisti.Visible = true;
                        baza_stara_ucitaj.Enabled = false;
                    }
                } else {
                    // greska sa bazom
                    BazaPodataka_Stara = null;
                    MessageBox.Show("Nemoguće se konektovati na dostavljenu bazu!");
                }
            } // otvaranje fajla
        }

        #region SPY MEhANIZAM
        private void baza_NSA_ucitaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Tekst fajl (*.txt)|*.txt";
            if(ofd.ShowDialog()== DialogResult.OK){
                string[] data = spy_removeNull(File.ReadAllText(ofd.FileName).Split('~'));

                spy_unos = data[0];
                spy_napomene = spy_pripremaNapomena(data[1]);
                spy_grupe = spy_pripremaGrupa(data[2]);
                data = null;
                baza_NSA_ucitaj.Enabled = false;
                spy_work.RunWorkerAsync();
            }
        }
        string spy_unos;
        string[,] spy_napomene;
        string[,] spy_grupe;
        int spy_length;
        private void spy_work_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] podaci = spy_removeNull(spy_unos.Split('$'));
            testStampa(podaci);
            spy_length = podaci.Length - 1;
            for (int i = 0; i < podaci.Length-1; i++){
                string[] slanje_data = spy_removeNull(podaci[i].Split('^'));
                BazaPodataka.noviClan_dodajNovogClana(new PodaciZa_NovogClana(slanje_data), "", false);
                string id = BazaPodataka.noviClan_idPoslednjeg();

                // Dodavanje napomena
                for(int j = 0; j < spy_napomene.Length/4; j++){
                    if (slanje_data[0] == spy_napomene[j, 0]) {
                        BazaPodataka.dosije_dodajKomentar(spy_napomene[j, 1], id, spy_napomene[j, 2]);
                    }
                }
                //Dodavanje grupa
                for(int j = 0; j < spy_grupe.Length/2; j++){
                    if (slanje_data[0] == spy_grupe[j, 1]) {
                        BazaPodataka.pretraga_dodajVolonteraUGrupu(spy_grupe[j, 0], id);
                    }
                }
                spy_work.ReportProgress(i);
            }

        }
        private void spy_work_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            baza_NSA_ucitaj.Text = e.ProgressPercentage + " / " + spy_length;
        }
        private void spy_work_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            spy_unos = null;
            spy_napomene = null;
            spy_grupe = null;
            baza_NSA_ucitaj.Enabled = true;
            MessageBox.Show("Ubaceni rezultati");
        }
        private string[] spy_removeNull(string[] unos)
        {
            for (int i = 0; i < unos.Length; i++) if (unos[i] == null) unos[i] = " ";
            return unos;
        }
        private string [,] spy_pripremaNapomena(string unos){
            if (unos == " " || unos == null) return null;
            string[] podaci = spy_removeNull(unos.Split('$'));
            string[,] back = new string[podaci.Length,3];
            for(int i=0; i < podaci.Length-1; i++){
                string []data = spy_removeNull(podaci[i].Split('^'));
                back[i,0] = data[0];
                back[i,1] = data[1];
                back[i,2] = data[2];
            }
            return back;
        }
        private string [,] spy_pripremaGrupa(string unos){
            if (unos == " " || unos == null) return null;
            string[] podaci = spy_removeNull(unos.Split('$'));
            string[,] back = new string[podaci.Length,2];
            for(int i=0; i < podaci.Length-1; i++){
                string []data = spy_removeNull(podaci[i].Split('^'));
                back[i,0] = data[0];
                back[i,1] = data[1];
            }
            return back;
        }

        private void testStampa(string[]unos)
        {
            TextWriter w = File.CreateText("test.txt");
            for(int i = 0; i < unos.Length-1; i++){
                w.WriteLine(unos[i].Split('^')[1]);
            } w.Close();
        }
        #endregion

        private void baza_stara_preuzmi_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Volonteri iz ove baze će biti nadodati na postojeću bazu podataka!", "Čisto da se zna", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK){
                    baza_staraBaza.RunWorkerAsync();
            }
        }

        private void baza_stara_ponisti_Click(object sender, EventArgs e)
        {
            baza_stara_indeksi = null; BazaPodataka_Stara = null;
            baza_stara_info.Visible = false;
            baza_stara_loader.Visible = false;
            baza_stara_preuzmi.Visible = false;
            baza_stara_ponisti.Visible = false;
            baza_stara_ucitaj.Enabled = true;
        }

        private void baza_staraBaza_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 0; i < baza_stara_indeksi.Length; i++){
                BazaPodataka.noviClan_dodajNovogClana(BazaPodataka_Stara.preuzmiClana(baza_stara_indeksi[i]), Home_Form.userName, false);
                baza_staraBaza.ReportProgress(i);
            }
        }
        private void baza_staraBaza_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Volonteri iz stare baze su ubačeni u postojeću bazu!");
            baza_stara_indeksi = null; BazaPodataka_Stara = null;
            baza_stara_info.Visible = false;
            baza_stara_loader.Visible = false;
            baza_stara_preuzmi.Visible = false;
            baza_stara_ponisti.Visible = false;
            baza_stara_ucitaj.Enabled = true;
        }

        private void baza_staraBaza_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            baza_stara_loader.Value = e.ProgressPercentage;
        }
        #endregion

        #region BACKUP
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        //
        //  BACKUP
        //
        private void bazaLoad(){
            string[] memorija = BazaPodataka.admin_getMemoriju();
            memorija_ukupno.Text = memorija[0];
            memorija_nealocirano.Text = memorija[1];
        }
        BazaPodataka_Backup BazaBackUp;
        private void backup_novi_Click(object sender, EventArgs e) {backup_kreirajBazu_ucitaj();}
        private void backup_kreirajBazu_ucitaj(){
            backup_novi.Enabled = false; 
            BazaBackUp = new BazaPodataka_Backup();
            BazaBackUp.kreiraj_novuBazu();
            backupIndeksi_clanovi = BazaPodataka.admin_bazaUpdateGodina_preuzimanje();
            backupIndeksi_grupe = BazaPodataka.admin_backup_indeksiGrupa();
            backupIndeksi_pripadnostGrupama = BazaPodataka.admin_backup_indeksiPripadnostGrupi();
            backup_kreirajBazu_loader.Visible = true;
            backup_kreirajBazu_loader.Maximum = backupIndeksi_clanovi.Length + backupIndeksi_grupe.Length + backupIndeksi_pripadnostGrupama.Length;
            backup_kreirajBazu.RunWorkerAsync();
        }
        // KREIRAJ BAZU
        int[] backupIndeksi_clanovi;
        int[] backupIndeksi_grupe;
        int[] backupIndeksi_pripadnostGrupama;
        private void backup_kreirajBazu_DoWork(object sender, DoWorkEventArgs e)
        {
            int broj = 0;
            for(int i = 0; i < backupIndeksi_clanovi.Length; i++){
                BazaBackUp.noviClan_dodajNovogClana(BazaPodataka.dosije_preuzmiPodatke(backupIndeksi_clanovi[i].ToString()));
                backup_kreirajBazu.ReportProgress(broj); broj++;
            }
            for(int i = 0; i < backupIndeksi_grupe.Length; i++){
                string []data = BazaPodataka.admin_backup_podaciGrupe(backupIndeksi_grupe[i]);
                BazaBackUp.grupe_dodajNovuGrupu(data[0], data[1], data[2], data[3]);
                backup_kreirajBazu.ReportProgress(broj); broj++;
            }
            for(int i = 0; i < backupIndeksi_pripadnostGrupama.Length; i++){
                string []data = BazaPodataka.admin_backup_podaciPripadnostGrupi(backupIndeksi_pripadnostGrupama[i]);
                BazaBackUp.pretraga_dodajVolonteraUGrupu(data[0], data[1], data[2]);
                backup_kreirajBazu.ReportProgress(broj); broj++;
            }
        }
        private void backup_kreirajBazu_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            backup_kreirajBazu_loader.Value = e.ProgressPercentage;
        }
        private void backup_kreirajBazu_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backupIndeksi_clanovi = null;
            backupIndeksi_grupe = null;
            backupIndeksi_pripadnostGrupama = null;
            backup_kreirajBazu_loader.Visible = false;
            backup_novi.Enabled = true; 
            MessageBox.Show("Baza je kreirana!\r\n\r\nLokacija baze:\r\n" + BazaBackUp.lokacijaFajla + "\r\n\r\nIme fajla: " + BazaBackUp.imeFajla);
            BazaBackUp = null;
        }

        //
        // UCITAJ BAZU
        //
        private void backup_ucitaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Microsoft Access Baza podataka (*.mdb)|*.mdb";
            ofd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Resursi\\Backup\\bazaBackup";
            if(ofd.ShowDialog()== DialogResult.OK){
                BazaBackUp = new BazaPodataka_Backup(ofd.FileName);
                if (!BazaBackUp.tryConnect()) { MessageBox.Show("Greška sa bazom. Loša konekcija!"); BazaBackUp = null; return; }

                backUpUcitavanje_clanovi_indeksi = BazaBackUp.preuzimanjeIndeksa_clanova();
                backUpUcitavanje_grupe_indeksi = BazaBackUp.preuzimanjeIndeksa_grupa();
                if(MessageBox.Show("Na postojeću bazu biće nadodato " + backUpUcitavanje_clanovi_indeksi.Length + " volontera. Da li ste sigurni da to želite da uradite?", "Potvrda", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK){
                    backup_ucitajBazu_loader.Visible = true;
                    backup_ucitajBazu_loader.Maximum = backUpUcitavanje_clanovi_indeksi.Length + backUpUcitavanje_grupe_indeksi.Length;
                    backup_ucitaj.Enabled = false;
                    baza_ucitajBazu.RunWorkerAsync();
                } else {backUpUcitavanje_clanovi_indeksi = null; backUpUcitavanje_grupe_indeksi = null; BazaBackUp = null; }
            }
        }
        int[] backUpUcitavanje_clanovi_indeksi;
        int[] backUpUcitavanje_grupe_indeksi;
        int[] backUpUcitavanje_pripadnost_indeksi;
        private void baza_ucitajBazu_DoWork(object sender, DoWorkEventArgs e)
        {
            int broj = 0;
            for(int i = 0; i < backUpUcitavanje_clanovi_indeksi.Length; i++){
                BazaPodataka.noviClan_dodajNovogClana(BazaBackUp.dosije_preuzmiPodatke(backUpUcitavanje_clanovi_indeksi[i].ToString()), "", false);
                baza_ucitajBazu.ReportProgress(broj); broj++;
            }
            for(int i = 0; i < backUpUcitavanje_grupe_indeksi.Length; i++){
                // Dodavanje grupe
                string[] data = BazaBackUp.admin_backup_podaciGrupe(backUpUcitavanje_grupe_indeksi[i]);
                if(BazaPodataka.grupe_dodajNovuGrupu(data[0], data[1], data[2], "SYSTEM", false)){

                    // Dodavanje clanova te grupe
                    backUpUcitavanje_pripadnost_indeksi = BazaBackUp.preuzimanjeIndeksa_pripadnost(data[0]);
                    for(int j = 0; j < backUpUcitavanje_pripadnost_indeksi.Length; j++){
                        string[] dataPripadnost = BazaBackUp.admin_backup_podaciPripadnostGrupi(backUpUcitavanje_pripadnost_indeksi[i]);
                        BazaPodataka.pretraga_dodajVolonteraUGrupu(dataPripadnost[0], dataPripadnost[2]);
                    }
                    backUpUcitavanje_pripadnost_indeksi = null;
                } 
                baza_ucitajBazu.ReportProgress(broj); broj++;
            }
        }
        private void baza_ucitajBazu_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            backup_ucitajBazu_loader.Value = e.ProgressPercentage;
        }
        private void baza_ucitajBazu_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Podaci iz selektovanog backupa su učitani u bazu!");
            backup_ucitajBazu_loader.Visible = false;
            backUpUcitavanje_clanovi_indeksi = null; backUpUcitavanje_grupe_indeksi = null; BazaBackUp = null; 
            backup_ucitaj.Enabled = true;
        }

        
        private void backup_otvoriFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", AppDomain.CurrentDomain.BaseDirectory + "Resursi\\Backup\\");
        }
        #endregion








    }
}
