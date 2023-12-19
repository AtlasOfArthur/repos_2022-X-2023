using System.Data;

namespace OmaProjekti_RuoanKoontiSovellus_Arthur
{


    public partial class AterianKoontiForm : Form
    {


        public AterianKoontiForm()
        {
            InitializeComponent();

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
                    KategoriaCB.Items.Add(ruoka.Kategoria);
                }
            }
        }



List<Ruoka> ruokaLista = new List<Ruoka>
{

    // Tyhjä kategoria
    new Ruoka
    {
        Kategoria = " ",
        Laji = " ",
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 0.0f), ("Potassium", 0.0f), ("Kalsium", 0.0f), ("Fosfori", 0.0f), ("Magnesuum", 0.0f),
            ("Rauta", 0.0f), ("Sinkki", 0.0f), ("Jodi", 0.0f), ("Kupari", 0.0f), ("VitA", 1.0f),
            ("VitC", 0.0f), ("VitD", 0.0f), ("VitE", 0.0f), ("VitK", 0.0f), ("VitB1", 0.0f),
            ("VitB2", 0.0f), ("VitB6", 0.0f), ("VitB12", 0.0f), ("Kcal", 0.0f), ("Prot", 0.0f),
            ("HiHy", 0.0f), ("Sok", 0.0f), ("RasvaP", 0.0f), ("RasvaK", 0.0f), ("Kuidut", 0.0f),
        }
    },
    // Liha-kategoria
    new Ruoka
    {
        Kategoria = "Liha",
        Laji = "Sika", // "Kinkku, viipaloitu, ravintola" Lähde: https://fdc.nal.usda.gov/fdc-app.html#/food-details/746952/nutrients
        Aineet = new List<(string Nimi, float Arvo)>
        {
            ("Natrium", 1030.0f), ("Potassium", 484.0f), ("Kalsium", 6.0f), ("Fosfori", 424.0f), ("Magnesuum", 0.015f),
            ("Rauta", 0.86f), ("Sinkki", 1.76f), ("Jodi", 0.0f), ("Kupari", 0.041f), ("VitA", 10),
            ("VitC", 0.0f), ("VitD", 0.0f), ("VitE", 0.0f), ("VitK", 0.0f), ("VitB1", 0.0f),
            ("VitB2", 0.0f), ("VitB6", 0.0f), ("VitB12", 0.0f), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 2.36f), ("Sok", 2.2f), ("RasvaP", 2.275f), ("RasvaK", 1.25f), ("Kuidut", 25),
        }// Note! Fatty acids, total monounsaturated + Fatty acids, total polyunsaturated = RasvaP
                // Tietoa vitamiineista ei löytynyt
    },
    new Ruoka
    {
        Kategoria = "Liha",
        Laji = "Nauta",
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
    // Hedelmät-kategoria
    new Ruoka
    {
        Kategoria = "Hedelmät",
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
    // Pähkinät/Siemenet-kategoria
    new Ruoka
    {
        Kategoria = "Pähkinät/Siemenet",
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
