namespace NoppaForm2
{
    public partial class heitanoppaaForm : Form
    {
        public heitanoppaaForm()
        {
            InitializeComponent();
        }

        private void heitaBT_Click(object sender, EventArgs e)
        {
            piirranoppa(noppaBox1);
            piirranoppa(noppaBox2);
            piirranoppa(noppaBox3);
            piirranoppa(noppaBox4); // image layout (zoom)
        }                           // (Size mode) piti olla myös zoom, muuten ei toimi oikein
        private void piirranoppa(PictureBox NoppaBox) // Tässä tehtävässä näkee hyvin aliohjelmien käytännöllisyyden
        {                                             // Paljon vähemmän rivejä verrattuna jos tekisi kaikille nopille oman switch casen
            Random satunnainen = new Random();
            int noppa = satunnainen.Next(1, 7); // noppa ottaa arvotun satunnaisen (1-6)
            switch (noppa)                      // ja tulostaa yhden kuvan satunnaisen mukaan
            {               // casesta riippuen hakee tulostettavan kuvan resources kansiosta
                case 1:
                    NoppaBox.Image = Properties.Resources.dices_1;
                    break;
                case 2:
                    NoppaBox.Image = Properties.Resources.dices_2;
                    break;
                case 3:
                    NoppaBox.Image = Properties.Resources.dices_3;
                    break;
                case 4:
                    NoppaBox.Image = Properties.Resources.dices_4;
                    break;
                case 5:
                    NoppaBox.Image = Properties.Resources.dices_5;
                    break;
                case 6:
                    NoppaBox.Image = Properties.Resources.dices_6;
                    break;
            }
        }
    }
}