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
            // Voidaan sy�tt�� teksti siin� vaiheessa kun formi ladataan, mutta on my�s toinen tapa
            meistaLB.Text = "Keudan oppilaskunnan kahvila palelee luokassa 320 v�lituntisin \n";
            meistaLB.Text += "09:00 - 14:30 joka p�iv� maanantaista torstaihin ja perjantaisin \n";
            meistaLB.Text += "09:00 - 12:30 \n\n Keudan oppilaskunnan kahvilasta saa l�mpimien \n";
            meistaLB.Text += "juomien lis�ksi virvokkeita sek� pient� purtavaa ja makeisia \n";
            meistaLB.Text += "Tervetuloa tutustumaan! \n";
            meistaLB.Text += new Font("Arial", 12);
        }
    }
}
