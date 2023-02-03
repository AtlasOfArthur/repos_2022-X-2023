using System.Drawing.Imaging;

namespace ValitseLohikäärmeForm
{
    public partial class HautomoPeliForm : Form
    {


        public HautomoPeliForm()
        {
            InitializeComponent();

        }

        private void StartBT_Click(object sender, EventArgs e) // Aloituspanelin näppäin
        {
            AloitusPaneli.Visible = false;
            NimenvalintaPaneli.Visible = true;
        }

        private void NamingBox_TextChanged(object sender, EventArgs e)
        {
            if (NamingBox.Text.Length < 3 || NamingBox.Text.Length > 14) // Pitää olla väh 3 kirjainta nimessä. Max 15 
            {
                OkBT.Enabled = false;
            }
            else
            {
                OkBT.Enabled = true;
            }
        }
        
        private void NimiBT_Click(object sender, EventArgs e)
        {
            string nimeni = NamingBox.Text;
            GreenEsittäytLB.Text = "Tervetuloa " + nimeni + "!";
            NamingBox.Visible = false;
            GreenPuheLB.Text = "Tehtäväni on auttaa sinua valitsemaan itsellesi oma lohikäärme.";
            OkBT.Visible = false;
            EikohanMennaBT.Visible = true;
            EikohanMennaBT.Enabled= true;
        }

        private void EikohanMennaBT_Click(object sender, EventArgs e)
        {
            NimenvalintaPaneli.Visible = false;
            EikohanMennaBT.Visible = false;
            HautomoTaloPaneli.Visible = true;
        }

        private void OnValitaBT_Click(object sender, EventArgs e)
        {
            HautomoTaloPaneli.Visible=false;
        }

        private void BT1_Click(object sender, EventArgs e)
        {

        }

        private void BT2_Click(object sender, EventArgs e)
        {

        }

        private void BT3_Click(object sender, EventArgs e)
        {

        }

        private void BT4_Click(object sender, EventArgs e)
        {

        }

    }
}