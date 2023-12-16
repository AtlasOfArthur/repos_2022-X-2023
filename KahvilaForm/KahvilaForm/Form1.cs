namespace KahvilaForm
{
    public partial class RuokalistaForm : Form
    {
        public RuokalistaForm()
        {
            InitializeComponent();
            MeistaPanel.Visible = true; // Käynnistyessä näyttää MeistaPanelin
        }

        private void RuokalistaForm_Load(object sender, EventArgs e)
        {
            // Voidaan syöttää teksti siinä vaiheessa kun formi ladataan, mutta on myös toinen tapa
            // (Muut panelit tehty eritavalla)
            meistaLB.Text = "Keudan oppilaskunnan kahvila palelee luokassa 320 välituntisin \n";
            meistaLB.Text += "09:00 - 14:30 joka päivä maanantaista torstaihin ja perjantaisin \n";
            meistaLB.Text += "09:00 - 12:30 \n\n Keudan oppilaskunnan kahvilasta saa lämpimien \n";
            meistaLB.Text += "juomien lisäksi virvokkeita sekä pientä purtavaa ja makeisia \n";
            meistaLB.Text += "Tervetuloa tutustumaan! \n";
          //  meistaLB.Text += new Font("Arial", 10); 
          /// Tämä ei ainakaan itselläni muuttanut fonttia, vaan aiheutti vian. Siksi suljettu
          /// Properties ikkunasta asetettu fonttikoko määrittää tässäkintapauksessa arvon
        }

        private void MeistaBT_Click(object sender, EventArgs e)
        {
            MeistaPanel.Visible = true;
            RuoatPanel.Visible = false;
            JuomatPanel.Visible = false;
            HerkutPanel.Visible = false;
            KoriPanel.Visible = false;
        }

        private void RuoatBT_Click(object sender, EventArgs e)
        {
            MeistaPanel.Visible = false;
            RuoatPanel.Visible = true;
            JuomatPanel.Visible = false;
            HerkutPanel.Visible = false;
            KoriPanel.Visible = false;
        }

        private void JuomatBT_Click(object sender, EventArgs e)
        {
            MeistaPanel.Visible = false;
            RuoatPanel.Visible = false;
            JuomatPanel.Visible = true;
            HerkutPanel.Visible = false;
            KoriPanel.Visible = false;
        }

        private void HerkutBT_Click(object sender, EventArgs e)
        {
            MeistaPanel.Visible = false;
            RuoatPanel.Visible = false;
            JuomatPanel.Visible = false;
            HerkutPanel.Visible = true;
            KoriPanel.Visible = false;
        }

        private void KoriBT_Click(object sender, EventArgs e)
        {
            MeistaPanel.Visible = false;
            RuoatPanel.Visible = false;
            JuomatPanel.Visible = false;
            HerkutPanel.Visible = false;
            KoriPanel.Visible = true;
        }
    }
}
