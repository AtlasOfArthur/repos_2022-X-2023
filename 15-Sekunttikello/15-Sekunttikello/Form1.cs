using System.Diagnostics;

namespace _15_Sekunttikello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Stopwatch sekkari; // Muodostetaan uusi olio, eli objekti "sekkari", joka toimii vain t‰m‰n sis‰ll‰
        private void timer1_Tick(object sender, EventArgs e)
        {
            /// AikaLB.Text = sekkari.Elapsed.ToString(); Toimisi muuten n‰in, mutta tulee kauheesti desimaaleja
            /// joten kannattaa k‰ytt‰‰ string.Format metodia
            AikaLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }

        private void K‰ynnist‰BT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void Pys‰yt‰BT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void Tyhjenn‰BT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sekkari = new Stopwatch(); // T‰m‰ resetoi, eli tekee uuden olion (objektin) aina kun formi loadataan
        }
    }
}
