using System.Data;

namespace OmaProjekti_RuoanKoontiSovellus_Arthur
{
    public partial class AterianKoontiForm : Form
    {

        // Tietorakenteet ainesosaluettelossa tulevat olemaan isoja. siksi en luo koko luetteloa heti
        // T‰m‰n sijaan luettelot luodaan vasta kun niit‰ k‰ytet‰‰n
        DataTable dataKategoriat;
        DataTable dataAinesosat = new DataTable("Ainesosat"); // Luon t‰m‰n heti, vaikka se onkin laaja, koska oli ongelmia saada toimimaan
        DataTable yhteys = new DataTable(); // Yhteys kategorian ja sen aineiden v‰lille

        public AterianKoontiForm()
        {
            InitializeComponent();
        }

        private void RuoanKoontiForm_Load(object sender, EventArgs e)
        {
            WelcomePanel.Visible = true; // Mahdollisesti turha, mutta varmistaa ett‰ tervetuloa paneli on k‰ynnistyksen yhteydess‰ oikealla paikallaan

            LuoJaTaytaKategoriatDataTable();
            LuoJaTaytaAinesosaDataTable();
            KategoriaCB.DataSource = dataKategoriat;
            KategoriaCB.DisplayMember = "Kategoria";
        }

        private void KategoriaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow selectedKategoria = dataKategoriat.Rows[KategoriaCB.SelectedIndex];

            int kategoriaID = (int)selectedKategoria["ID"];
            DataRow[] selectedAinesosat = dataAinesosat.Select("ID =" + kategoriaID);

            yhteys = selectedAinesosat.CopyToDataTable();
            AinesosaCB.DataSource = yhteys;
            AinesosaCB.DisplayMember = "Aines_1_Nimi";
        }


        //----------------------------------------------------------------------------------------------//
        // KategoriaCB
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
        // P‰‰tin ett‰ en edes yrit‰ p‰ivitt‰‰ listaa ilman " " -lkategoriaa, koska en vaan onnistu. Menee se n‰inkin...
        }

        //----------------------------------------------------------------------------------------------//
        private void LuoJaTaytaAinesosaDataTable()
        {
            dataAinesosat.Columns.Add("ID", typeof(int));
            dataAinesosat.Columns.Add("Aines_1_Nimi");
            dataAinesosat.Columns.Add("Aines_2_Nimi");
            dataAinesosat.Columns.Add("Aines_3_Nimi");

            DataRow ainesosaRow = dataAinesosat.NewRow();
            ainesosaRow["ID"] = 1;
            ainesosaRow["Aines_1_Nimi"] = "Kana";
            ainesosaRow["Aines_2_Nimi"] = "Nauta";
            ainesosaRow["Aines_3_Nimi"] = "Sika";
            dataAinesosat.Rows.Add(ainesosaRow);
        }


        // AinesosatCB
        /*
        private void LuoJaTaytaAinesosatDataTable(string valittuKategoria)
        {

            // Tyhjennet‰‰n aikaisemmat tiedot
            dataAinesosat.Clear();

            // T‰ytet‰‰n ainesosat valitun kategorian mukaisesti switch case -rakenteella
            switch (valittuKategoria)
            {
                case "Liha":
                    string[] lihaAinesosat = { "Kana", "Nauta", "Sika" };
                    foreach (var ainesosa in lihaAinesosat)
                    {
                        dataAinesosat.Rows.Add(ainesosa);
                    }
                    break;

                case "Kala":
                    string[] kalaAinesosat = { "Lohi", "Silakka", "Taimen", "Ahven" };
                    foreach (var ainesosa in kalaAinesosat)
                    {
                        dataAinesosat.Rows.Add(ainesosa);
                    }
                    break;

                case "Marjat":
                    string[] marjaAinesosat = { "Mansikka", "Vadelma", "Puolukka", "Mustikka", "Variksenmarja", "Tyrni" };
                    foreach (var ainesosa in marjaAinesosat)
                    {
                        dataAinesosat.Rows.Add(ainesosa);
                    }
                    break;

                // Lis‰‰ tarvittavat tapaukset muille kategorioille

                default:
                    // Oletustapaus, jos ei ole valittu kategoriaa tai kategoria ei vastaa odotettua
                    break;
            }

            // Sidotaan DataTable AinesosaCB ComboBoxiin
            AinesosaCB.DataSource = dataAinesosat;
            AinesosaCB.DisplayMember = "Ainesosa";
        }
        //----------------------------------------------------------------------------------------------//
        private void KategoriaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valittuKategoria = KategoriaCB.SelectedItem.ToString();
            LuoJaTaytaAinesosatDataTable(valittuKategoria); // Kutsuu metodia, joka luo ja t‰ytt‰‰ ainesosat DataTablen valitun kategorian (Switch case) valinnan perusteella
        }*/
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
