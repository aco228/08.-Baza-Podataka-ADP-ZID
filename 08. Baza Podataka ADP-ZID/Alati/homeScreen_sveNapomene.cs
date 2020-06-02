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
    public partial class homeScreen_sveNapomene : Form
    {
        public homeScreen_sveNapomene(string u)
        {
            InitializeComponent();
            userName = u;
        }
        BazaPodataka BazaPodataka;
        string userName = "";

        private void homeScreen_sveNapomene_Load(object sender, EventArgs e)
        {
            BazaPodataka = new BazaPodataka();
            this.Show(); Application.DoEvents();
            ucitajNapomene();
        }

        private void ucitajNapomene(){
            DataTable dt = BazaPodataka.preuzmi_sveNapomene();
            if(dt != null) {
                dataNapomene.DataSource = dt;
                DataGridViewColumn kolona = dataNapomene.Columns[0]; kolona.Width = 50;
                kolona = dataNapomene.Columns[1]; kolona.Width = 70;
                kolona = dataNapomene.Columns[2]; kolona.Width = 90;
            }
        }

        private void btn_izbrisiSve_Click(object sender, EventArgs e){
            if(Home_Form.userPRI!="da"){MessageBox.Show("Nemate privilegije!"); return; }
            if(MessageBox.Show("Da li ste sigurni da zelite da izbrisete sve poruke?", "Potvrda brisanja", MessageBoxButtons.OKCancel) == DialogResult.OK){
                BazaPodataka.izbrisiSveNapomene(userName);
                ucitajNapomene();
            }
        }

        private void btn_izbrisiSelektovan_Click(object sender, EventArgs e){
            if(Home_Form.userPRI!="da"){MessageBox.Show("Nemate privilegije!"); return; }
            if(MessageBox.Show("Da li ste sigurni da zelite da izbrisete porukue:\r\n\"" + dataNapomene.SelectedRows[0].Cells[3].Value.ToString() + "\"", "Potvrda brisanja", MessageBoxButtons.OKCancel) == DialogResult.OK){
                BazaPodataka.izbrisiOdredjenuNapomenu(dataNapomene.SelectedRows[0].Cells[0].Value.ToString());
                ucitajNapomene();
            }
        }

    }
}
