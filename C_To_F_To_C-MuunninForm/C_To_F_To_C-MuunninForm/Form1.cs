namespace C_To_F_To_C_MuunninForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void muunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(asteetTB.Text); // Tämä rivi oli virheellinen

            if (celsiusRButton.Checked)
            {
                vastaus = asteet * 1.8 + 32;
                vastausLB.Text = asteet + " Fahrenheitia on " + vastaus + " Celsius astetta.";
            }
            else if (fahrenheitRButton.Checked)
            {
                vastaus = asteet - 32 / 1.8;
                vastausLB.Text = asteet + " Celsiusta on " + vastaus + " Fahrenheit astetta";
            }
            else
            {
                vastausLB.Text = "Lukua ei pysty muuntamaan. Anna toinen."; // Puolipiste puuttui
            }
            vastausLB.Visible= true; // Ohjeessa oli että tämä laitettiin kaikkien iffauksien loppuun. Toimisi kai näinkin.
        }
    }
}