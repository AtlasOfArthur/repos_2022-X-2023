namespace _14_Päiväkirja
{
    public partial class PäiväkirjaForm : Form
    {
        public PäiväkirjaForm()
        {
            InitializeComponent();
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string uusiTeksti = File.ReadAllText(@"C:\\Users\\arthur\\source\\repos\\14-Päiväkirja\\Paivakirja.txt");
                                                    /// c/Users/arthur/source/repos/14-Päiväkirja
            
            uusiTeksti += DateTime.Now.ToString("dd.MM.yyyy HH:mm") + " " + "\n\n";
            uusiTeksti += SyottoTB.Text + "\n\n\n\ncat";
            TextWriter text = new StreamWriter("C:\\Users\\arthur\\source\\repos\\14-Päiväkirja\\Paivakirja.txt");
            text.Write(uusiTeksti);
            text.Close();
            Application.Exit();

        }
    }
}
