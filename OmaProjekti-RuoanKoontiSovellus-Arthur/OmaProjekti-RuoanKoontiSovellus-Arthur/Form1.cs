using System.Data;

namespace OmaProjekti_RuoanKoontiSovellus_Arthur
{


    public partial class AterianKoontiForm : Form
    {


        public AterianKoontiForm()
        {
            InitializeComponent();
            KategoriaCB.SelectedIndexChanged += KategoriaCB_ValittuKategoriaVaihdettu;

        }
        public class Ruoka
        {
            public string Kategoria { get; set; } = "";
            public string Laji { get; set; } = "";
            public List<(string Nimi, float Arvo)> Aineet { get; set; } = new List<(string Nimi, float Arvo)>();
        }

        private void RuoanKoontiForm_Load(object sender, EventArgs e)
        {
            foreach (var ruoka in ruokaLista)
            {
                if (!string.IsNullOrWhiteSpace(ruoka.Kategoria) && !KategoriaCB.Items.Contains(ruoka.Kategoria))
                {
                    KategoriaCB.Items.Add(ruoka.Kategoria); // Lis‰‰ Kategoria comboboksiin ruoka listassa olevat Kategoria t‰g‰tyt objektit
                }
            }
        }
        private void KategoriaCB_ValittuKategoriaVaihdettu(object sender, EventArgs e)
        {
            // Tyhjent‰‰ LajiCB
            LajiCB.Items.Clear();

            // Hakee valitun kategorian
            string valittuKategoria = KategoriaCB.SelectedItem.ToString();

            // Etsii ruoat, jotka kuuluvat valittuun kategoriaan
            var valitutRuoat = ruokaLista.Where(ruoka => ruoka.Kategoria == valittuKategoria);

            // Lis‰‰ ruokien lajit LajiCB:hen
            foreach (var ruoka in valitutRuoat)
            {
                if (!string.IsNullOrWhiteSpace(ruoka.Laji) && !LajiCB.Items.Contains(ruoka.Laji))
                {
                    LajiCB.Items.Add(ruoka.Laji);
                }
            }
        }
        private void LajiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lis‰‰ valitun lajin ValinnatFlowLayoutPaneliin
            string valittuLaji = LajiCB.SelectedItem.ToString();

            // Lis‰t‰‰n uusi label ja poista button
            Label uusiLabel = new Label();
            uusiLabel.Text = valittuLaji;
            uusiLabel.Font = new Font("Script MT Bold", 11);
            Button uusiButton = new Button();
            uusiButton.Text = "Poista";
            uusiButton.Font = new Font(uusiButton.Font.FontFamily, 8, FontStyle.Bold);
            uusiButton.Size = new Size(75, 26);

            // Lis‰t‰‰n luotu Label FlowLayoutPaneliin
            ValinnatFlowLayoutPanel.Controls.Add(uusiLabel);
            // Lis‰t‰‰n myˆs poista button
            ValinnatFlowLayoutPanel.Controls.Add(uusiButton);
        }

        List<Ruoka> ruokaLista = new List<Ruoka>
{
    // Jos arvot 0.0f, ei ole silloin v‰ltt‰m‰tt‰ tiedossa
    // Tyhj‰ kategoria
    new Ruoka
    {
        Kategoria = " ",
        Laji = " ",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            // Tyhj‰ valinta KategoriaCB ensimm‰isess‰ indeksiss‰
        }
    },
    new Ruoka
    {
        Kategoria = "Liha",
        Laji = "Sika", // "Kinkku, viipaloitu, ravintola" L‰hde: https://fdc.nal.usda.gov/fdc-app.html#/food-details/746952/nutrients
        Aineet = new List<(string Nimi, float Arvo)>
        {   // Arvot pit‰‰ p‰ivitt‰‰, koska todenn‰kˆisesti tiedot maustetusta lihasta !!!! (Natrium korkea)
            ("Natrium", 1030.0f), ("Potassium", 484.0f), ("Kalsium", 6.0f), ("Fosfori", 424.0f), ("Magnesuum", 0.015f),
            ("Rauta", 0.86f), ("Sinkki", 1.76f), ("Jodi", 0.0f), ("Kupari", 0.041f), ("VitA", 10),
            ("VitC", 0.0f), ("VitD", 0.0f), ("VitE", 0.0f), ("VitK", 0.0f), ("VitB1", 0.0f),
            ("VitB2", 0.0f), ("VitB6", 0.0f), ("VitB12", 0.0f), ("Kcal", 216.0f), ("Prot", 19.6f),
            ("HiHy", 2.36f), ("Sok", 2.2f), ("RasvaP", 2.275f), ("RasvaK", 1.25f), ("Kuidut", 0.0f),
        }// Note! Fatty acids, total monounsaturated + Fatty acids, total polyunsaturated = RasvaP
                // Tietoa vitamiineista ei lˆytynyt
    },
    new Ruoka
    {
        Kategoria = "Liha",
        Laji = "Nauta", // "Naudanliha, lyhyt ulkofilee, t-bone pihvi..." L‰hde: https://fdc.nal.usda.gov/fdc-app.html#/food-details/746763/nutrients
        Aineet = new List<(string Nimi, float Arvo)>
        {   // Tarkista viel‰ arvot
            ("Natrium", 67.0f), ("Potassium", 283.0f), ("Kalsium", 19.0f), ("Fosfori", 211.0f), ("Magnesuum", 0.003f),
            ("Rauta", 3.53f), ("Sinkki", 4.69f), ("Jodi", 0.0f), ("Kupari", 0.078f), ("VitA", 0.0f),
            ("VitC", 0.0f), ("VitD", 0.0f), ("VitE", 0.0f), ("VitK", 0.0f), ("VitB1", 0.0f),
            ("VitB2", 0.0f), ("VitB6", 0.75f), ("VitB12", 1.88f)/*(µg)*/, ("Kcal", 219.0f), ("Prot", 27.3f),
            ("HiHy", 0.0f), ("Sok", 0.0f), ("RasvaP", 0.0f), ("RasvaK", 0.0f), ("Kuidut", 0.0f),
        }
    },
    new Ruoka
    {
        Kategoria = "Liha",
        Laji = "Kana",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 19.6f),
            ("HiHy",  126), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
        }
    },
    // Kala-kategoria
    new Ruoka
    {
        Kategoria = "Kala",
        Laji = "Lohi",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 21), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
        }
    },
       new Ruoka
    {
        Kategoria = "Kala",
        Laji = "Tonnikala",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 21), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
        }
    },
    // Marjat-kategoria
    new Ruoka
    {
        Kategoria = "Marjat",
        Laji = " ",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 21), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
        }
    },
    // Hedelm‰t-kategoria
    new Ruoka
    {
        Kategoria = "Hedelm‰t",
        Laji = " ",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 21), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
        }
    },
    // Juurekset-kategoria
    new Ruoka
    {
        Kategoria = "Juurekset",
        Laji = " ",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 21), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
        }
    },
    // Vihannekset-kategoria
    new Ruoka
    {
        Kategoria = "Vihannekset",
        Laji = " ",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 21), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
        }
    },
    // P‰hkin‰t/Siemenet-kategoria
    new Ruoka
    {
        Kategoria = "P‰hkin‰t/Siemenet",
        Laji = " ",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 21), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
        }
    },
    // Viljat-kategoria
    new Ruoka
    {
        Kategoria = "Viljat",
        Laji = " ",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 21), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
        }
    },
    // Yrtit-kategoria
    new Ruoka
    {
        Kategoria = "Yrtit",
        Laji = " ",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 21), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
        }
    },
    // Sienet-kategoria
    new Ruoka
    {
        Kategoria = "Sienet",
        Laji = " ",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 21), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
        }
    },
    // Sipulit-kategoria
    new Ruoka
    {
        Kategoria = "Sipulit",
        Laji = " ",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 21), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
        }
    },
    // Rasvat-kategoria
    new Ruoka
    {
        Kategoria = "Rasvat",
        Laji = " ",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 21), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
        }
    },
    // Maitotuotteet-kategoria
    new Ruoka
    {
        Kategoria = "Maitotuotteet",
        Laji = " ",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 21), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
        }
    },
    // Muut-kategoria
    new Ruoka
    {
        Kategoria = "Muut",
        Laji = " ",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 0.0f), ("Potassium", 0.0f), ("Kalsium", 0.0f), ("Fosfori", 0.0f), ("Magnesuum", 0.0f),
            ("Rauta", 0.0f), ("Sinkki", 0.0f), ("Jodi", 0.0f), ("Kupari", 0.0f), ("VitA", 1.0f),
            ("VitC", 0.0f), ("VitD", 0.0f), ("VitE", 0.0f), ("VitK", 0.0f), ("VitB1", 0.0f),
            ("VitB2", 0.0f), ("VitB6", 0.0f), ("VitB12", 0.0f), ("Kcal", 0.0f), ("Prot", 0.0f),
            ("HiHy", 0.0f), ("Sok", 0.0f), ("RasvaP", 0.0f), ("RasvaK", 0.0f), ("Kuidut", 0.0f),
        }
    }
    // ... Muut kategoriat ja lajit
};



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
