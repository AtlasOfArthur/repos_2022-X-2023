namespace _16_Ajastin
{
    public partial class AjastinForm : Form
    {
        private int kokonaisaika;
        public AjastinForm()
        {
            InitializeComponent();
        }

        private void AjastinForm_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false;
            for (int i = 0; i < 60; i++)
            {
                MinCB.Items.Add(i.ToString());
                SecCB.Items.Add(i.ToString());
            }
            MinCB.SelectedIndex = 0;
            SecCB.SelectedIndex = 10;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;
            int minuutit = int.Parse(MinCB.SelectedItem.ToString());
            int sekuntit = int.Parse(SecCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekuntit;
            AjastinTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            AikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if (kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekuntit = kokonaisaika - (minuutit * 60);
                AikaLB.Text = $"{minuutit:00}:{sekuntit:00}"; 
                // Formatoitu niin ett‰ n‰ytt‰‰ aina 2 numeroa rinnakkain
            }
            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Aika on loppu!");
            }
        }
    }
}
