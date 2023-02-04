namespace Radiobutton_checkboxFormPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int a1, b1, c1, d1, e1, f1, a2, b2, c2, d2, e2, f2, a3, b3, c3, d3, e3, f3, a4, b4, c4, d4, e4, f4, a5, b5, c5, d5, e5, f5, a6, b6, c6, d6, e6, f6, a7, b7, c7, d7, e7, f7, a8, b8, c8, d8, e8, f8, a9, b9, c9, d9, e9, f9, a10, b10, c10, d10, e10, f10;

        // Napit nollaa, mutta tulokset ei
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton1.Checked = false;
            }
            if (radioButton3.Checked == true)
            {
                radioButton3.Checked = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (radioButton4.Checked == true)
            {
                radioButton4.Checked = false;

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton2.Checked = false;
            }
        }


        /*
    private int GetRadioValue()
    {
        if (radioButton1.Checked) return 1;
        else return 0;
    }
*/

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a1 = -3; // Emerald
                a2 = 3;  // Hydro
                a3 = 2;  // Royal
                a4 = 2;  // Musta
                a5 = -2;  // Ember
                a6 = -2;  // Amber
                a7 = -2;  // Kristalli
                a8 = -2;  // Kupari
                a9 = -3;  // Electra
                a10 = -3; // Arctik
                label1.Text = (a1 + b1 + c1 + d1 + e1 + f1).ToString();
                label2.Text = (a2 + b2 + c2 + d2 + e2 + f2).ToString();
                label3.Text = (a3 + b3 + c3 + d3 + e3 + f3).ToString();
                label4.Text = (a4 + b4 + c4 + d4 + e4 + f4).ToString();
                label5.Text = (a5 + b5 + c5 + d5 + e5 + f5).ToString();
                label6.Text = (a6 + b6 + c6 + d6 + e6 + f6).ToString();
                label7.Text = (a7 + b7 + c7 + d7 + e7 + f7).ToString();
                label8.Text = (a8 + b8 + c8 + d8 + e8 + f8).ToString();
                label9.Text = (a9 + b9 + c9 + d9 + e9 + f9).ToString();
                label10.Text = (a10 + b10 + c10 + d10 + e10 + f10).ToString();
            }
            else
            {
                a1 = 0;  // Emerald
                a2 = 0;  // Hydro
                a3 = 0;  // Royal
                a4 = 0;  // Musta
                a5 = 0;  // Ember
                a6 = 0;  // Amber
                a7 = 0;  // Kristalli
                a8 = 0;  // Kupari
                a9 = 0;  // Electra
                a10 = 0; // Arctik
            }
        }
         private void radioButton2_CheckedChanged(object sender, EventArgs e)
         {
            if (radioButton2.Checked)
            {
                b1 = -3; // Emerald
                b2 = 3;  // Hydro
                a3 = 3;  // Royal
                a4 = 3;  // Musta
                a5 = -1;  // Ember
                a6 = -1;  // Amber
                a7 = -1;  // Kristalli
                a8 = -1;  // Kupari
                a9 = -3;  // Electra
                a10 = -3; // Arctik
                label1.Text = (a1 + b1 + c1 + d1 + e1 + f1).ToString();
                label2.Text = (a2 + b2 + c2 + d2 + e2 + f2).ToString();
                label3.Text = (a3 + b3 + c3 + d3 + e3 + f3).ToString();
                label4.Text = (a4 + b4 + c4 + d4 + e4 + f4).ToString();
                label5.Text = (a5 + b5 + c5 + d5 + e5 + f5).ToString();
                label6.Text = (a6 + b6 + c6 + d6 + e6 + f6).ToString();
                label7.Text = (a7 + b7 + c7 + d7 + e7 + f7).ToString();
                label8.Text = (a8 + b8 + c8 + d8 + e8 + f8).ToString();
                label9.Text = (a9 + b9 + c9 + d9 + e9 + f9).ToString();
                label10.Text = (a10 + b10 + c10 + d10 + e10 + f10).ToString();
            }
            else
            {
                a1 = 0;  // Emerald
                a2 = 0;  // Hydro
                a3 = 0;  // Royal
                a4 = 0;  // Musta
                a5 = 0;  // Ember
                a6 = 0;  // Amber
                a7 = 0;  // Kristalli
                a8 = 0;  // Kupari
                a9 = 0;  // Electra
                a10 = 0; // Arctik
            }
         }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                c1 = -1; // Emerald
                c2 = 2;  // Hydro
                a3 = 2;  // Royal
                a4 = 2;  // Musta
                a5 = 3;  // Ember
                a6 = 3;  // Amber
                a7 = 3;  // Kristalli
                a8 = 3;  // Kupari
                a9 = -1;  // Electra
                a10 = -1; // Arctik
                label1.Text = (a1 + b1 + c1 + d1 + e1 + f1).ToString();
                label2.Text = (a2 + b2 + c2 + d2 + e2 + f2).ToString();
                label3.Text = (a3 + b3 + c3 + d3 + e3 + f3).ToString();
                label4.Text = (a4 + b4 + c4 + d4 + e4 + f4).ToString();
                label5.Text = (a5 + b5 + c5 + d5 + e5 + f5).ToString();
                label6.Text = (a6 + b6 + c6 + d6 + e6 + f6).ToString();
                label7.Text = (a7 + b7 + c7 + d7 + e7 + f7).ToString();
                label8.Text = (a8 + b8 + c8 + d8 + e8 + f8).ToString();
                label9.Text = (a9 + b9 + c9 + d9 + e9 + f9).ToString();
                label10.Text = (a10 + b10 + c10 + d10 + e10 + f10).ToString();
            }
            else
            {
                a1 = 0;  // Emerald
                a2 = 0;  // Hydro
                a3 = 0;  // Royal
                a4 = 0;  // Musta
                a5 = 0;  // Ember
                a6 = 0;  // Amber
                a7 = 0;  // Kristalli
                a8 = 0;  // Kupari
                a9 = 0;  // Electra
                a10 = 0; // Arctik
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                d1 = 3; // Emerald
                d2 = 1;  // Hydro
                a3 = 0;  // Royal
                a4 = 0;  // Musta
                a5 = 2;  // Ember
                a6 = 2;  // Amber
                a7 = 2;  // Kristalli
                a8 = 2;  // Kupari
                a9 = 3;  // Electra
                a10 = 3; // Arctik
                label1.Text = (a1 + b1 + c1 + d1 + e1 + f1).ToString();
                label2.Text = (a2 + b2 + c2 + d2 + e2 + f2).ToString();
                label3.Text = (a3 + b3 + c3 + d3 + e3 + f3).ToString();
                label4.Text = (a4 + b4 + c4 + d4 + e4 + f4).ToString();
                label5.Text = (a5 + b5 + c5 + d5 + e5 + f5).ToString();
                label6.Text = (a6 + b6 + c6 + d6 + e6 + f6).ToString();
                label7.Text = (a7 + b7 + c7 + d7 + e7 + f7).ToString();
                label8.Text = (a8 + b8 + c8 + d8 + e8 + f8).ToString();
                label9.Text = (a9 + b9 + c9 + d9 + e9 + f9).ToString();
                label10.Text = (a10 + b10 + c10 + d10 + e10 + f10).ToString();
            }
            else
            {
                a1 = 0;  // Emerald
                a2 = 0;  // Hydro
                a3 = 0;  // Royal
                a4 = 0;  // Musta
                a5 = 0;  // Ember
                a6 = 0;  // Amber
                a7 = 0;  // Kristalli
                a8 = 0;  // Kupari
                a9 = 0;  // Electra
                a10 = 0; // Arctik
            }
        }

    }
}