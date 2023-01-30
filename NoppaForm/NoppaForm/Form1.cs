namespace NoppaForm
{
    public partial class NoppaForm: Form
    {
        public heitanoppaa() // En tied‰ mit‰ hemmetti‰ meni v‰‰rin, koska t‰m‰ on nyt noppa02PB >:(
        {                       // Aloitetaan alusta!
            InitializeComponent(); // Yritin korjata ja nyt t‰m‰kin on rikki
        }

        private void heitaBT_Click(object sender, EventArgs e)
        {
            Piirr‰Noppa(noppa01PB);
            Piirr‰Noppa(noppa02PB);
        }
        private void Piirr‰Noppa(PictureBox NoppaBox) //NoppaBox = 'temp' muuttuja
        {
            Random satunnainen = new Random();
            int noppa = satunnainen.Next(1,7);
            switch(noppa)
            {
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