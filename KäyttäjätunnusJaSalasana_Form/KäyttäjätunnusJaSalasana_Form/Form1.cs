namespace KäyttäjätunnusJaSalasana_Form
{
    public partial class käyttäjätunnusJaSalasana : Form
    {
        public käyttäjätunnusJaSalasana()
        {
            InitializeComponent();
        }

        private void tarkistaBT_Click(object sender, EventArgs e)
        {
            if (KayttajaBox.Text == "Arthur" && SalasanaBox.Text == "salasanakala")
            {
            /// salasanaPanel.Visible = false; /// Jos laittaa tämän, katoaa molemmat panelit
                salasanaoikeinPanel.Visible = true;
            }
            else
            {
                virheviestiLB.Text = "Salasana tai käyttäjätunnus virheellinen.";
                virheviestiLB.Visible = true;
            }

        }
    }
}