using System.Security.Cryptography;

namespace Radiobutton_checkboxFormPractice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Aliohjelmat
        public int ZeroVal(int z1 = 0)
        {     // z1 antaa nolla arvon

              // Tulostaa nolla arvon 0 kyseisiin labeleihin
            label1.Text = z1.ToString();
            label2.Text = z1.ToString();
            label3.Text = z1.ToString();
            label4.Text = z1.ToString();
            label5.Text = z1.ToString();
            label6.Text = z1.ToString();
            label7.Text = z1.ToString();
            label8.Text = z1.ToString();
            label9.Text = z1.ToString();
            label10.Text = z1.ToString();
              // Palauttaa arvon 0
            return z1;
        }

        // ^ Aliohjelmat ^


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                int a1 = 1; // Emerald
                int a2 = 1;  // Hydro
                int a3 = 1;  // Royal
                int a4 = 1;  // Musta
                int a5 = 1;  // Ember
                int a6 = -1;  // Amber
                int a7 = -1;  // Kristalli
                int a8 = -1;  // Kupari
                int a9 = -1;  // Electra
                int a10 = -1; // Arctik
                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                label3.Text = a3.ToString();
                label4.Text = a4.ToString();
                label5.Text = a5.ToString();
                label6.Text = a6.ToString();
                label7.Text = a7.ToString();
                label8.Text = a8.ToString();
                label9.Text = a9.ToString();
                label10.Text = a10.ToString();

            }
            else if (radioButton1.Checked == false)
            {
                ZeroVal();
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                int b1 = 3; // Emerald
                int b2 = 3;  // Hydro
                int b3 = 3;  // Royal
                int b4 = 3;  // Musta
                int b5 = -2;  // Ember
                int b6 = 3;  // Amber
                int b7 = 2;  // Kristalli
                int b8 = 1;  // Kupari
                int b9 = 3;  // Electra
                int b10 = -3; // Arctik
                label1.Text = b1.ToString();
                label2.Text = b2.ToString();
                label3.Text = b3.ToString();
                label4.Text = b4.ToString();
                label5.Text = b5.ToString();
                label6.Text = b6.ToString();
                label7.Text = b7.ToString();
                label8.Text = b8.ToString();
                label9.Text = b9.ToString();
                label10.Text = b10.ToString();
            }
            else if (radioButton2.Checked == false)
            {
                ZeroVal();
            }
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton1.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton2.Checked = false;
            }
        }
    }
}