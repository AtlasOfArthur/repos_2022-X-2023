namespace ValitseLohikäärmeForm3
{
    public partial class ValitseLohikaarmeesiForm : Form
    {
        public ValitseLohikaarmeesiForm()
        {
            InitializeComponent();
        }

        private int Ember, Amber, Crystal, Hydro, Arctic, Copper, Oil, Electra, Emerald, Royal;
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
            KIRJA.Visible = false;
        }

        private void KylmaOviBT_Click(object sender, EventArgs e)
        {
            kylmaPanel.Visible = true;
            KIRJA.Visible = false;
        }

        private void KuumaOviBT_Click(object sender, EventArgs e)
        {
            KuumaPanel.Visible = true;
            KIRJA.Visible = false;
        }

        private void TasaOviBT_Click(object sender, EventArgs e)
        {
            TasaPanel.Visible = true;
            KIRJA.Visible = false;
        }

        private void PalaaBT1_Click(object sender, EventArgs e)
        {
            TuliPanel.Visible = false;
            KIRJA.Visible = true;
        }

        private void PalaaBT2_Click(object sender, EventArgs e)
        {
            kylmaPanel.Visible = false;
            KIRJA.Visible = true;
        }

        private void PalaaBT3_Click(object sender, EventArgs e)
        {
            KuumaPanel.Visible = false;
            KIRJA.Visible = true;
        }

        private void PalaaBT4_Click(object sender, EventArgs e)
        {
            TasaPanel.Visible = false;
            KIRJA.Visible = true;
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

        private void AmberHelppoRB_CheckedChanged(object sender, EventArgs e)
        {
            if (AmberHelppoRB.Checked)
            {
                Amber = -1;
                Electra = -1;
                Hydro = -1;
                Royal = -2;
                Copper = -2;
                Ember = -2;
                Oil = -3;
                Crystal = 2;
                Arctic = 3;
                Emerald = 3;
                TulosAmber.Text = (Amber).ToString();
                TulosElectra.Text = (Electra).ToString();
                TulosHydro.Text = (Hydro).ToString();
                TulosRoyal.Text = (Royal).ToString();
                TulosCopper.Text = (Copper).ToString();
                TulosEmber.Text = (Ember).ToString();
                TulosOil.Text = (Oil).ToString();
                TulosCrystal.Text = (Crystal).ToString();
                TulosArctic.Text = (Arctic).ToString();
                TulosEmerald.Text = (Emerald).ToString();
                TulosAmber.Visible = true;
                TulosElectra.Visible = true;
                TulosHydro.Visible = true;
                TulosRoyal.Visible = true;
                TulosCopper.Visible = true;
                TulosEmber.Visible = true;
                TulosOil.Visible = true;
                TulosCrystal.Visible = true;
                TulosArctic.Visible = true;
                TulosEmerald.Visible = true;
            }
            else
            {
                Amber = 0;
                Electra = 0;
                Hydro = 0;
                Royal = 0;
                Copper = 0;
                Ember = 0;
                Oil = 0;
                Crystal = 0;
                Arctic = 0;
                Emerald = 0;
                TulosAmber.Text = (Amber).ToString();
                TulosElectra.Text = (Electra).ToString();
                TulosHydro.Text = (Hydro).ToString();
                TulosRoyal.Text = (Royal).ToString();
                TulosCopper.Text = (Copper).ToString();
                TulosEmber.Text = (Ember).ToString();
                TulosOil.Text = (Oil).ToString();
                TulosCrystal.Text = (Crystal).ToString();
                TulosArctic.Text = (Arctic).ToString();
                TulosEmerald.Text = (Emerald).ToString();
                TulosAmber.Visible = false;
                TulosElectra.Visible = false;
                TulosHydro.Visible = false;
                TulosRoyal.Visible = false;
                TulosCopper.Visible = false;
                TulosEmber.Visible = false;
                TulosOil.Visible = false;
                TulosCrystal.Visible = false;
                TulosArctic.Visible = false;
                TulosEmerald.Visible = false;
            }
        }
        private void AmberHelpohkoRB_Click(object sender, EventArgs e)
        {
            if (AmberHelppoRB.Checked)
            {
                TulosAmber.Text = (Amber = 1).ToString();
                TulosElectra.Text = (Electra = 1).ToString();
                TulosHydro.Text = (Hydro = 1).ToString();
                TulosRoyal.Text = (Royal = -2).ToString();
                TulosCopper.Text = (Copper = -2).ToString();
                TulosEmber.Text = (Ember = -2).ToString();
                TulosOil.Text = (Oil = -3).ToString();
                TulosCrystal.Text = (Crystal = 3).ToString();
                TulosArctic.Text = (Arctic = 2).ToString();
                TulosEmerald.Text = (Emerald = 2).ToString();
                TulosAmber.Visible = true;
                TulosElectra.Visible = true;
                TulosHydro.Visible = true;
                TulosRoyal.Visible = true;
                TulosCopper.Visible = true;
                TulosEmber.Visible = true;
                TulosOil.Visible = true;
                TulosCrystal.Visible = true;
                TulosArctic.Visible = true;
                TulosEmerald.Visible = true;
            }
            else
            {
                TulosAmber.Text = (Amber = 0).ToString();
                TulosElectra.Text = (Electra = 0).ToString();
                TulosHydro.Text = (Hydro = 0).ToString();
                TulosRoyal.Text = (Royal = 0).ToString();
                TulosCopper.Text = (Copper = 0).ToString();
                TulosEmber.Text = (Ember = 0).ToString();
                TulosOil.Text = (Oil = 0).ToString();
                TulosCrystal.Text = (Crystal = 0).ToString();
                TulosArctic.Text = (Arctic = 0).ToString();
                TulosEmerald.Text = (Emerald = 0).ToString();
                TulosAmber.Visible = false;
                TulosElectra.Visible = false;
                TulosHydro.Visible = false;
                TulosRoyal.Visible = false;
                TulosCopper.Visible = false;
                TulosEmber.Visible = false;
                TulosOil.Visible = false;
                TulosCrystal.Visible = false;
                TulosArctic.Visible = false;
                TulosEmerald.Visible = false;
            }
        }
        private void AmberKeskiRB_Click(object sender, EventArgs e)
        {
            if (AmberHelppoRB.Checked)
            {
                TulosAmber.Text = (Amber = 3).ToString();
                TulosElectra.Text = (Electra = 3).ToString();
                TulosHydro.Text = (Hydro = 3).ToString();
                TulosRoyal.Text = (Royal = -1).ToString();
                TulosCopper.Text = (Copper = -1).ToString();
                TulosEmber.Text = (Ember = -1).ToString();
                TulosOil.Text = (Oil = -2).ToString();
                TulosCrystal.Text = (Crystal = 2).ToString();
                TulosArctic.Text = (Arctic = 1).ToString();
                TulosEmerald.Text = (Emerald = 1).ToString();
                TulosAmber.Visible = true;
                TulosElectra.Visible = true;
                TulosHydro.Visible = true;
                TulosRoyal.Visible = true;
                TulosCopper.Visible = true;
                TulosEmber.Visible = true;
                TulosOil.Visible = true;
                TulosCrystal.Visible = true;
                TulosArctic.Visible = true;
                TulosEmerald.Visible = true;
            }
            else
            {
                TulosAmber.Text = (Amber = 0).ToString();
                TulosElectra.Text = (Electra = 0).ToString();
                TulosHydro.Text = (Hydro = 0).ToString();
                TulosRoyal.Text = (Royal = 0).ToString();
                TulosCopper.Text = (Copper = 0).ToString();
                TulosEmber.Text = (Ember = 0).ToString();
                TulosOil.Text = (Oil = 0).ToString();
                TulosCrystal.Text = (Crystal = 0).ToString();
                TulosArctic.Text = (Arctic = 0).ToString();
                TulosEmerald.Text = (Emerald = 0).ToString();
                TulosAmber.Visible = false;
                TulosElectra.Visible = false;
                TulosHydro.Visible = false;
                TulosRoyal.Visible = false;
                TulosCopper.Visible = false;
                TulosEmber.Visible = false;
                TulosOil.Visible = false;
                TulosCrystal.Visible = false;
                TulosArctic.Visible = false;
                TulosEmerald.Visible = false;
            }
        }
        private void AmberVaativaRB_Click(object sender, EventArgs e)
        {
            if (AmberHelppoRB.Checked)
            {
                TulosAmber.Text = (Amber = 2).ToString();
                TulosElectra.Text = (Electra = 2).ToString();
                TulosHydro.Text = (Hydro = 2).ToString();
                TulosRoyal.Text = (Royal = 3).ToString();
                TulosCopper.Text = (Copper = 3).ToString();
                TulosEmber.Text = (Ember = 3).ToString();
                TulosOil.Text = (Oil = 1).ToString();
                TulosCrystal.Text = (Crystal = -1).ToString();
                TulosArctic.Text = (Arctic = -2).ToString();
                TulosEmerald.Text = (Emerald = -2).ToString();
                TulosAmber.Visible = true;
                TulosElectra.Visible = true;
                TulosHydro.Visible = true;
                TulosRoyal.Visible = true;
                TulosCopper.Visible = true;
                TulosEmber.Visible = true;
                TulosOil.Visible = true;
                TulosCrystal.Visible = true;
                TulosArctic.Visible = true;
                TulosEmerald.Visible = true;
            }
            else
            {
                TulosAmber.Text = (Amber = 0).ToString();
                TulosElectra.Text = (Electra = 0).ToString();
                TulosHydro.Text = (Hydro = 0).ToString();
                TulosRoyal.Text = (Royal = 0).ToString();
                TulosCopper.Text = (Copper = 0).ToString();
                TulosEmber.Text = (Ember = 0).ToString();
                TulosOil.Text = (Oil = 0).ToString();
                TulosCrystal.Text = (Crystal = 0).ToString();
                TulosArctic.Text = (Arctic = 0).ToString();
                TulosEmerald.Text = (Emerald = 0).ToString();
                TulosAmber.Visible = false;
                TulosElectra.Visible = false;
                TulosHydro.Visible = false;
                TulosRoyal.Visible = false;
                TulosCopper.Visible = false;
                TulosEmber.Visible = false;
                TulosOil.Visible = false;
                TulosCrystal.Visible = false;
                TulosArctic.Visible = false;
                TulosEmerald.Visible = false;
            }
        }
        private void AmberHaastavaRB_Click(object sender, EventArgs e)
        {
            if (AmberHelppoRB.Checked)
            {
                TulosAmber.Text = (Amber = 1).ToString();
                TulosElectra.Text = (Electra = 1).ToString();
                TulosHydro.Text = (Hydro = 1).ToString();
                TulosRoyal.Text = (Royal = 2).ToString();
                TulosCopper.Text = (Copper = 2).ToString();
                TulosEmber.Text = (Ember = 2).ToString();
                TulosOil.Text = (Oil = 3).ToString();
                TulosCrystal.Text = (Crystal = -2).ToString();
                TulosArctic.Text = (Arctic = -3).ToString();
                TulosEmerald.Text = (Emerald = -3).ToString();
                TulosAmber.Visible = true;
                TulosElectra.Visible = true;
                TulosHydro.Visible = true;
                TulosRoyal.Visible = true;
                TulosCopper.Visible = true;
                TulosEmber.Visible = true;
                TulosOil.Visible = true;
                TulosCrystal.Visible = true;
                TulosArctic.Visible = true;
                TulosEmerald.Visible = true;
            }
            else
            {
                TulosAmber.Text = (Amber = 0).ToString();
                TulosElectra.Text = (Electra = 0).ToString();
                TulosHydro.Text = (Hydro = 0).ToString();
                TulosRoyal.Text = (Royal = 0).ToString();
                TulosCopper.Text = (Copper = 0).ToString();
                TulosEmber.Text = (Ember = 0).ToString();
                TulosOil.Text = (Oil = 0).ToString();
                TulosCrystal.Text = (Crystal = 0).ToString();
                TulosArctic.Text = (Arctic = 0).ToString();
                TulosEmerald.Text = (Emerald = 0).ToString();
                TulosAmber.Visible = false;
                TulosElectra.Visible = false;
                TulosHydro.Visible = false;
                TulosRoyal.Visible = false;
                TulosCopper.Visible = false;
                TulosEmber.Visible = false;
                TulosOil.Visible = false;
                TulosCrystal.Visible = false;
                TulosArctic.Visible = false;
                TulosEmerald.Visible = false;
            }
        }
        private void AmberEnRB_Click(object sender, EventArgs e)
        {
            if (AmberHelppoRB.Checked)
            {
                TulosAmber.Text = (Amber = 0).ToString();
                TulosElectra.Text = (Electra= 0).ToString();
                TulosHydro.Text = (Hydro = 0).ToString();
                TulosRoyal.Text = (Royal = 0).ToString();
                TulosCopper.Text = (Copper= 0).ToString();
                TulosEmber.Text = (Ember = 0).ToString();
                TulosOil.Text = (Oil = 0).ToString();
                TulosCrystal.Text = (Crystal = 0).ToString();
                TulosArctic.Text = (Arctic = 0).ToString();
                TulosEmerald.Text = (Emerald = 0).ToString();
                TulosAmber.Visible = true;
                TulosElectra.Visible = true;
                TulosHydro.Visible = true;
                TulosRoyal.Visible = true;
                TulosCopper.Visible = true;
                TulosEmber.Visible = true;
                TulosOil.Visible = true;
                TulosCrystal.Visible = true;
                TulosArctic.Visible = true;
                TulosEmerald.Visible = true;
            }
            else
            {
                TulosAmber.Text = (Amber = 0).ToString();
                TulosElectra.Text = (Electra = 0).ToString();
                TulosHydro.Text = (Hydro = 0).ToString();
                TulosRoyal.Text = (Royal = 0).ToString();
                TulosCopper.Text = (Copper = 0).ToString();
                TulosEmber.Text = (Ember = 0).ToString();
                TulosOil.Text = (Oil = 0).ToString();
                TulosCrystal.Text = (Crystal = 0).ToString();
                TulosArctic.Text = (Arctic = 0).ToString();
                TulosEmerald.Text = (Emerald = 0).ToString();
                TulosAmber.Visible = false;
                TulosElectra.Visible = false;
                TulosHydro.Visible = false;
                TulosRoyal.Visible = false;
                TulosCopper.Visible = false;
                TulosEmber.Visible = false;
                TulosOil.Visible = false;
                TulosCrystal.Visible = false;
                TulosArctic.Visible = false;
                TulosEmerald.Visible = false;
            }
        }

    }
 
}