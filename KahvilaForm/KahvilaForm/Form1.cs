namespace KahvilaForm
{
    public partial class RuokalistaForm : Form
    {
        public RuokalistaForm()
        {
            InitializeComponent();
            MeistaPanel.Visible = true; // K‰ynnistyess‰ n‰ytt‰‰ MeistaPanelin
        }
        /// HUOM: Tein kaikki elementit ensin ja otin kuvat, ennen kuin lis‰sin n‰pp‰imiin ja yl‰paneliin png kuvia 
        /// Syy t‰h‰n oli, ett‰ ensim‰isell‰ kerralla kun tein teht‰v‰‰, p‰‰sin cook-hat.png laittoon ja visualstudio alkoi temppuilla
        /// En halunnut ottaa riski‰ ett‰ sama virhe toistuu. Siksi lis‰sin kuvat viimeisen‰ (Nyt vika ei toistunut)
     
        private void RuokalistaForm_Load(object sender, EventArgs e)
        {
            // Voidaan syˆtt‰‰ teksti siin‰ vaiheessa kun formi ladataan, mutta on myˆs toinen tapa
            // (Muut panelit tehty eritavalla)
            meistaLB.Text = "Keudan oppilaskunnan kahvila palelee luokassa 320 v‰lituntisin \n";
            meistaLB.Text += "09:00 - 14:30 joka p‰iv‰ maanantaista torstaihin ja perjantaisin \n";
            meistaLB.Text += "09:00 - 12:30 \n\n Keudan oppilaskunnan kahvilasta saa l‰mpimien \n";
            meistaLB.Text += "juomien lis‰ksi virvokkeita sek‰ pient‰ purtavaa ja makeisia \n";
            meistaLB.Text += "Tervetuloa tutustumaan! \n";
          //  meistaLB.Text += new Font("Arial", 10); 
          /// T‰m‰ ei ainakaan itsell‰ni muuttanut fonttia, vaan aiheutti vian. Siksi suljettu
          /// Properties ikkunasta asetettu fonttikoko m‰‰ritt‰‰ t‰ss‰kintapauksessa arvon
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
