using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.IO;

namespace _13___SuosikkiNimet
{
    public partial class SuosikkiForm : Form
    {
        public SuosikkiForm()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            /// Luoetaan tekstit taulukkoon, jotta niitä voidaan verrata
            string[] pojat = File.ReadAllLines("C:\\Users\\arthur\\source\\repos\\13-SuosikkiNimet\\Pojat.txt"); 
            string[] tytot = File.ReadAllLines("C:\\Users\\arthur\\source\\repos\\13-SuosikkiNimet\\Tytot.txt");
            string nimi = NimiTB.Text;
            int laskuriP = 1, laskuriT = 1;

            foreach(string p in pojat) 
            {
                if(nimi ==  p)
                {
                    VastausLB.Text = "Nimesi on " + laskuriP + "suosituimpien poikien nimien joukossa 2020";
                }
            }   laskuriP++;

            foreach (string t in tytot)
            {
                if (nimi == t)
                {
                    VastausLB.Text = "Nimesi on " + laskuriT + "suosituimpien tyttöjen nimien joukossa 2020";
                }
                laskuriT++;
            }
            if(VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimesi ei löytynyt vuonna 2020 suosituimpien nimien joukosta!";
                VastausLB.Visible = true;
            }
        }
        
    }
}
