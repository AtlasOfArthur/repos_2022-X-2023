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
            for (int i = 0; i < 60: i++)
            {
                MinCB.Items.Add(i.ToString());
                SecCB.Items.Add(i.ToString());
            }
        }

        private void StartBT_Click(object sender, EventArgs e)
        {

        }

        private void StopBT_Click(object sender, EventArgs e)
        {

        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {

        }
    }
}
