using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace _08.Baza_Podataka_ADP_ZID
{
    public partial class Home_Intro : UserControl
    {
        public Home_Intro(Home_Form HS)
        {
            InitializeComponent();
            Home_Form = HS;
        }

        Home_Form Home_Form;
        string put_program = System.Reflection.Assembly.GetEntryAssembly().Location;
        BazaPodataka BazaPodataka = null;
        Kripcija Kripcija;

        private void Home_Intro_Load(object sender, EventArgs e)
        {
            string []zadnji_clan = put_program.Split('\\');
            put_program = put_program.Substring(0, put_program.Length - zadnji_clan[zadnji_clan.Length-1].Length);
            panel_login_greska.Text = "";
            start_info_notifikacije.Visible = true;
            this.Show();

            // Provjera resursa
            start_info_notifikacije.Text = "Provjera resursa...";
            string resursi = provjeraFactory();
            if (resursi != "") { start_info_notifikacije.Text += resursi; return; }
            waterMark.Visible = true;
            start_info_notifikacije.Text += "\r\nResursi su dosta dobri!\r\n";

            // Ucitaj bazu podataka
            ucitajBazu();
        }
        public void ucitajBazu(){
            start_info_notifikacije.Text = "Provjera resursa...";
            start_info_notifikacije.Text += "\r\nResursi su dosta dobri!\r\n";

            //Provjera baze podataka
            start_info_notifikacije.Text += "\r\nPovezivanje sa bazom podataka...";

            //startProg("aco228", "da");
            Home_Form.baza_konekcija = "";
            baza_konektor.RunWorkerAsync();
        }

        // KONEKCIJA SA BAZOM
        private void baza_konektor_DoWork(object sender, DoWorkEventArgs e)
        {
            BazaPodataka = new BazaPodataka(true);
        }
        private void baza_konektor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (BazaPodataka.db_greska != "") { 
                start_info_notifikacije.Text += "\r\nGREŠKA!\n\r" + BazaPodataka.db_greska + "\r\nPokušajte kasnije!"; 
            } else {
                panel_login.Location = new System.Drawing.Point(313,113);
                panel_login.Visible = true;
            }
        }
        
        private void startProg(string user, string privilegije){
            Home_Form.ucitajStranicu(user, privilegije);
            this.Dispose();
        }


        #region PROVERA RESURSA

            string []resursi_linkovi = 
            {
                "System\\0.CONFIGX"
            };

            private string provjeraFactory(){
                string back = "";
                for (int i = 0; i < resursi_linkovi.Length; i++){
                    if (!File.Exists(put_program + "\\Resursi\\" + resursi_linkovi[i])) {
                        back = "\r\nGreška sa resursima\r\nSledeći fajl ne postoji: " + resursi_linkovi[i] + "\r\nProgram ne može da se startuje. Ćao!";
                        break;
                    }
                } // for
                return back;
            }// provjeraFactory

        #endregion

        // LOGIN 
        private void pictureBox1_Click(object sender, EventArgs e) { login_Klik(); }
        private void login_Klik(){
            if(login_username.Text == "") panel_login_greska.Text = "Niste upisali korisnicko ime!";
            else if(login_pass.Text == "") panel_login_greska.Text = "Niste upisali sifru!";
            else {
                panel_login_greska.Text = "Sacekajte....";
                string login = BazaPodataka.homePage_login(login_username.Text, login_pass.Text);
                if (login != "da" && login!="ne") panel_login_greska.Text = login;
                else startProg(login_username.Text, login);
            }
        }

        private void login_pass_KeyDown(object sender, KeyEventArgs e) {if (e.KeyCode == Keys.Enter) login_Klik(); }

        //
        // SISTEMSKA PODESAVANJA
        //
        private void waterMark_Click(object sender, EventArgs e)
        {
            Form_Sistemska_Podesavanja FSP = new Form_Sistemska_Podesavanja();
            FSP.ShowDialog();
        }
        
    }
}
