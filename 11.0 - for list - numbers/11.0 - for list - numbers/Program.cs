using System.Linq;

Console.WriteLine("Tehtävä 11. - for silmukka lista");

List<string> numlist = new List<string>();
string muuttuja;

for (var count = 1; count < 6; count++)
{
    Console.Write("Anna " + count + " Arvo: ");
    numlist.Add(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Riviin printattuna...");
Console.WriteLine("{0}", string.Join(" ", numlist));
Console.WriteLine();
Console.WriteLine("Tai pystyssä printattuna");
Console.WriteLine(numlist[0]);
Console.WriteLine(numlist[1]);
Console.WriteLine(numlist[2]);
Console.WriteLine(numlist[3]);
Console.WriteLine(numlist[4]);


/* Lisää alkuun teksti using System.Linq; , 
 * Esittele uusi merkkijonomuuttuja ja lisää käyttäjältä kysytty numero siihen. 
 * Lisää sitten muuttuja taulukkoon numlist.
 * (muuttuja = Console.Readline(); ja sen jälkeen numlist.Add(muuttuja);*/