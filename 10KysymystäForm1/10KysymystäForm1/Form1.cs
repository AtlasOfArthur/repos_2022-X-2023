namespace _10KysymystäForm1
{
    public partial class VastauslomakeForm : Form
    {
        int laskuri = 0;
        int oikein = 0;
        string[] oikeatVastaukset = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        string[] KayttajanVastaukset = new string[10];
        public VastauslomakeForm()
        {
            InitializeComponent(); // Pitää olla DUMMY radiobutton Visible-false, Autocheck-False
            RBA.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            RBB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            RBC.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            RBD.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }

        private void VastauslomakeForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton && laskuri < 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                KayttajanVastaukset[laskuri] = radioButton.Text;
                laskuri++;
                KysymysLB.Text = "Vastaus " + laskuri + ". kysymykseen";
            }
            else
            {
                VastausLB.Text = "";
                RBA.Enabled = false;
                RBB.Enabled = false;
                RBC.Enabled = false;
                RBB.Enabled = false;
                for (int j = 0; j < 10; j++)
                {
                    if (KayttajanVastaukset[j] == oikeatVastaukset[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli:" + oikein;
                VastausLB.Visible = true;
            }
            TyhjaaVastaus(); // Aliohjelma joka tyhjentää tsekkauksen joka vaiheessa
        }
        private void TyhjaaVastaus()
        {
            if (RBA.Checked == true)
            {
                RBA.Checked = false; //Tyhjentää tsekkauksen A
                laskuri--;
                // Tapahtuma "haistelija"(EventHandler) haistelee myös tätä, niin pitää vähentää, ettei lisää ylimääräisiä
            }
            if (RBB.Checked == true)
            {
                RBB.Checked = false; //Tyhjentää tsekkauksen B
                laskuri--;
            }
            if (RBC.Checked == true)
            {
                RBC.Checked = false; //Tyhjentää tsekkauksen C
                laskuri--;
            }
            if (RBD.Checked == true)
            {
                RBD.Checked = false; //Tyhjentää tsekkauksen D
                laskuri--;
            }
        }
    }
}