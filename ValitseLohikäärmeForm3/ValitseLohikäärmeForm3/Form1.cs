namespace ValitseLohikäärmeForm3
{
    public partial class ValitseLohikaarmeesiForm : Form
    {
        public ValitseLohikaarmeesiForm()
        {
            InitializeComponent();
        }

        private string nimeni;
        private string text;    // AloitusLB.Text teksti tallennetaan tänne "on load"
        private int len = 0;    // int len = 0; jotta if lauseessa ohjelma tietää aloittaa indeksistä 0 eli ensimäisestä kirjaimesta merkkijonossa (string) = AloitusLB.Text
        private void timer1_Tick(object sender, EventArgs e) // [Design]->Toolbox->Timer = Interval 100
        {
            if (len < text.Length)
            {
                AloitusLB.Text = AloitusLB.Text + text.ElementAt(len);
                len++; // Tämä jos puuttuu, toistaa vain tekstin ensimmäistä kirjainta
            }
            else
            {
                timer1.Stop(); Thread.Sleep(1000);
                AloitaBT.Visible = true;
            }
        }

        private void ValitseLohikaarmeesiForm_Load(object sender, EventArgs e)
        {
            text = AloitusLB.Text; // Teksti joka ladataan formin käynnistyksessä tallennetaan stringiin text
            AloitusLB.Text = "";   // Määritetään se aluksi tyhjäksi
            timer1.Start();        // Aloitetaan toisto (timer1_Tick)
        }

        private void AloitaBT_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();

            AloitaBT.Enabled = false; // Varmuuden vuoksi, että alla oleva näppäin ei enää toimi. 
            /*    Text = BradGreensLB.Text;
                  BradGreensLB.Text = "";
                  timer1.Start();           //  Ei toiminut näin Yritän myöhennin käyttää uudestaan "Timer1"
            */

            /*  Malli Go-> Designer.cs -> panel1

             Panel P1 = new Panel();
             P1.Name = "Tervehdys";
             P1.Location = new System.Drawing.Point(0, 0);
             P1.Size = new Size(1000, 600);
             P1.BackColor = Color.LemonChiffon;
             Controls.Add(P1);
             P1.BringToFront();
             P1.Visible = true;
                                    // (Tämä on huono tapa) Ei ilmesty [Design] ikkunaan jos tekee manuaalisesti näin
            */
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            if (NameBox.Text.Length < 3 || NameBox.Text.Length > 14)
            {
                OkBT.Enabled = false;
            }
            else
            {
                OkBT.Enabled = true; // Näppäin toimii kun väh 3 kirjainta nimiboksissa
            }
        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            nimeni = NameBox.Text;
            NameBox.Visible = false;
            BradGreensLB.Text = "Tervetuloa " + nimeni + "! \n \nTehtäväni on auttaa sinua \nvalitsemaan itsellesi oma lohikäärme.";
         //   OkBT.Text = "Eiköhän mennä!";
         //   OkBT.Size = new Size(300, 50);
         //   OkBT.Location = new Point(528, 316);
            OkBT.Visible = false;
            OkBT.Enabled = false;
            mennaBT.BringToFront();
            mennaBT.Visible = true;
            mennaBT.Enabled = true;

        }

        private void mennaBT_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.BringToFront(); //Tähän mennessä kaikki toimii

        }

        private void AstuSisäänBT_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.BringToFront();
        }

        private void TuliOviBT_Click(object sender, EventArgs e)
        {
            TuliPanel.Visible = true;
        }

        private void KylmaOviBT_Click(object sender, EventArgs e)
        {
            kylmaPanel.Visible = true;
        }

        private void KuumaOviBT_Click(object sender, EventArgs e)
        {
            KuumaPanel.Visible = true;
        }

        private void TasaOviBT_Click(object sender, EventArgs e)
        {
            TasaPanel.Visible = true;
        }

        private void PalaaBT1_Click(object sender, EventArgs e)
        {
            TuliPanel.Visible = false;
        }

        private void PalaaBT2_Click(object sender, EventArgs e)
        {
            kylmaPanel.Visible = false;
        }

        private void PalaaBT3_Click(object sender, EventArgs e)
        {
            KuumaPanel.Visible = false;
        }

        private void PalaaBT4_Click(object sender, EventArgs e)
        {
            TasaPanel.Visible = false;
        }

        private void pictureBoxHydroEgg_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxArctikEgg_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBlackEgg_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxGoldenEgg_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxElectraEgg_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxGreenEgg_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxCopperEgg_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxKristalliEgg_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxAmberEgg_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxEmberEgg_Click(object sender, EventArgs e)
        {
            AmberPanel.Visible = true;
            AmberPanel.BringToFront();
        }

        private void EmberPoistuBT_Click(object sender, EventArgs e)
        {
            AmberPanel.Visible = false;
            TuliPanel.BringToFront();
            AmberPanel.SendToBack();
        }
    }
}