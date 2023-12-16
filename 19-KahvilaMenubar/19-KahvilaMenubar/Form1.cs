namespace _19_KahvilaMenubar
{
    public partial class KahvilaMenubarForm : Form
    {
        public KahvilaMenubarForm()
        {
            InitializeComponent();
        }

        private void KahvilaMenubarForm_Load(object sender, EventArgs e)
        {
            // Voidaan syöttää teksti siinä vaiheessa kun formi ladataan, mutta on myös toinen tapa
            meistaLB.Text = "Keudan oppilaskunnan kahvila palelee luokassa 320 välituntisin \n";
            meistaLB.Text += "09:00 - 14:30 joka päivä maanantaista torstaihin ja perjantaisin \n";
            meistaLB.Text += "09:00 - 12:30 \n\n Keudan oppilaskunnan kahvilasta saa lämpimien \n";
            meistaLB.Text += "juomien lisäksi virvokkeita sekä pientä purtavaa ja makeisia \n";
            meistaLB.Text += "Tervetuloa tutustumaan! \n";
            meistaLB.Text += new Font("Arial", 12);
        }
    }
}
