

static int KolmenLuvunSumma(int nro1, int nro2, int nro3, int summa) //Aliohjelma (Eng = Method / Function)
{

    Console.WriteLine("Anna kolme lukua niin lasken niiden summan.\n");

    for (int i = 0; i < 3; i++)
    {
        if (i == 0)
        {
            Console.WriteLine("Anna " + i +" luku \n \n");
            nro1 = int.Parse(Console.ReadLine());    // Tallentaa käyttäjän antaman numeron
            summa+= nro1;
        }
        else if (i == 1)
        {
            Console.WriteLine("Anna " + i + " luku \n \n");
            nro2 = int.Parse(Console.ReadLine());
            summa+= nro2;
        }
        else if (i == 2)
        {
            Console.WriteLine("Anna " + i + " luku \n \n");
            nro3 = int.Parse(Console.ReadLine());
            summa+= nro3;
        }
    }
    return summa;
}

Console.WriteLine(KolmenLuvunSumma());
