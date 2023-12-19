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
            public List<(string Nimi, int Arvo)> Aineet { get; set; } = new List<(string Nimi, int Arvo)>();
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
        Aineet = new List<(string Nimi, int Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 21), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
        }
    },
    // Liha-kategoria
    new Ruoka
    {
        Kategoria = "Liha",
        Laji = "Sika",
        Aineet = new List<(string Nimi, int Arvo)>
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
        Laji = "Nauta",
                Aineet = new List<(string Nimi, int Arvo)>
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
        Laji = "Sika",
                Aineet = new List<(string Nimi, int Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 21), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
        }
    },
    // Kala-kategoria
    new Ruoka
    {
        Kategoria = "Kala",
        Laji = "Lohi",
                Aineet = new List<(string Nimi, int Arvo)>
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
                Aineet = new List<(string Nimi, int Arvo)>
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
                Aineet = new List<(string Nimi, int Arvo)>
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
                Aineet = new List<(string Nimi, int Arvo)>
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
                Aineet = new List<(string Nimi, int Arvo)>
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
        Aineet = new List<(string Nimi, int Arvo)>
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
                Aineet = new List<(string Nimi, int Arvo)>
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
                Aineet = new List<(string Nimi, int Arvo)>
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
                Aineet = new List<(string Nimi, int Arvo)>
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
                Aineet = new List<(string Nimi, int Arvo)>
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
                Aineet = new List<(string Nimi, int Arvo)>
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
                Aineet = new List<(string Nimi, int Arvo)>
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
                Aineet = new List<(string Nimi, int Arvo)>
        {
            ("Natrium", 1), ("Potassium", 2), ("Kalsium", 3), ("Fosfori", 4), ("Magnesuum", 5),
            ("Rauta", 6), ("Sinkki", 7), ("Jodi", 8), ("Kupari", 9), ("VitA", 10),
            ("VitC", 11), ("VitD", 12), ("VitE", 13), ("VitK", 14), ("VitB1", 15),
            ("VitB2", 16), ("VitB6", 17), ("VitB12", 18), ("Kcal", 19), ("Prot", 20),
            ("HiHy", 21), ("Sok", 22), ("RasvaP", 23), ("RasvaK", 24), ("Kuidut", 25),
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
