namespace Aliohjelmat.Methods_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hello() // Yksinkertainen aliohjelma (Hello) esimerkki1
        {
            ExampleLB1.Text= "Hello";
        }

        private void KutsuHelloBT_Click(object sender, EventArgs e)
        {
            Hello();        // Kutsuu aliohjelmaa (Hello)
        }



        // Reverse1 (118)
     /*   private  Reverse_String(string viesti) // Esimerkki2
        {  // Void, ei palauta mitään (Return palautus pyyntö)
           //  ("your method is static. It can't access instance variables from your form") static void poistettu privaten jälkeen
           //  string viesti = "Reverse !";    
            char[] viestiArray = viesti.ToCharArray();
            Array.Reverse(viestiArray);
            foreach (char artefakti in viestiArray);
            {
        //       return ExampleLB2.Text = (artefakti); 
            }
     
        }
        private void KutsuReverseBT_Click(object sender, EventArgs e)
        {
       //     Reverse_String(ExampleLB2.Text); 
        }
     */
        // Reverse2
        private string Reversestring2(string viesti2) // -||-3 (Static poistettu)
        {
            char[] viestiArray2 = viesti2.ToCharArray();
            Array.Reverse(viestiArray2);
            return String.Concat(viestiArray2);
        }

        private void Reverse2BTN_Click(object sender, EventArgs e)
        {
            Reversestring2(ExampleLB2_2.Text);
        }
    }
}