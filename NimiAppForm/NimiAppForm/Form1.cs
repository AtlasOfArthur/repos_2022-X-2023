using System.IO;
using System.Windows.Forms;

namespace NimiAppForm
{
    public partial class Form1 : Form
    {       // Suunnitelma: Tee ensin teht‰v‰ ohjeen mukaan, sitten muuta (Tai yrit‰ muuttaa)
            //
            // Muutos:
            //  Nimet.txt tiedostosta haetaan nÌmet.
                // erotellaan onko N/M?, Opettaja/Oppilas/Lohik‰‰rme/Muu
                    // Jos opettaja/oppilas/muu, mik‰ on h‰nen lohik‰‰rmeen nimi?
                        // Jos opettaja/oppilas, mik‰ luokka
                    // Jos Lohik‰‰rme, Kenen?
        public Form1()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
                                   // Copied full path: C:\Users\arthur\source\repos\NimiAppForm\Nimet.txt
                                   // ( Jostainsyyst‰ oli tallentunut "taustalle" nimell‰ (Nimet.txt.txt)
                                   // mutta n‰kyi tiedostosijainnissa kuitenkin nimell‰ (Nimet.txt) ((Korjattu Git bashilla)) )
            string[] Nimet = File.ReadAllLines("C:\\Users\\arthur\\source\\repos\\NimiAppForm\\Nimet.txt"); 
            string nimi = NimiTB.Text;
            int nimiLaskuri = 1;
            foreach(string henkilo in Nimet)
            {
                if (nimi == henkilo)
                {
                    VastausLB.Text = "Antamasi nimi on numero " + nimiLaskuri + " ,60 nimen listassa";
                    VastausLB.Visible = true;
                }
                nimiLaskuri++;
            }
            if (VastausLB.Visible == false) 
            {
                VastausLB.Text = "hakemasi nimi ei ollut listassa!";
                VastausLB.Visible = true;
            }
        }
    }
}