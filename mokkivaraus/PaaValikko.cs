using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mokkivaraus
{
    public partial class PaaValikko : Form
    {
        public PaaValikko()
        {
            InitializeComponent();
        }

        // Käyttäjä painaa 'Poistu' painiketta, jonka jälkeen tätä
        // pyydetään varmistamaan ohjelmasta poistuminen.
        private void button_Poistu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti poistua?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        // Käyttäjä painaa 'Laskutus' painiketta, jolloin ohjelma
        // aukaisee laskutusjärjestelmän hallintaikkunan.
        Laskutus laskutusWindow = new Laskutus();
        private void button_Laskutus_Click(object sender, EventArgs e)
        {
             laskutusWindow.Show();
        }

        // Käyttäjä painaa 'Toimipaikat ja palvelut' painiketta, jolloin ohjelma
        // aukaisee hallintajärjestelmän ikkunan.
        Yllapito yllapitoWindow = new Yllapito();
        private void button_Toimipaikat_Click(object sender, EventArgs e)
        {
            yllapitoWindow.Show();
            
        }

        // Käyttäjä painaa 'Asiakastiedot' painiketta, jolloin ohjelma
        // aukaisee asiakashallintajärjestelmän ikkunan.
        Asiakastiedot asiakasTiedotWindow = new Asiakastiedot();
        private void button_Asiakastiedot_Click(object sender, EventArgs e)
        {
            asiakasTiedotWindow.Show(this);
        }

        // Käyttäjä painaa 'Varaukset' painiketta, jolloin ohjelma
        // aukaisee varaushallintajärjestelmän ikkunan.
        Varaukset varauksetWindow = new Varaukset();
        private void button_Varaukset_Click(object sender, EventArgs e)
        {
            varauksetWindow.Show(this);
        }


        // RaporttiV3
        Raportti_V3 raportti_V3Window = new Raportti_V3();
        private void button1_Click(object sender, EventArgs e)
        {
            raportti_V3Window.Show();
        }



        //Funktio, jolla siirretään asiakasID:n asiakastiedoista vaurauksiin
        public void asiakasIDSiirto(int asiakasID)
        {
            //Piiloitetaan varaukset-ikkuna tarvittaessa ja
            //aukaistaan se
            varauksetWindow.Hide();
            varauksetWindow.Show(this);
            //Ajetaan varaukset-ikkunassa asiakaan ID:llä funktio joka
            //suorittaa haun asiakkaan id:llä
            varauksetWindow.asiakkaanVaraukset(asiakasID);
        }

        //Funktio, jolla aukaistaan asiakastiedot-ikkuna varaukset ikkunasta
        public void avaaAsiakastiedot()
        {
            //Piiloitetaan asiakastiedot-ikkuna tarvittaessa ja 
            //aukaistaan se
            asiakasTiedotWindow.Hide();
            asiakasTiedotWindow.Show(this);

        }
        
    }
}
