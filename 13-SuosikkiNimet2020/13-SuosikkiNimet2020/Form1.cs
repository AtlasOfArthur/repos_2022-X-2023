namespace _13_SuosikkiNimet2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            /// Luoetaan tekstit taulukkoon, jotta niit� voidaan verrata
            string[] pojat = File.ReadAllLines("C:\\Users\\arthur\\source\\repos\\13-SuosikkiNimet2020\\pojat.txt");
                                                   /// C:\Users\arthur\source\repos\13-SuosikkiNimet2020\pojat.txt
            string[] tytot = File.ReadAllLines("C:\\Users\\arthur\\source\\repos\\13-SuosikkiNimet2020\\tytot.txt");
                                                   /// C:\Users\arthur\source\repos\13-SuosikkiNimet2020\tytot.txt
            string nimi = NimiTB.Text; 
            int laskuriP = 1, laskuriT = 1;
            bool loytyiPojat = false, loytyiTytot = false; /// Yritys korjata vikaa, (ei l�yd� listoilta mit��n nimi�)

            foreach (string p in pojat)
            {
                if (nimi == p)
                {
                    VastausLB.Text = "Nimesi on numero " + laskuriP + ". suosituimpien poikien nimien joukossa 2020";
                    loytyiPojat = true; /// Yritys korjata vikaa, (ei l�yd� listoilta mit��n nimi�)
                    break; /// Yritys korjata vikaa, (ei l�yd� listoilta mit��n nimi�)
                }
                laskuriP++;
            }
            

            foreach (string t in tytot)
            {
                if (nimi == t)
                {
                    VastausLB.Text = "Nimesi on numero " + laskuriT + ". suosituimpien tytt�jen nimien joukossa 2020";
                    loytyiTytot = true; /// Yritys korjata vikaa, (ei l�yd� listoilta mit��n nimi�)
                    break; /// Yritys korjata vikaa, (ei l�yd� listoilta mit��n nimi�)
                }
                laskuriT++;
            }
            if (!loytyiPojat && !loytyiTytot) /// Yritys korjata vikaa, (ei l�yd� listoilta mit��n nimi�) Muutettu alustuksessa bool tyyppiseksi
            {
                VastausLB.Text = "Nimesi ei l�ytynyt vuonna 2020 suosituimpien nimien joukosta!";
                
            }
            VastausLB.Visible = true;
        }

    }
}