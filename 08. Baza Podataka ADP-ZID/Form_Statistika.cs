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
    public partial class Form_Statistika : Form
    {
        public Form_Statistika()
        {
            InitializeComponent();
        }

        BazaPodataka BazaPodataka;
        int[] rezultati = null;

        private void Form_Statistika_Load(object sender, EventArgs e)
        {
            BazaPodataka = new BazaPodataka();
            rezultati = BazaPodataka.statistika_get();
            if (rezultati == null) { MessageBox.Show("Greska sa prikupljanjem podataka"); this.Dispose(); }

            ukupanBroj.Text = rezultati[0].ToString();
            aktivniBr.Text = rezultati[4].ToString();
            neaktivniBr.Text = rezultati[5].ToString();
            tuitamoBr.Text = rezultati[6].ToString();
            muskarciBr.Text = rezultati[1].ToString();
            zeneBr.Text = rezultati[2].ToString();
            drugiBr.Text = rezultati[3].ToString();

            int prazniBroj = rezultati[0] - (rezultati[1] + rezultati[2] + rezultati[3]);
            prazniBr.Text = prazniBroj.ToString();

            double procent;
            procent = Math.Round(((rezultati[4]*1.0) / (rezultati[0]*1.0)) * 100, 2);
            aktivniPro.Text = procent + "%";
            procent = Math.Round(((rezultati[5]*1.0) / (rezultati[0]*1.0)) * 100, 2);
            neaktivniPro.Text = procent + "%";
            procent = Math.Round(((rezultati[6]*1.0) / (rezultati[0]*1.0)) * 100, 2);
            tuitamoPro.Text = procent + "%";
            
            procent = Math.Round(((rezultati[1]*1.0) / (rezultati[0]*1.0)) * 100, 2);
            muskarciPro.Text = procent + "%";
            procent = Math.Round(((rezultati[2]*1.0) / (rezultati[0]*1.0)) * 100, 2);
            zenePro.Text = procent + "%";
            procent = Math.Round(((rezultati[3]*1.0) / (rezultati[0]*1.0)) * 100, 2);
            drugiPro.Text = procent + "%";
            procent = Math.Round(((prazniBroj*1.0) / (rezultati[0]*1.0)) * 100, 2);
            prazniPro.Text = procent + "%";
        }
    }
}
