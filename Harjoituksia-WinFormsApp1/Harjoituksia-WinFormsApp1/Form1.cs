namespace Harjoituksia_WinFormsApp1
{// Jos hukkaat NO CODE konsolin -> View / Designer TAI Sift+F7
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }

        private void BT_T1_Click(object sender, EventArgs e) // Koodi T1 buttonille
        {
            T1_LB.Text = "Heippa maailma";
            BT_T1.Text = "Teht‰v‰ suoritettu!";
        }

        private void TulostaBT_T2_Click(object sender, EventArgs e)
        {
            string teksti = TulostusTB_T2.Text; // Tallentaa k‰ytt‰j‰n syˆtteen merkkijonoksi
            TulostettuTXT_T2.Text = teksti; // Tulostaa tekstin, koska (Visible = false)
            TulostettuTXT_T2.Visible = true; // Tuo tekstin n‰kyviin 
        }

        private void laskeBT_T3_Click(object sender, EventArgs e)
        {
            float luku1, luku2, vastaus;
            string merkki;
            luku1 = float.Parse(lukuBox1.Text); // T‰ytyy parsata, koska 'lukuBox..' ottaa syˆtteen stringin‰, eli tekstin‰ vastaan, eik‰ lukuna (integer)
            luku2 = float.Parse(lukuBox2.Text);
            merkki = comboBox_T3.Text;

            switch (merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus= luku1 - luku2;
                    break; 
                case "*":
                    vastaus = luku1 * luku2;
                    break;
                case "/":
                    vastaus = luku1 / luku2;
                    break;
                default:
                    vastaus = 0;
                    break;
            }
            vastausLB_T3.Text = Convert.ToString(vastaus);
        }

        private void laskeIk‰BT_T4_Click(object sender, EventArgs e)
        {
            DateTime syntt‰ri = DTP_T4.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - syntt‰ri).TotalDays);

            vuottaLB_T4.Text = Math.Ceiling(erotus / 365.25) + " vuotta";//Yritt‰‰ syˆtt‰‰ doublea tekstikentt‰‰n. Onnistuu jos lis‰‰ teksti‰ per‰‰n
            kuukauttaLB_T4.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta";
            viikkoaLB_T4.Text = Math.Ceiling(erotus * 52.18 / 365.25) + " viikkoa";
            paivaaLB_T4.Text = erotus + " p‰iv‰‰";
            tuntiaLB_T4.Text = (erotus * 24) + " tuntia";
            minuuttiaLB_T4.Text = (erotus * 24 * 60) + " minuuttia";
            SekunttiaLB_T4.Text = (erotus * 24 * 60 * 60) + " sekunttia";

            oletElanytLB_T4.Visible = true;
            vuottaLB_T4.Visible = true;
            kuukauttaLB_T4.Visible = true;
            viikkoaLB_T4.Visible = true;
            paivaaLB_T4.Visible = true;
            tuntiaLB_T4.Visible = true;
            minuuttiaLB_T4.Visible = true;
            SekunttiaLB_T4.Visible = true;
        }

        // (Teht‰v‰5)T1-tason ohjelmointi: 10. Viides harjoitus: Lukujen j‰rjestys (6:57)
        List<int> jono_T5 = new List<int>(); // Miksi lista? ,koska taulukon koko t‰ytyy m‰‰ritell‰ ensin. (Ensin listaksi tekeminen s‰‰st‰‰ muistia)

        private void textBox_T5_KeyPress(object sender, KeyPressEventArgs e)  //  Designer.cs 408
        // Designer.cs (Code)-> this.textBox_T5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_T5_KeyPress);
        /*
            VƒƒRIN!

        private void textBox_T5_TextChanged(object sender, EventArgs e)  
        // Designer.cs 381 (Old) -> (Code)-> this.textBox_T5.TextChanged += new System.EventHandler(this.TextBox_T5_TextChanged);  */
        // Manuaalisesti muuttamalla tuli lis‰‰ virheit‰. muuta (Properties -> [salama symboli] -> tuplaklikkaa kohtaa KeyPress)
        {

            if (e.KeyChar == (char)Keys.Enter)  // KeyChar ei toimi jos private void textBox_T5_TextChanged -//- ...Manuaalinen muuttaminen vaikeaa, mutta mahdollista
            {
                if (textBox_T5.Text == "-999") // Jatkaa jonoon lis‰‰mist‰ (else), kunnes (-999) lis‰t‰‰n
                {
                    vastaus_T5.Text = ""; // Tyhjent‰‰ kent‰n silt‰ varalta ett‰ siell‰ on jotain
                    int[] arrayEliTaulukko = jono_T5.ToArray(); // Muuttaa luodun jono listan taulukoksi
                    Array.Sort(arrayEliTaulukko); // J‰rjest‰‰ juuri luodun taulukon pienimm‰st‰ suurimpaan
                    foreach(var nro in arrayEliTaulukko) // Ei suostu tulostamaansuoraan, joten lis‰t‰‰n foreach komennolla yksitellen
                    {
                        vastaus_T5.Text += nro + " "; //Lis‰t‰‰n numerot (nro) yksitellen riville + lis‰t‰‰n v‰lilyˆnti numeroiden v‰liin kohtaan vastaus_T5 ja tulostetaan
                    }
                    vastaus_T5.Visible = true; // Kun(-999) lis‰t‰‰n tekee tekstikent‰st‰ (textBox_T5 n‰kyv‰n)
                }
                else
                {
                    jono_T5.Add(int.Parse(textBox_T5.Text)); //lis‰‰ textikent‰ss‰ olevan luvun listaan jono_T5 entterin painalluksella (KeyPress)
                    textBox_T5.Text = ""; // Tyhjent‰‰ tekstikent‰n
                }
            }
        }
    }
}