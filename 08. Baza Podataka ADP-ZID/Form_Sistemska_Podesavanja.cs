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
    public partial class Form_Sistemska_Podesavanja : Form
    {
        public Form_Sistemska_Podesavanja()
        {
            InitializeComponent();
        }

        private void Form_Sistemska_Podesavanja_Load(object sender, EventArgs e)
        {         
            kripcija = new Kripcija();
            // KONEKCIJA
            ucitavanje_konekcija();
        }

        //
        //  KONEKCIJA
        //
        Kripcija kripcija;
        string konekcije_data;

        private void ucitavanje_konekcija()
        {
            // Preuzimanje podataka
            string[] podaci = File.ReadAllLines(@"Resursi\System\0.CONFIGX");
            // U slucaju da je Resursi\\System\\0.CONFIGX u potpunosti prazan
            if(podaci.Length==0) {
                MessageBox.Show("Greska sa fajlom! (K0)"); 
                StreamWriter w = new StreamWriter(@"Resursi\System\0.CONFIGX", false);
                w.WriteLine(kripcija.kodiraj("0"));
                w.Close();
                podaci = File.ReadAllLines(@"Resursi\System\0.CONFIGX");
            }
            konekcije_data = kripcija.dekodiraj(podaci[0]);
            veze_koristi.Text = konekcije_data;
        }
        private void veze_btn_Click(object sender, EventArgs e)
        {
            if (veze_nova.Text == "") return;
            if(MessageBox.Show("Da li ste sigurni da želite da izvršite ovu promjenu?", "Potvrda brisanja", MessageBoxButtons.OKCancel) == DialogResult.OK){
                StreamWriter w = new StreamWriter(@"Resursi\System\0.CONFIGX", false);
                w.WriteLine(kripcija.kodiraj(veze_nova.Text));
                w.Close();
                veze_nova.Text = "";
                ucitavanje_konekcija();
            }
        }



    }
}
