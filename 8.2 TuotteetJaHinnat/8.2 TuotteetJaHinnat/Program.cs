Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("8.2 - Tuotteet & Hinnat");
Console.WriteLine();
Console.WriteLine("---------------");
Console.WriteLine();

string[] tuotteet = new string[] {"Vasara", "Saha", "Kirves"};
string[] hinnat = new string[] {" 5€", " 10€", " 15€"};

Console.WriteLine();
for (int i = 0; i < tuotteet.GetLength(0); i++)
{
    Console.WriteLine(tuotteet[i] + hinnat[i]);
}
Console.WriteLine();
Console.WriteLine();
/*--------------------------------------------*/
Console.WriteLine("Solution2");
Console.WriteLine();
{// Multi-dimensional array                           
    string[,] tuotHin = new string[3,2] { { "Vasara ", "5€" }, { "Saha ", "10€" }, { "Kirves ", "15€" } };
                               
    for (int a = 0; a < tuotHin.GetLength(0); a++)
    {
        for (int b = 0; b < tuotHin.GetLength(1); b++)
        {
            Console.Write(tuotHin[a, b]);
        }
        Console.WriteLine();
    }
}
Console.ReadLine();