namespace AutokuluKustannusForm
{
    public partial class kustForm : Form
    {
        public kustForm()
        {
            InitializeComponent();
        }

        private void KMPVcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, vakuutus, renkaat, huollot, nesteet, muut, poltto, pesu, kilometrit, kustannukset;
            laina = Convert.ToDouble(lainaTB.Text);
            vakuutus = Convert.ToDouble(vakuutusTB.Text);
            renkaat = Convert.ToDouble(renkaatTB.Text);
            huollot = Convert.ToDouble(huollotTB.Text);
            nesteet = Convert.ToDouble(nesteetTB.Text);
            muut = Convert.ToDouble(muutTB.Text);
            poltto = Convert.ToDouble(polttoTB.Text);
            pesu = Convert.ToDouble(pesuTB.Text);
            kilometrit = Convert.ToDouble(KMPVCB.Text);
            kustannukset = (laina + vakuutus + renkaat + huollot + nesteet + muut + poltto + pesu) / (kilometrit / 12);
            vastausLB.Text = "Kustannukset kilometriä kohti ovat: " + kustannukset;
            vastausLB.Visible = true;
        }
    }
}