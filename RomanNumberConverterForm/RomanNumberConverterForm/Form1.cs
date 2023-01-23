namespace RomanNumberConverterForm
{
    public partial class RomanConverter : Form
    {
        public RomanConverter()
        {
            InitializeComponent();
        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            int tuhannet, sadat, kympit, yks;
            string vastaus = "";
            if (NumeroTB.Text.Length > 3)// Pidempi kuin 3, kyseessä on tuhatluku
            {                                                              // 0 1 2 3 4 -> 0=ensimäinen numero rivissä,jne
                tuhannet = Convert.ToInt32(NumeroTB.Text.Substring(0, 1)); // 1 0 0 0
                sadat = Convert.ToInt32(NumeroTB.Text.Substring(1, 1));    //   1 0 0
                kympit = Convert.ToInt32(NumeroTB.Text.Substring(2, 1));   //     1 0
                yks = Convert.ToInt32(NumeroTB.Text.Substring(3, 1));      //       1
                                                                           // https://www.w3schools.com/jsref/tryit.asp?filename=tryjsref_substring

                if (tuhannet % 3 == 0)
                {
                    vastaus += "MMM";
                }
                else if (tuhannet % 2 == 0)
                {
                    vastaus += "MM";
                }
                else if (tuhannet % 1 == 0)
                {
                    vastaus += "M";
                }
                else
                {
                    vastaus += "";
                }
                vastaus += Sataset(sadat, vastaus);
                vastaus += Kymmenet(kympit, vastaus);
                vastaus += Ykkoset(yks, vastaus);

            }
            else if (NumeroTB.Text.Length > 2) // kyseessä on sataluku
            {                                                              //   0 1 2 3
                sadat = Convert.ToInt32(NumeroTB.Text.Substring(0, 1));    //   1 0 0
                kympit = Convert.ToInt32(NumeroTB.Text.Substring(1, 1));   //     1 0
                yks = Convert.ToInt32(NumeroTB.Text.Substring(2, 1));      //       1
                vastaus += Sataset(sadat, vastaus);
                vastaus += Kymmenet(kympit, vastaus);
                vastaus += Ykkoset(yks, vastaus);
            }
            else if (NumeroTB.Text.Length > 1) // kyseessä on kymmenluku
            {                                                              //   0 1 2
                kympit = Convert.ToInt32(NumeroTB.Text.Substring(0, 1));   //   1 0
                yks = Convert.ToInt32(NumeroTB.Text.Substring(1, 1));      //     1
                vastaus += Kymmenet(kympit, vastaus);
                vastaus += Ykkoset(yks, vastaus);
            }
            else if (NumeroTB.Text.Length > 0) // kyseessä on ykkösluku
            {                                                              //   0 1
                yks = Convert.ToInt32(NumeroTB.Text.Substring(0, 1));      //   1
                vastaus += Ykkoset(yks, vastaus);
            }

            VastausLB.Text = vastaus;
            VastausLB.Visible = true;
        }
        private string Sataset(int sadat, string vastaus)
        {
            if (sadat % 9 == 0 && sadat != 0)
            {
                return "CM"; // C= 100, koska M kirjaimen(M=1000) oikealla puolella CM=900
            }
            else if (sadat % 8 == 0 && sadat != 0)
            {
                return "DCCC"; // D=500 C=100
            }
            else if (sadat % 7 == 0 && sadat != 0)
            {
                return "DCC";
            }
            else if (sadat % 6 == 0 && sadat != 0)
            {
                return "DC";
            }
            else if (sadat % 5 == 0 && sadat != 0)
            {
                return "D";
            }
            else if (sadat % 4 == 0 && sadat != 0)
            {
                return "CD";
            }
            else if (sadat % 3 == 0 && sadat != 0)
            {
                return "CCC";
            }
            else if (sadat % 2 == 0 && sadat != 0)
            {
                return "CC";
            }
            else if (sadat % 1 == 0 && sadat != 0)
            {
                return "C";
            }
            else
            {
                return "";
            }
        
        }
        private string Kymmenet(int kympit, string vastaus)
        {
            if (kympit % 9 == 0 && kympit != 0)
            {
                return "XC"; // X=10 C=100 
            }
            else if (kympit % 8 == 0 && kympit != 0)
            {
                return "LXXX"; // L=50
            }
            else if (kympit % 7 == 0 && kympit != 0)
            {
                return "LXX";
            }
            else if (kympit % 6 == 0 && kympit != 0)
            {
                return "LX";
            }
            else if (kympit % 5 == 0 && kympit != 0)
            {
                return "L";
            }
            else if (kympit % 4 == 0 && kympit != 0)
            {
                return "XL";
            }
            else if (kympit % 3 == 0 && kympit != 0)
            {
                return "XXX";
            }
            else if (kympit % 2 == 0 && kympit != 0)
            {
                return "XX";
            }
            else if (kympit % 1 == 0 && kympit != 0)
            {
                return "X";
            }
            else
            {
                return "";
            }
        }
        private string Ykkoset(int yks, string vastaus)
        {
            if (yks % 9 == 0 && yks != 0)
            {
                return "IX"; // I=1 X=10
            }
            else if (yks % 8 == 0 && yks != 0)
            {
                return "VIII"; // V=5 5+3=8
            }
            else if (yks % 7 == 0 && yks != 0)
            {
                return "VII";
            }
            else if (yks % 6 == 0 && yks != 0)
            {
                return "VI";
            }
            else if (yks % 5 == 0 && yks != 0)
            {
                return "V";
            }
            else if (yks % 4 == 0 && yks != 0)
            {
                return "IV"; // 5-1=4
            }
            else if (yks % 3 == 0 && yks != 0)
            {
                return "III";
            }
            else if (yks % 2 == 0 && yks != 0)
            {
                return "II";
            }
            else if (yks % 1 == 0 && yks != 0)
            {
                return "I";
            }
            else
            {
                return "";
            }
        }
    }
} 