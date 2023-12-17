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
            WelcomePanel.Visible = true; // Mahdollisesti turha, mutta varmistaa ett� tervetuloa paneli on k�ynnistyksen yhteydess� oikealla paikallaan
        }

        private void CloseWelcomeBT_MouseHover(object sender, EventArgs e)
        {
            CloseWelcomeBT.ForeColor = Color.Black;
            CloseWelcomeBT.BackColor = Color.Ivory;
            // T�m� ei toimi n�in, vaikka kaiken j�rjen mukaan pit�isi. T�ytyy menn� properties ikkunasta asetuksiin
            // Flat appearance ja asettaa sielt� Fore- ja BackColor arvot
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
