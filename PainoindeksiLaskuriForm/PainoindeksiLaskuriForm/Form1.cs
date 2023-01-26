namespace PainoindeksiLaskuriForm
{
    public partial class BMI_Form : Form
    {
        public BMI_Form()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            try
            {
                double paino = 0, pituus = 0, painoindeksi;
                paino = Convert.ToDouble(painoTB.Text);
                pituus = Convert.ToDouble(pituusTB.Text);
                painoindeksi = Math.Round(paino / (pituus * pituus), 2); // (Math.Round) pyöristää tuloksen, (2) lopussa määrittää pyöristyksen desimaalien määrän.


                if (painoindeksi < 14)
                {
                    vastausLB.Text = "Painoindeksisi on " + painoindeksi;
                    vastausLB.ForeColor = Color.Red;
                    KuvausLB.Text = "! Olet vaarassa kuolla !";  // Perustuu karkeasti matalien painoindeksi kuolemien tilastoihin
                    KuvausLB.ForeColor = Color.Red;
                }
                else if (painoindeksi < 15)
                {
                    vastausLB.Text = "Painoindeksisi on " + painoindeksi;
                    vastausLB.ForeColor = Color.Crimson;
                    KuvausLB.Text = "! Sairaalloinen alipaino !";
                    KuvausLB.ForeColor = Color.Crimson;
                }
                else if (painoindeksi < 18)
                {
                    vastausLB.Text = "Painoindeksisi on " + painoindeksi;
                    vastausLB.ForeColor = Color.MediumVioletRed;
                    KuvausLB.Text = "Merkittävä alipaino";
                    KuvausLB.ForeColor = Color.MediumVioletRed;
                }
                else if (painoindeksi < 19)
                {
                    vastausLB.Text = "Painoindeksisi on " + painoindeksi;
                    vastausLB.ForeColor = Color.Blue;
                    KuvausLB.Text = "Lievä alipaino";
                    KuvausLB.ForeColor = Color.Blue;
                }
                else if (painoindeksi < 25)
                {
                    vastausLB.Text = "Painoindeksisi on " + painoindeksi;
                    vastausLB.ForeColor = Color.LimeGreen;
                    KuvausLB.Text = "Normaalipaino";
                    KuvausLB.ForeColor = Color.LimeGreen;
                }
                else if (painoindeksi < 30)
                {
                    vastausLB.Text = "Painoindeksisi on " + painoindeksi;
                    vastausLB.ForeColor = Color.ForestGreen;
                    KuvausLB.Text = "Lievä ylipaino";
                    KuvausLB.ForeColor = Color.ForestGreen;
                }
                else if (painoindeksi < 35)
                {
                    vastausLB.Text = "Painoindeksisi on " + painoindeksi;
                    vastausLB.ForeColor = Color.Gold;
                    KuvausLB.Text = "Merkittävä ylipaino";
                    KuvausLB.ForeColor = Color.Gold;
                }
                else if (painoindeksi < 40)
                {
                    vastausLB.Text = "Painoindeksisi on " + painoindeksi;
                    vastausLB.ForeColor = Color.DarkOrange;
                    KuvausLB.Text = "Vaikea ylipaino";
                    KuvausLB.ForeColor = Color.DarkOrange;
                }
                else
                {
                    vastausLB.Text = "Painoindeksisi on " + painoindeksi;
                    vastausLB.ForeColor = Color.Crimson;
                    KuvausLB.Text = "! Sairaalloinen ylipaino !";
                    KuvausLB.ForeColor = Color.Crimson;
                }
                vastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            catch (Exception ex)
            {
                vastausLB.Text = "Lukuaja ei pysty muuntamaan indeksiksi. Anna kelvolliset luvut.";
                MessageBox.Show(ex.Message + " Anna kelvolliset luvut.");
            }
        }
    }
}