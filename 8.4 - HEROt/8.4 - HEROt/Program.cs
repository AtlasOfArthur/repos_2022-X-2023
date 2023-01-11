// See https://aka.ms/new-console-template for more information
Console.WriteLine("--------__8.4 - HEROt__--------");
Console.WriteLine("_______________________________");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("---__HEROt ovat seuraavat__---");
Console.WriteLine("_______________________________");
Console.WriteLine("(1) Ana             Healer");
Console.WriteLine("(2) Bastion         Defence");
Console.WriteLine("(3) Brigette        Support");
Console.WriteLine("(4) D.Va (Mech)     Tank");
Console.WriteLine("(5) Adilard         Dealer");
Console.WriteLine("_______________________________");
Console.WriteLine();
Console.WriteLine("Valitse HERO (1-5)");


int HERO = 0;
while (HERO < 1 || HERO > 5)
{
    Console.WriteLine("Anna kelvollinen valinta (1, 2, 3, 4 tai 5)");
    HERO = int.Parse(Console.ReadLine());
}
Console.WriteLine("HERO        |ROLE     |HEALTH |ARMOR |ABILITY POWER |CRIT.MULTIPLIER |CRIT.CHANCE");
    if (HERO == 1)
    {
        Console.WriteLine("Ana          Healer    200     0      5000           2.2              0.20");
    }
    else if (HERO == 2)
    {
        Console.WriteLine("Bastion      Defence   200     100    3200           1.3              0.15");
    }
    else if (HERO == 3)
    { 
        Console.WriteLine("Brigette     Support   200     50     4050           1.7              0.25");
    }
    else if (HERO == 4)
    {
        Console.WriteLine("D.Va  (Mech) Tank      400     600    1400           1.5              0.30");
    }
    else if (HERO == 5)
    {
        Console.WriteLine("Adilard      Dealer    125     0      8200           2.8              0.35");
    }
