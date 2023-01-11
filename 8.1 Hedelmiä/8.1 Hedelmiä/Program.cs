Console.WriteLine("8.1 - Hedelmiä!");
Console.WriteLine();
Console.WriteLine("---------------");
Console.WriteLine();

string[] hedelmia = new string[] {"Kumqwat", "Dragonfruit", "Duria", "Mango", "Banaani", "Kookos", "Karambola", "Kiwi", "Passion", "Appelsiini", "Sitruuna", "Lime", "Papaya", "Vesimeloni", "Hunajameloni", "Päärynä", "Omenapäärynä", "Klementiini", "Greippi", "Omena"};
// (20 hedelmää)
int k;//Käyttäjän valinta
Console.WriteLine("Kuinka monta hedelmää tulostetaan? (MAX 20)");
k = int.Parse(Console.ReadLine());
Console.WriteLine();
for ( int i = 0; i < k; i++)
{
    Console.WriteLine(hedelmia[i]);
}
Console.WriteLine();
Console.WriteLine(k + "/20 hedelmää tulostettiin!");
Console.ReadLine();