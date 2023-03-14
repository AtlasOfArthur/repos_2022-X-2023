


Console.WriteLine("Tehtävä 13. Laske aliohjelmalla kolmen luvun summa. \n");



static int KolmenLuvunSumma (int luku1, int luku2, int luku3)
{
    return luku1 + luku2 + luku3;
}


List<int> list = new List<int>();

for (int i = 1; i < 4; i++)
{
    Console.WriteLine("Anna " + i + " luku.");
    list.Add(int.Parse(Console.ReadLine()));
}

Console.WriteLine(KolmenLuvunSumma(list[0], list[1], list[2]));


/*
static int KolmenLuvunSumma (int list, int summa);
{


for (int i = 1; i < 4; i++)
{
    Console.WriteLine("Anna " + i + " luku.");
    list.Add(int.Parse(Console.ReadLine()));
    
}
    return ( list[0] +  list[1] + list[2] );
}
*/


//    list.Sum();
// Console.WriteLine(KolmenLuvunSumma());
// Console.WriteLine("Antamiesi lukujen " + list[0] + ", " + list[1] + ", " + list[2] + " summa on " + summa);

    


/* // (Vanhat)
static int KolmenLuvunSumma(int nro1, int nro2, int nro3, int summa) //Aliohjelma (Eng = Method / Function)
{
    

    for (int i = 0; i < 3; i++)
    {

    }

}

Console.WriteLine("Anna kolme lukua niin lasken niiden summan.\n");
Console.WriteLine(KolmenLuvunSumma());
*/
/*
for (int i = 0; i < 3; i++)
{
    if (i == 0)
    {
        Console.WriteLine("Anna " + i + " luku \n \n");
        nro1 = int.Parse(Console.ReadLine());    // Tallentaa käyttäjän antaman numeron
        summa += nro1;
    }
    else if (i == 1)
    {
        Console.WriteLine("Anna " + i + " luku \n \n");
        nro2 = int.Parse(Console.ReadLine());
        summa += nro2;
    }
    else if (i == 2)
    {
        Console.WriteLine("Anna " + i + " luku \n \n");
        nro3 = int.Parse(Console.ReadLine());
        summa += nro3;
    }
}
return summa; */