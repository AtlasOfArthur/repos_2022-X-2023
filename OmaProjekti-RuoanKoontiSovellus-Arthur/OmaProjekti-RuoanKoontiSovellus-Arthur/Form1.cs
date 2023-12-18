using System.Data;

namespace OmaProjekti_RuoanKoontiSovellus_Arthur
{
    public partial class AterianKoontiForm : Form
    {

        // Tietorakenteet ainesosaluettelossa tulevat olemaan isoja. siksi en luo koko luetteloa heti
        // T‰m‰n sijaan luettelot luodaan vasta kun niit‰ k‰ytet‰‰n
        private DataTable dataKategoriat;
        private DataTable dataAinesosat;
        

        public AterianKoontiForm()
        {
            InitializeComponent();
        }

        private void RuoanKoontiForm_Load(object sender, EventArgs e)
        {
            WelcomePanel.Visible = true; // Mahdollisesti turha, mutta varmistaa ett‰ tervetuloa paneli on k‰ynnistyksen yhteydess‰ oikealla paikallaan

            // Alla oleva rivi kutsuu Kategoriat DataTablen funktiota. Ainesosat DataTable luodaan ja kutsutaan myˆhemmin viiveen v‰ltt‰miseksi.
            // (Tai sit‰ on ainakin tarkoitus yritt‰‰)
            LuoJaTaytaKategoriatDataTable();
        }

        //----------------------------------------------------------------------------------------------//

        private void LuoJaTaytaKategoriatDataTable()
        {

            dataKategoriat = new DataTable("Kategoriat"); // Luo DataTable kategorioille. DataTable on tietorakenne, joka muistuttaa taulukkoa ja mahdollistaa tietojen tallentamisen riveihin ja sarakkeisiin.
            dataKategoriat.Columns.Add("Kategoria", typeof(string)); // Lis‰‰ uuden sarakkeen Datatableen (Column)=sarake.
                                                                     // Sarake m‰‰rittelee, millaista tietoa voit tallentaa dataKategoriat-DataTableen kyseisell‰ sarakkeella.

            // Luo kategoriat KategoriaCB varten merkkijono listana tyhj‰n merkkijonon kanssa, joka on oletus merkkijono comboboksissa
            string[] kategoriat = { " ", "Liha", "Kala", "Marjat", "Hedelm‰t", "Juurekset", "Vihannekset", "P‰hkin‰t/Siemenet", "Viljat", "Yrtit", "Sienet", "Sipulit", "Rasvat", "Maitotuotteet", "Muut" };

            // Lis‰‰ kategoria vaihtoehdot KategoriaCB sis‰‰n
            foreach (var kategoria in kategoriat)
            {
                dataKategoriat.Rows.Add(kategoria);
            }

            // Sidotaan DataTable ComboBoxiin
            KategoriaCB.DataSource = dataKategoriat; // Tuo objektit n‰kyviin comboboksissa
            KategoriaCB.DisplayMember = "Kategoria"; // Tuo objektien nimet comboboksiin. Jos t‰ss‰ on kirjoitusvirhe tai puuttuu kokonaan, ei ilmaise virhett‰, mutta ei tuota comboboksin sis‰ltˆ‰ oikein.
                                                     // Silloin ilmaisee jokaisen sarakkeen kohdalla: System-Data-DataRowView

            /* Ei toimi
            // Jos valittu kategoria ei ole ensimm‰inen tyhj‰ kategoria (" "),  tyhjent‰‰ dataKategoriat-tietorakenteen rivit ja lis‰‰ uudet kategoriat.
            // T‰m‰ mahdollistaa kategorian valinnan muuttamisen vaikuttamatta alkuper‰iseen " " kategoriaan.
            KategoriaCB.SelectedIndexChanged += (sender, e) =>
            {
                if (KategoriaCB.SelectedIndex != 0)
                {
                    dataKategoriat.Rows.Clear();

                    string[] uudetKategoriat = { "Liha", "Kala", "Marjat", "Hedelm‰t", "Juurekset", "Vihannekset", "P‰hkin‰t/Siemenet", "Viljat", "Yrtit", "Sienet", "Sipulit", "Rasvat", "Maitotuotteet", "Muut" };
                    foreach (var kategoria in uudetKategoriat)
                    {
                        dataKategoriat.Rows.Add(kategoria);
                    }
                }
            };*/
            /* Ei toimi t‰m‰k‰‰n! Vaihdetaan taktiikkaa...
            KategoriaCB.SelectedIndexChanged += (sender, e) =>
            {
                // Tarkista onko " " -kategoria l‰sn‰
                bool containsEmptyCategory = false;
                DataRow emptyCategoryRow = null;
                foreach (DataRow row in dataKategoriat.Rows)
                {
                    if (row["Kategoria"].ToString() == " ")
                    {
                        containsEmptyCategory = true;
                        emptyCategoryRow = row;
                        break;
                    }
                }

                // Jos " " -kategoria lˆytyy, poista se
                if (containsEmptyCategory && KategoriaCB.SelectedIndex != 0)
                {
                    dataKategoriat.Rows.Remove(emptyCategoryRow);
                }

                // Lis‰‰ lopuksi uudet kategoriat
                string[] uudetKategoriat = { "Liha", "Kala", "Marjat", "Hedelm‰t", "Juurekset", "Vihannekset", "P‰hkin‰t/Siemenet", "Viljat", "Yrtit", "Sienet", "Sipulit", "Rasvat", "Maitotuotteet", "Muut" };
                foreach (var kategoria in uudetKategoriat)
                {
                    dataKategoriat.Rows.Add(kategoria);
                }
            }; */
            /* // Ei toimi -.-'
            KategoriaCB.SelectedIndexChanged += (sender, e) =>
            {
                // Tarkista onko " " -kategoria joukossa
                bool containsEmptyCategory = kategoriat.Contains(" ");

                // Poista " " -kategoria vain jos se on joukossa
                if (containsEmptyCategory)
                {
                    DataRow[] emptyCategoryRows = dataKategoriat.Select("Kategoria = ' '");
                    foreach (var emptyCategoryRow in emptyCategoryRows)
                    {
                        dataKategoriat.Rows.Remove(emptyCategoryRow);
                    }

                    // Aseta SelectedIndex nollaksi p‰ivityksen j‰lkeen
                    KategoriaCB.SelectedIndex = 0;
                }

                // Lis‰‰ lopuksi uudet kategoriat
                string[] uudetKategoriat = { "Liha", "Kala", "Marjat", "Hedelm‰t", "Juurekset", "Vihannekset", "P‰hkin‰t/Siemenet", "Viljat", "Yrtit", "Sienet", "Sipulit", "Rasvat", "Maitotuotteet", "Muut" };
                foreach (var kategoria in uudetKategoriat)
                {
                    dataKategoriat.Rows.Add(kategoria);
                }
            };
            */
        }
        //----------------------------------------------------------------------------------------------//


        private void CloseWelcomeBT_MouseHover(object sender, EventArgs e)
        {
            CloseWelcomeBT.ForeColor = Color.Black;
            CloseWelcomeBT.BackColor = Color.Ivory;
            // T‰m‰ ei toimi n‰in, vaikka kaiken j‰rjen mukaan pit‰isi. T‰ytyy menn‰ properties ikkunasta asetuksiin
            // Flat appearance ja asettaa sielt‰ Fore- ja BackColor arvot
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
