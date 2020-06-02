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
    public partial class Form_Pomoc : Form
    {
        public Form_Pomoc()
        {
            InitializeComponent();
        }

        BazaPodataka BazaPodataka;
        private void Form_Pomoc_Load(object sender, EventArgs e)
        {
            BazaPodataka = new BazaPodataka();
            loading_panel.Location = new System.Drawing.Point(211, 119);
            string rez = BazaPodataka.pomoc_refresh();
            if (rez != "") { loading_greska.Visible = true; loading_greska.Text = rez; }
            else { loading_panel.Visible = false; loading_panel.Dispose(); citanje_sortiranjePodataka(); }
            
        }

        private void citanje_sortiranjePodataka(){
            string[] fajlovi = { "dodatne_informacije", "grupe", "novi_volonter", "pretraga" };      
            text_dodatneInfo.Text = File.ReadAllText(@"Resursi\Pomoc\" + fajlovi[0] + ".CONFIGX");      
            text_grupe.Text = File.ReadAllText(@"Resursi\Pomoc\" + fajlovi[1] + ".CONFIGX");
            text_noviVolonter.Text = File.ReadAllText(@"Resursi\Pomoc\" + fajlovi[2] + ".CONFIGX");
            text_pretragaVolontera.Text = File.ReadAllText(@"Resursi\Pomoc\" + fajlovi[3] + ".CONFIGX");
        }
    }
}
