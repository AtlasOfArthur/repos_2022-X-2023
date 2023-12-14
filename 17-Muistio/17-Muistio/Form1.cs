namespace _17_Muistio 
{
    public partial class MuistioForm : Form
    {
        // Muistio by: Arthur Harjama
        //----------------------------------//
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        //----------------------------------//
        public MuistioForm()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------------------------------------//
        // Tehd‰‰n omina funktioina, joita kutsutaan _Click eventeiss‰ alempana
        private void UusiTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(TextRichTB.Text))
                {
                    MessageBox.Show("Sinun tulee tallemntaa ensin!");

                }
                else
                {
                    TextRichTB.Text = string.Empty;
                    Text = "Anonymous_File"; // Yleens‰ laitetaan "Nimetˆn"
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void TallennaTiedosto()
        {
            try 
            {
                if (!string.IsNullOrEmpty(TextRichTB.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Tekstitiedosto (*.txt) | *.txt | Rikas Teksti Formaatti (*rtf) | *.rtf";
                    if ( saveFileDialog.ShowDialog() == DialogResult.OK )
                    {
                        File.WriteAllText(saveFileDialog.FileName, TextRichTB.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void AvaaTiedosto()
        {
            try
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK )
                {
                    TextRichTB.Text = File.ReadAllText(openFileDialog.FileName);
                    Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe avattaessa tiedostoa: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------//
        // _Click eventit...
        private void MuistioForm_Load(object sender, EventArgs e)
        {
            fontDialog = new FontDialog(); // Tehd‰‰n uusi objekti (olio)

            if (Properties.Settings.Default.SelectedFont != null) ; // K‰ytt‰‰ tallennettua fonttia, jos sellainen on olemassa
            {
                TextRichTB.Font = Properties.Settings.Default.SelectedFont;
            }
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UusiTiedosto(); // Kun _Click even tapahtuu, kutsutaan aliohjelmaa: private void UusiTiedosto()
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvaaTiedosto(); // Kun _Click even tapahtuu, kutsutaan aliohjelmaa: private void AvaaTiedosto()
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TallennaTiedosto(); // Kun _Click even tapahtuu, kutsutaan aliohjelmaa: private void TallennaTiedosto()
        }

        //----------------------------------------------------------------------------------------//
        // Tehd‰‰n lopeta funktio erilailla. Funktion toiminta tulee suoraan _Click eventin sis‰‰n
        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!string.IsNullOrEmpty(TextRichTB.Text))
                {
                    TallennaTiedosto(); 
                    // Tyypillisesti t‰ss‰ kohtaa tulisi pop-up, joka kysyy, ett‰ tallennetaanko. Nyt sit‰ ei tehd‰.
                }
                else
                {
                    Application.Exit(); // Tai>>> This.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (fontDialog.ShowDialog() == DialogResult.OK) // Katsotaan ett‰ fontDialog toimii
                {
                    TextRichTB.Font = fontDialog.Font; // Muutetaan fontti siihen fonttiin mik‰ on valittuna
                    /// Properties-k‰site ei v‰ltt‰m‰tt‰ ole k‰ytett‰viss‰, jos asetukset eiv‰t ole m‰‰ritetty projektissa
                    /// * Napsauta hiiren oikealla painikkeella projektiasi Solution Explorerissa.
                    /// * Valitse "Properties"(Ominaisuudet).
                    /// * Siirry "Settings"(Asetukset) - v‰lilehdelle ja seuraa linkki‰.
                    /// * *  Luo uusi asetus nimelt‰‰n "SelectedFont" tyyppi‰ System.Drawing.Font
                    ///  | SelectedFont | System.Drawing.Font | User | \[Tyhj‰\] |

                    // Lis‰t‰‰n seuraavat rivit jotta valitun fontin saadaan tallennettua
                    Properties.Settings.Default.SelectedFont = fontDialog.Font;
                    Properties.Settings.Default.Save();

                    /// Lis‰t‰‰n myˆs osioon private void MuistioForm_Load(object sender, EventArgs e) if lauseke.
                    /// NYT fontin pit‰isi tallentua!
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }
    }
}
