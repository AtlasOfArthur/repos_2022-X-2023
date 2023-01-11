
Console.WriteLine("Hello, foreach.\n"); 
Console.WriteLine("9 - Lukujen keskiarvo.");
Console.WriteLine("______________________\n");
Console.WriteLine("Anna viisi lukua väliltä 1-9999, niin lasken niiden keskiarvon.\n");
int[] arvot = new int[5];
int summa = 0;
double keskiarvo = 0;

for (int luvut = 0; luvut < arvot.Length; luvut++)
{
    arvot[luvut] = int.Parse(Console.ReadLine());
}
foreach (int luvut in arvot)
{
    summa += luvut;
}
keskiarvo = summa / 5;
Console.Write("Antamiesi lukujen keskiarvo on " + keskiarvo);