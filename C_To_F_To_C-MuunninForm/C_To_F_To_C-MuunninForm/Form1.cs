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
            
            try // try catch: bonusta, mutta en osaa tehdä oikein :/
            {
                double vastaus;
                double asteet = Convert.ToDouble(muunnaBT.Text);

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
                    vastausLB.Text = "Lukua ei pysty muuntamaan. Anna toinen."
                }
                vastausLB.Visible= true; // Ohjeessa oli että tämä laitettiin kaikkien iffauksien loppuun. Toimisi kai näinkin.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Anna kelvollinen luku.");
            }
        }
    }
}