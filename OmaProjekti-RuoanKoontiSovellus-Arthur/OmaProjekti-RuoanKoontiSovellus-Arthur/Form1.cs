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
            public List<int[]> Aineet { get; set; } = new List<int[]>();
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
        Aineet = new List<int[]>
        {
            new int[] { }
        }
    },
    // Liha-kategoria
    new Ruoka
    {
        Kategoria = "Liha",
        Laji = "Sika",
        Aineet = new List<int[]>
        {
            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 }
        }
    },
    // Kala-kategoria
    new Ruoka
    {
        Kategoria = "Kala",
        Laji = "Lohi",
        Aineet = new List<int[]>
        {
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, }

        }
    },
    // Marjat-kategoria
    new Ruoka
    {
        Kategoria = "Marjat",
        Laji = " ",
        Aineet = new List<int[]>
        {
            new int[] {  }
        }
    },
    // Hedelmät-kategoria
    new Ruoka
    {
        Kategoria = "Hedelmät",
        Laji = " ",
        Aineet = new List<int[]>
        {
            new int[] {  }
        }
    },
    // Juurekset-kategoria
    new Ruoka
    {
        Kategoria = "Juurekset",
        Laji = " ",
        Aineet = new List<int[]>
        {
            new int[] { }
        }
    },
    // Vihannekset-kategoria
    new Ruoka
    {
        Kategoria = "Vihannekset",
        Laji = " ",
        Aineet = new List<int[]>
        {
            new int[] { }
        }
    },
    // Pähkinät/Siemenet-kategoria
    new Ruoka
    {
        Kategoria = "Pähkinät/Siemenet",
        Laji = " ",
        Aineet = new List<int[]>
        {
            new int[] { }
        }
    },
    // Viljat-kategoria
    new Ruoka
    {
        Kategoria = "Viljat",
        Laji = " ",
        Aineet = new List<int[]>
        {
            new int[] { }
        }
    },
    // Yrtit-kategoria
    new Ruoka
    {
        Kategoria = "Yrtit",
        Laji = " ",
        Aineet = new List<int[]>
        {
            new int[] { }
        }
    },
    // Sienet-kategoria
    new Ruoka
    {
        Kategoria = "Sienet",
        Laji = " ",
        Aineet = new List<int[]>
        {
            new int[] { }
        }
    },
    // Sipulit-kategoria
    new Ruoka
    {
        Kategoria = "Sipulit",
        Laji = " ",
        Aineet = new List<int[]>
        {
            new int[] { }
        }
    },
    // Rasvat-kategoria
    new Ruoka
    {
        Kategoria = "Rasvat",
        Laji = " ",
        Aineet = new List<int[]>
        {
            new int[] { }
        }
    },
    // Maitotuotteet-kategoria
    new Ruoka
    {
        Kategoria = "Maitotuotteet",
        Laji = " ",
        Aineet = new List<int[]>
        {
            new int[] { }
        }
    },
    // Muut-kategoria
    new Ruoka
    {
        Kategoria = "Muut",
        Laji = " ",
        Aineet = new List<int[]>
        {
            new int[] { }
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
