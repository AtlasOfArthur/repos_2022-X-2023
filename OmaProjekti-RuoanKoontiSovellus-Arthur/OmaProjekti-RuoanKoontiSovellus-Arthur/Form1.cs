using System.Data;

namespace OmaProjekti_RuoanKoontiSovellus_Arthur
{


    public partial class AterianKoontiForm : Form
    {
        public Dictionary<string, Dictionary<string, float>> LaskutoimitusDictionary { get; set; } = new Dictionary<string, Dictionary<string, float>>();
        // Edell‰ on alustus kaksiulotteiselle Dictionarylle laskutoimitusta varten (Ei mit‰‰n hajua miten t‰m‰ pit‰isi kirjoittaa)
        public Dictionary<string, float> VastausDictionary { get; set; } = new Dictionary<string, float>();
        // Edell‰ on alustus yksiulotteiselle dictionarylle johon vastaus tallennetaan ja sielt‰ se siirret‰‰n labeleille (Tai se on ainakin ajatu
        
        public AterianKoontiForm()
        {
            InitializeComponent();
            KategoriaCB.SelectedIndexChanged += KategoriaCB_ValittuKategoriaVaihdettu;

            // Luo tapahtumank‰sittelij‰ ValinnatFlowLayoutPanelin ControlRemoved-tapahtumalle
            ValinnatFlowLayoutPanel.ControlRemoved += (sender, e) =>
            {
             
            };
        }
        public class Ruoka
        {
            public string Kategoria { get; set; } = "";
            public string Laji { get; set; } = "";
            public Dictionary<string, float > Aineet { get; set; } = new Dictionary<string, float>();
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
            //---------------------------Kategoriat comboboksiin----------------------------//

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
            //--------------Ruokalajit kategorioista toiseen comboboksiin-------------------//

            // Lis‰‰ LajiiCB:st‰ valitun ruokalajin ValinnatFlowLayoutPaneliin
            string valittuRuokaLaji = LajiCB.SelectedItem.ToString();

            // Lis‰‰ uuden labelin ja kullekkin luodulle Labelille myˆs poista buttonin
            Label uusiLabel = new Label();
            uusiLabel.Text = valittuRuokaLaji;
            uusiLabel.Font = new Font("Script MT Bold", 11);
            Button uusiButton = new Button();
            uusiButton.Text = "Poista";
            uusiButton.Font = new Font(uusiButton.Font.FontFamily, 8, FontStyle.Bold);
            uusiButton.Size = new Size(75, 26);

            // Lis‰t‰‰n luotu Label ja Button FlowLayoutPaneliin
            ValinnatFlowLayoutPanel.Controls.Add(uusiLabel);
            ValinnatFlowLayoutPanel.Controls.Add(uusiButton);
            // K‰ynnist‰‰ automaattisen vierityksen kun ValinnatFlowLayoutPanel tulee t‰yteen
            ValinnatFlowLayoutPanel.AutoScroll = true;


            //--------------Arvot FlowLayoutin tavaroilta omille labeleillensa--------------//

            // Etsii ruoan, joka vastaa valittua ruokalajia
            var valittuRuoka = ruokaLista.FirstOrDefault(ruoka => ruoka.Laji == valittuRuokaLaji);


            //---------------------Button ja Label FlowLayout paneliin----------------------//

            // Lis‰t‰‰n poista buttonin ja labelin poiston tapahtumank‰sittelij‰ suoraan t‰h‰n
            uusiButton.Click += (s, args) =>
            {
                if (s is Button poistaButton)
                {
                    int indeksi = ValinnatFlowLayoutPanel.Controls.IndexOf(poistaButton);

                    if (indeksi != -1)
                    {
                        // Poistaa Labelin ja sen j‰lkeen myˆs Buttonin
                        ValinnatFlowLayoutPanel.Controls.RemoveAt(indeksi - 1); // Label
                        ValinnatFlowLayoutPanel.Controls.RemoveAt(indeksi - 1); // Button

                        // Tyhjennet‰‰n LaskutoimitusDictionary jotta tulos s‰ilyy oikeana
                        LaskutoimitusDictionary.Clear();
                        // P‰ivitet‰‰n KaikkienAineidenArvot poiston j‰lkeen
                        LaskeLisattujenAineidenArvot();
                    }
                }
            };

            // Lis‰t‰‰n aineet LaskutoimitusDictionaryyn
            Lis‰‰AineLaskutoimitusDictionaryyn(valittuRuoka.Aineet);

            // P‰ivitet‰‰n KaikkienAineidenArvot lis‰yksen j‰lkeen
            LaskeLisattujenAineidenArvot();

            // P‰ivitet‰‰n labelit
            NaytaKaikkienAineidenArvotLabeleilla(); // Ei toimi
        }

        //---------------------LaskutoimitusDictionary aineiden lis‰ys----------------------//
        private void Lis‰‰AineLaskutoimitusDictionaryyn(Dictionary<string, float> aineet)
        {
            if (aineet != null)
            {
                foreach (var aine in aineet)
                {
                    if (!LaskutoimitusDictionary.ContainsKey(aine.Key))
                    {
                        LaskutoimitusDictionary.Add(aine.Key, new Dictionary<string, float>());
                    }

                    LaskutoimitusDictionary[aine.Key][aine.Key] = aine.Value;
                }
            }
        }

        //----------------LaskutoimitusDictionary aineiden arvojen p‰ivitys-----------------//
        private void LaskeLisattujenAineidenArvot()
        {
            VastausDictionary.Clear();

            foreach (var aine in LaskutoimitusDictionary)
            {
                // Tyypittele jokainen kohde `Dictionary<string, float>`-objektiksi
                var LaskutoimitusDictionary = (Dictionary<string, float>)aine.Value;

                // Tyypittele `Name`-ominaisuus `string`-tyypiksi
                foreach (var aineenNimi in LaskutoimitusDictionary.Keys)
                {
                    // Lis‰‰ `Value`-arvo `VastausDictionary`yn
                    VastausDictionary[aineenNimi] = LaskutoimitusDictionary[aineenNimi];
                }
            }
        }

        //----------------------------Aineiden arvot labeleille-----------------------------//
        private void NaytaKaikkienAineidenArvotLabeleilla()
        {
            foreach (var aineenNimi in VastausDictionary.Keys)
            {
                var label = ValinnatFlowLayoutPanel.Controls.Find($"Aine{aineenNimi}", true).FirstOrDefault() as Label;

                if (label != null)
                {
                    label.Text = VastausDictionary[aineenNimi].ToString();
                }
            }
        }
        //------------------------------------------------------------------------------//


        List<Ruoka> ruokaLista = new List<Ruoka>
{
    // Jos arvot 0.0f, ei ole silloin v‰ltt‰m‰tt‰ tiedossa
    // Tyhj‰ kategoria
    new Ruoka
    {
        Kategoria = " ",
        Laji = " ",
        Aineet = new Dictionary<string, float>
        {
            // Tyhj‰ valinta KategoriaCB ensimm‰isess‰ indeksiss‰
        }
    },
    new Ruoka
    {
        Kategoria = "Liha",
        Laji = "Sika", // "Kinkku, viipaloitu, ravintola" L‰hde: https://fdc.nal.usda.gov/fdc-app.html#/food-details/746952/nutrients
        Aineet = new Dictionary<string, float>
        {   // Arvot pit‰‰ p‰ivitt‰‰, koska todenn‰kˆisesti tiedot maustetusta lihasta !!!! (Natrium korkea)
            {"NatriumArvoLB", 1030.0f},
            {"PotassiumArvoLB", 484.0f},
            {"KaliumArvoLB", 6.0f},
            {"FosforiArvoLB", 424.0f},
            {"MagnesiumArvoLB", 0.015f},
            {"RautaArvoLB", 0.86f},
            {"SinkkiArvoLB", 1.76f},
            {"JodiArvoLB", 0.0f},
            {"KupariArvoLB", 0.041f},
            {"AArvoLB", 10},
            {"CArvoLB", 0.0f},
            {"DArvoLB", 0.0f},
            {"EArvoLB", 0.0f},
            {"KArvoLB", 0.0f},
            {"B1ArvoLB", 0.0f},
            {"B2ArvoLB", 0.0f},
            {"B6ArvoLB", 0.0f},
            {"B12ArvoLB", 0.0f},
            {"KCalArvoLB", 216.0f},
            {"ProteinArvoLB", 19.6f},
            {"HiHyArvoLB", 2.36f},
            {"SokeriArvoLB", 2.2f},
            {"PrasvaLB", 2.275f},
            {"KrasvaLB", 1.25f},
            {"KuidutLB", 0.0f},
        }// Note! Fatty acids, total monounsaturated + Fatty acids, total polyunsaturated = RasvaP
          // Tietoa vitamiineista ei lˆytynyt
    },
    new Ruoka
    {
        Kategoria = "Liha",
        Laji = "Nauta", // "Naudanliha, lyhyt ulkofilee, t-bone pihvi..." L‰hde: https://fdc.nal.usda.gov/fdc-app.html#/food-details/746763/nutrients
        Aineet = new Dictionary<string, float>
        {   // Tarkista viel‰ arvot
            { "NatriumArvoLB", 67.0f },
            { "PotassiumArvoLB", 283.0f },
            { "KaliumArvoLB", 19.0f },
            { "FosforiArvoLB", 211.0f},
            { "MagnesiumArvoLB", 3.53f },
            { "RautaArvoLB", 0.00f },
            { "SinkkiArvoLB", 4.69f },
            { "JodiArvoLB", 0.0f },
            { "KupariArvoLB", 0.078f },
            { "AArvoLB", 0.0f }, 
            { "CArvoLB", 0.0f },
            { "DArvoLB", 0.0f },
            { "EArviLB", 0.0f },
            { "KArvoLB", 0.0f },
            { "B1ArvoLB", 0.0f },
            { "B2ArvoLB", 0.0f },
            { "B6ArvoLB", 0.75f },
            { "B12ArvoLB", 1.88f },//(µg)
            { "KCalArvoLB", 219.0f },
            { "ProteinArvoLB", 27.3f },
            { "HiHyArvoLB", 0.0f },
            { "SokeriArvoLB", 0.0f },
            { "PrasvaLB", 0.0f },
            { "KrasvaLB", 0.0f },
            { "KuidutLB", 0.0f },
        }
    },
    new Ruoka
    {
        Kategoria = "Liha",
        Laji = "Kana",
        Aineet = new Dictionary<string, float>
        {
            { "NatriumArvoLB", 0.0f },
            { "PotassiumArvoLB", 0.0f },
            { "KaliumArvoLB", 0.0f },
            { "FosforiArvoLB", 0.0f },
            { "MagnesiumArvoLB", 0.0f },
            { "RautaArvoLB", 0.0f }, 
            { "SinkkiArvoLB", 0.0f }, 
            { "JodiArvoLB", 0.0f }, 
            { "KupariArvoLB", 0.0f }, 
            { "AArvoLB", 0.0f },
            { "CArvoLB", 0.0f }, 
            { "DArvoLB", 0.0f }, 
            { "EArvoLB", 0.0f }, 
            { "KArvoLB", 0.0f }, 
            { "B1ArvoLB", 0.0f }, 
            { "B2ArvoLB", 0.0f }, 
            { "B6ArvoLB", 0.0f }, 
            { "B12ArvoLB", 0.0f }, 
            { "KCalArvoLB", 0.0f }, 
            { "ProteinArvoLB", 0.0f },
            { "HiHyArvoLB", 0.0f }, 
            { "SokeriArvoLB", 0.0f }, 
            { "PrasvaLB", 0.0f }, 
            { "KrasvaLB", 0.0f }, 
            { "KuidutLB", 0.0f },
        }
    },
    // Kala-kategoria
    new Ruoka
    {
        Kategoria = "Kala",
        Laji = "Lohi",
        Aineet = new Dictionary<string, float>
        {
            { "NatriumArvoLB", 0.0f },
            { "PotassiumArvoLB", 0.0f },
            { "KaliumArvoLB", 0.0f },
            { "FosforiArvoLB", 0.0f },
            { "MagnesiumArvoLB", 0.0f },
            { "RautaArvoLB", 0.0f },
            { "SinkkiArvoLB", 0.0f },
            { "JodiArvoLB", 0.0f },
            { "KupariArvoLB", 0.0f },
            { "AArvoLB", 0.0f },
            { "CArvoLB", 0.0f },
            { "DArvoLB", 0.0f },
            { "EArvoLB", 0.0f },
            { "KArvoLB", 0.0f },
            { "B1ArvoLB", 0.0f },
            { "B2ArvoLB", 0.0f },
            { "B6ArvoLB", 0.0f },
            { "B12ArvoLB", 0.0f },
            { "KCalArvoLB", 0.0f },
            { "ProteinArvoLB", 0.0f },
            { "HiHyArvoLB", 0.0f },
            { "SokeriArvoLB", 0.0f },
            { "PrasvaLB", 0.0f },
            { "KrasvaLB", 0.0f },
            { "KuidutLB", 0.0f },
        }
    },
        new Ruoka
    {
        Kategoria = "Kala",
        Laji = "Tonnikala",
        Aineet = new Dictionary<string, float>
        {
             { "NatriumArvoLB", 0.0f },
            { "PotassiumArvoLB", 0.0f },
            { "KaliumArvoLB", 0.0f },
            { "FosforiArvoLB", 0.0f },
            { "MagnesiumArvoLB", 0.0f },
            { "RautaArvoLB", 0.0f },
            { "SinkkiArvoLB", 0.0f },
            { "JodiArvoLB", 0.0f },
            { "KupariArvoLB", 0.0f },
            { "AArvoLB", 0.0f },
            { "CArvoLB", 0.0f },
            { "DArvoLB", 0.0f },
            { "EArvoLB", 0.0f },
            { "KArvoLB", 0.0f },
            { "B1ArvoLB", 0.0f },
            { "B2ArvoLB", 0.0f },
            { "B6ArvoLB", 0.0f },
            { "B12ArvoLB", 0.0f },
            { "KCalArvoLB", 0.0f },
            { "ProteinArvoLB", 0.0f },
            { "HiHyArvoLB", 0.0f },
            { "SokeriArvoLB", 0.0f },
            { "PrasvaLB", 0.0f },
            { "KrasvaLB", 0.0f },
            { "KuidutLB", 0.0f },
        }
    },
    // Marjat-kategoria
    new Ruoka
    {
        Kategoria = "Marjat",
        Laji = " ",
        Aineet = new Dictionary<string, float>
        {
            { "NatriumArvoLB", 0.0f },
            { "PotassiumArvoLB", 0.0f },
            { "KaliumArvoLB", 0.0f },
            { "FosforiArvoLB", 0.0f },
            { "MagnesiumArvoLB", 0.0f },
            { "RautaArvoLB", 0.0f },
            { "SinkkiArvoLB", 0.0f },
            { "JodiArvoLB", 0.0f },
            { "KupariArvoLB", 0.0f },
            { "AArvoLB", 0.0f },
            { "CArvoLB", 0.0f },
            { "DArvoLB", 0.0f },
            { "EArvoLB", 0.0f },
            { "KArvoLB", 0.0f },
            { "B1ArvoLB", 0.0f },
            { "B2ArvoLB", 0.0f },
            { "B6ArvoLB", 0.0f },
            { "B12ArvoLB", 0.0f },
            { "KCalArvoLB", 0.0f },
            { "ProteinArvoLB", 0.0f },
            { "HiHyArvoLB", 0.0f },
            { "SokeriArvoLB", 0.0f },
            { "PrasvaLB", 0.0f },
            { "KrasvaLB", 0.0f },
            { "KuidutLB", 0.0f },
        }
    },
    // Hedelm‰t-kategoria
    new Ruoka
    {
        Kategoria = "Hedelm‰t",
        Laji = " ",
        Aineet = new Dictionary<string, float>
        {
            { "NatriumArvoLB", 0.0f },
            { "PotassiumArvoLB", 0.0f },
            { "KaliumArvoLB", 0.0f },
            { "FosforiArvoLB", 0.0f },
            { "MagnesiumArvoLB", 0.0f },
            { "RautaArvoLB", 0.0f },
            { "SinkkiArvoLB", 0.0f },
            { "JodiArvoLB", 0.0f },
            { "KupariArvoLB", 0.0f },
            { "AArvoLB", 0.0f },
            { "CArvoLB", 0.0f },
            { "DArvoLB", 0.0f },
            { "EArvoLB", 0.0f },
            { "KArvoLB", 0.0f },
            { "B1ArvoLB", 0.0f },
            { "B2ArvoLB", 0.0f },
            { "B6ArvoLB", 0.0f },
            { "B12ArvoLB", 0.0f },
            { "KCalArvoLB", 0.0f },
            { "ProteinArvoLB", 0.0f },
            { "HiHyArvoLB", 0.0f },
            { "SokeriArvoLB", 0.0f },
            { "PrasvaLB", 0.0f },
            { "KrasvaLB", 0.0f },
            { "KuidutLB", 0.0f },
        }
    },
    // Juurekset-kategoria
    new Ruoka
    {
        Kategoria = "Juurekset",
        Laji = " ",
        Aineet = new Dictionary<string, float>
        {
            { "NatriumArvoLB", 0.0f },
            { "PotassiumArvoLB", 0.0f },
            { "KaliumArvoLB", 0.0f },
            { "FosforiArvoLB", 0.0f },
            { "MagnesiumArvoLB", 0.0f },
            { "RautaArvoLB", 0.0f },
            { "SinkkiArvoLB", 0.0f },
            { "JodiArvoLB", 0.0f },
            { "KupariArvoLB", 0.0f },
            { "AArvoLB", 0.0f },
            { "CArvoLB", 0.0f },
            { "DArvoLB", 0.0f },
            { "EArvoLB", 0.0f },
            { "KArvoLB", 0.0f },
            { "B1ArvoLB", 0.0f },
            { "B2ArvoLB", 0.0f },
            { "B6ArvoLB", 0.0f },
            { "B12ArvoLB", 0.0f },
            { "KCalArvoLB", 0.0f },
            { "ProteinArvoLB", 0.0f },
            { "HiHyArvoLB", 0.0f },
            { "SokeriArvoLB", 0.0f },
            { "PrasvaLB", 0.0f },
            { "KrasvaLB", 0.0f },
            { "KuidutLB", 0.0f },
        }
    },
    // Vihannekset-kategoria
    new Ruoka
    {
        Kategoria = "Vihannekset",
        Laji = " ",
        Aineet = new Dictionary<string, float>
        {
            { "NatriumArvoLB", 0.0f },
            { "PotassiumArvoLB", 0.0f },
            { "KaliumArvoLB", 0.0f },
            { "FosforiArvoLB", 0.0f },
            { "MagnesiumArvoLB", 0.0f },
            { "RautaArvoLB", 0.0f },
            { "SinkkiArvoLB", 0.0f },
            { "JodiArvoLB", 0.0f },
            { "KupariArvoLB", 0.0f },
            { "AArvoLB", 0.0f },
            { "CArvoLB", 0.0f },
            { "DArvoLB", 0.0f },
            { "EArvoLB", 0.0f },
            { "KArvoLB", 0.0f },
            { "B1ArvoLB", 0.0f },
            { "B2ArvoLB", 0.0f },
            { "B6ArvoLB", 0.0f },
            { "B12ArvoLB", 0.0f },
            { "KCalArvoLB", 0.0f },
            { "ProteinArvoLB", 0.0f },
            { "HiHyArvoLB", 0.0f },
            { "SokeriArvoLB", 0.0f },
            { "PrasvaLB", 0.0f },
            { "KrasvaLB", 0.0f },
            { "KuidutLB", 0.0f },
        }
    },
    // P‰hkin‰t/Siemenet-kategoria
    new Ruoka
    {
        Kategoria = "P‰hkin‰t/Siemenet",
        Laji = " ",
        Aineet = new Dictionary<string, float>
        {
            { "NatriumArvoLB", 0.0f },
            { "PotassiumArvoLB", 0.0f },
            { "KaliumArvoLB", 0.0f },
            { "FosforiArvoLB", 0.0f },
            { "MagnesiumArvoLB", 0.0f },
            { "RautaArvoLB", 0.0f },
            { "SinkkiArvoLB", 0.0f },
            { "JodiArvoLB", 0.0f },
            { "KupariArvoLB", 0.0f },
            { "AArvoLB", 0.0f },
            { "CArvoLB", 0.0f },
            { "DArvoLB", 0.0f },
            { "EArvoLB", 0.0f },
            { "KArvoLB", 0.0f },
            { "B1ArvoLB", 0.0f },
            { "B2ArvoLB", 0.0f },
            { "B6ArvoLB", 0.0f },
            { "B12ArvoLB", 0.0f },
            { "KCalArvoLB", 0.0f },
            { "ProteinArvoLB", 0.0f },
            { "HiHyArvoLB", 0.0f },
            { "SokeriArvoLB", 0.0f },
            { "PrasvaLB", 0.0f },
            { "KrasvaLB", 0.0f },
            { "KuidutLB", 0.0f },
        }
    },
    // Viljat-kategoria
    new Ruoka
    {
        Kategoria = "Viljat",
        Laji = " ",
        Aineet = new Dictionary<string, float>
        {
            { "NatriumArvoLB", 0.0f },
            { "PotassiumArvoLB", 0.0f },
            { "KaliumArvoLB", 0.0f },
            { "FosforiArvoLB", 0.0f },
            { "MagnesiumArvoLB", 0.0f },
            { "RautaArvoLB", 0.0f },
            { "SinkkiArvoLB", 0.0f },
            { "JodiArvoLB", 0.0f },
            { "KupariArvoLB", 0.0f },
            { "AArvoLB", 0.0f },
            { "CArvoLB", 0.0f },
            { "DArvoLB", 0.0f },
            { "EArvoLB", 0.0f },
            { "KArvoLB", 0.0f },
            { "B1ArvoLB", 0.0f },
            { "B2ArvoLB", 0.0f },
            { "B6ArvoLB", 0.0f },
            { "B12ArvoLB", 0.0f },
            { "KCalArvoLB", 0.0f },
            { "ProteinArvoLB", 0.0f },
            { "HiHyArvoLB", 0.0f },
            { "SokeriArvoLB", 0.0f },
            { "PrasvaLB", 0.0f },
            { "KrasvaLB", 0.0f },
            { "KuidutLB", 0.0f },
        }
    },
    // Yrtit-kategoria
    new Ruoka
    {
        Kategoria = "Yrtit",
        Laji = " ",
        Aineet = new Dictionary<string, float>
        {
            { "NatriumArvoLB", 0.0f },
            { "PotassiumArvoLB", 0.0f },
            { "KaliumArvoLB", 0.0f },
            { "FosforiArvoLB", 0.0f },
            { "MagnesiumArvoLB", 0.0f },
            { "RautaArvoLB", 0.0f },
            { "SinkkiArvoLB", 0.0f },
            { "JodiArvoLB", 0.0f },
            { "KupariArvoLB", 0.0f },
            { "AArvoLB", 0.0f },
            { "CArvoLB", 0.0f },
            { "DArvoLB", 0.0f },
            { "EArvoLB", 0.0f },
            { "KArvoLB", 0.0f },
            { "B1ArvoLB", 0.0f },
            { "B2ArvoLB", 0.0f },
            { "B6ArvoLB", 0.0f },
            { "B12ArvoLB", 0.0f },
            { "KCalArvoLB", 0.0f },
            { "ProteinArvoLB", 0.0f },
            { "HiHyArvoLB", 0.0f },
            { "SokeriArvoLB", 0.0f },
            { "PrasvaLB", 0.0f },
            { "KrasvaLB", 0.0f },
            { "KuidutLB", 0.0f },
        }
    },
    // Sienet-kategoria
    new Ruoka
    {
        Kategoria = "Sienet",
        Laji = " ",
        Aineet = new Dictionary<string, float>
        {
            { "NatriumArvoLB", 0.0f },
            { "PotassiumArvoLB", 0.0f },
            { "KaliumArvoLB", 0.0f },
            { "FosforiArvoLB", 0.0f },
            { "MagnesiumArvoLB", 0.0f },
            { "RautaArvoLB", 0.0f },
            { "SinkkiArvoLB", 0.0f },
            { "JodiArvoLB", 0.0f },
            { "KupariArvoLB", 0.0f },
            { "AArvoLB", 0.0f },
            { "CArvoLB", 0.0f },
            { "DArvoLB", 0.0f },
            { "EArvoLB", 0.0f },
            { "KArvoLB", 0.0f },
            { "B1ArvoLB", 0.0f },
            { "B2ArvoLB", 0.0f },
            { "B6ArvoLB", 0.0f },
            { "B12ArvoLB", 0.0f },
            { "KCalArvoLB", 0.0f },
            { "ProteinArvoLB", 0.0f },
            { "HiHyArvoLB", 0.0f },
            { "SokeriArvoLB", 0.0f },
            { "PrasvaLB", 0.0f },
            { "KrasvaLB", 0.0f },
            { "KuidutLB", 0.0f },
        }
    },
    // Sipulit-kategoria
    new Ruoka
    {
        Kategoria = "Sipulit",
        Laji = " ",
        Aineet = new Dictionary<string, float>
        {
            { "NatriumArvoLB", 0.0f },
            { "PotassiumArvoLB", 0.0f },
            { "KaliumArvoLB", 0.0f },
            { "FosforiArvoLB", 0.0f },
            { "MagnesiumArvoLB", 0.0f },
            { "RautaArvoLB", 0.0f },
            { "SinkkiArvoLB", 0.0f },
            { "JodiArvoLB", 0.0f },
            { "KupariArvoLB", 0.0f },
            { "AArvoLB", 0.0f },
            { "CArvoLB", 0.0f },
            { "DArvoLB", 0.0f },
            { "EArvoLB", 0.0f },
            { "KArvoLB", 0.0f },
            { "B1ArvoLB", 0.0f },
            { "B2ArvoLB", 0.0f },
            { "B6ArvoLB", 0.0f },
            { "B12ArvoLB", 0.0f },
            { "KCalArvoLB", 0.0f },
            { "ProteinArvoLB", 0.0f },
            { "HiHyArvoLB", 0.0f },
            { "SokeriArvoLB", 0.0f },
            { "PrasvaLB", 0.0f },
            { "KrasvaLB", 0.0f },
            { "KuidutLB", 0.0f },
        }
    },
    // Rasvat-kategoria
    new Ruoka
    {
        Kategoria = "Rasvat",
        Laji = " ",
        Aineet = new Dictionary<string, float>
        {
            { "NatriumArvoLB", 0.0f },
            { "PotassiumArvoLB", 0.0f },
            { "KaliumArvoLB", 0.0f },
            { "FosforiArvoLB", 0.0f },
            { "MagnesiumArvoLB", 0.0f },
            { "RautaArvoLB", 0.0f },
            { "SinkkiArvoLB", 0.0f },
            { "JodiArvoLB", 0.0f },
            { "KupariArvoLB", 0.0f },
            { "AArvoLB", 0.0f },
            { "CArvoLB", 0.0f },
            { "DArvoLB", 0.0f },
            { "EArvoLB", 0.0f },
            { "KArvoLB", 0.0f },
            { "B1ArvoLB", 0.0f },
            { "B2ArvoLB", 0.0f },
            { "B6ArvoLB", 0.0f },
            { "B12ArvoLB", 0.0f },
            { "KCalArvoLB", 0.0f },
            { "ProteinArvoLB", 0.0f },
            { "HiHyArvoLB", 0.0f },
            { "SokeriArvoLB", 0.0f },
            { "PrasvaLB", 0.0f },
            { "KrasvaLB", 0.0f },
            { "KuidutLB", 0.0f },
        }
    },
    // Maitotuotteet-kategoria
    new Ruoka
    {
        Kategoria = "Maitotuotteet",
        Laji = " ",
        Aineet = new Dictionary<string, float>
        {
            { "NatriumArvoLB", 0.0f },
            { "PotassiumArvoLB", 0.0f },
            { "KaliumArvoLB", 0.0f },
            { "FosforiArvoLB", 0.0f },
            { "MagnesiumArvoLB", 0.0f },
            { "RautaArvoLB", 0.0f },
            { "SinkkiArvoLB", 0.0f },
            { "JodiArvoLB", 0.0f },
            { "KupariArvoLB", 0.0f },
            { "AArvoLB", 0.0f },
            { "CArvoLB", 0.0f },
            { "DArvoLB", 0.0f },
            { "EArvoLB", 0.0f },
            { "KArvoLB", 0.0f },
            { "B1ArvoLB", 0.0f },
            { "B2ArvoLB", 0.0f },
            { "B6ArvoLB", 0.0f },
            { "B12ArvoLB", 0.0f },
            { "KCalArvoLB", 0.0f },
            { "ProteinArvoLB", 0.0f },
            { "HiHyArvoLB", 0.0f },
            { "SokeriArvoLB", 0.0f },
            { "PrasvaLB", 0.0f },
            { "KrasvaLB", 0.0f },
            { "KuidutLB", 0.0f },
        }
    },
    // Muut-kategoria
    new Ruoka
    {
        Kategoria = "Muut",
        Laji = " ",
        Aineet = new Dictionary<string, float>
        {
            { "NatriumArvoLB", 0.0f },
            { "PotassiumArvoLB", 0.0f },
            { "KaliumArvoLB", 0.0f },
            { "FosforiArvoLB", 0.0f },
            { "MagnesiumArvoLB", 0.0f },
            { "RautaArvoLB", 0.0f },
            { "SinkkiArvoLB", 0.0f },
            { "JodiArvoLB", 0.0f },
            { "KupariArvoLB", 0.0f },
            { "AArvoLB", 0.0f },
            { "CArvoLB", 0.0f },
            { "DArvoLB", 0.0f },
            { "EArvoLB", 0.0f },
            { "KArvoLB", 0.0f },
            { "B1ArvoLB", 0.0f },
            { "B2ArvoLB", 0.0f },
            { "B6ArvoLB", 0.0f },
            { "B12ArvoLB", 0.0f },
            { "KCalArvoLB", 0.0f },
            { "ProteinArvoLB", 0.0f },
            { "HiHyArvoLB", 0.0f },
            { "SokeriArvoLB", 0.0f },
            { "PrasvaLB", 0.0f },
            { "KrasvaLB", 0.0f },
            { "KuidutLB", 0.0f },
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
