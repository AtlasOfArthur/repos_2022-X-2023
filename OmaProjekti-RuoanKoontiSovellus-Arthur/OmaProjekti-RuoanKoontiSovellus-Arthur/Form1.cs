namespace OmaProjekti_RuoanKoontiSovellus_Arthur
{
    public partial class AterianKoontiForm : Form
    {
        public AterianKoontiForm()
        {
            InitializeComponent();
        } 
        
        private void RuoanKoontiForm_Load(object sender, EventArgs e)
        {
            WelcomePanel.Visible = true; // Mahdollisesti turha, mutta varmistaa että tervetuloa paneli on käynnistyksen yhteydessä oikealla paikallaan
        }

        private void CloseWelcomeBT_MouseHover(object sender, EventArgs e)
        {
            CloseWelcomeBT.ForeColor = Color.Black;
            CloseWelcomeBT.BackColor = Color.Ivory;
            // Tämä ei toimi näin, vaikka kaiken järjen mukaan pitäisi. Täytyy mennä properties ikkunasta asetuksiin
            // Flat appearance ja asettaa sieltä Fore- ja BackColor arvot
        }

        private void CloseWelcomeBT_MouseLeave(object sender, EventArgs e)
        {
            CloseWelcomeBT.ForeColor = Color.Gray;
            CloseWelcomeBT.BackColor = Color.Ivory;
        }

        private void CloseWelcomeBT_Click(object sender, EventArgs e)
        {
            WelcomePanel.Visible = false;
        }


    }
}
