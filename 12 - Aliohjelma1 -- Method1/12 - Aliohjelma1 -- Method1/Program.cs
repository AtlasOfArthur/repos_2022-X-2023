// See https://aka.ms/new-console-template for more information
int NelionKaava(int Param1, int Param2) //Aliohjelma (Eng = Method / Function)
{
    int NelionKaava = Param1 * Param2;//NelionKaava aliohjelman sisältö
    return NelionKaava;
}

Console.Write("Anna luku jonka neliön haluat tietää: "); //Esim: anna 6 -> 6x6=36 -> neliö: 36 (Muutin tätä. Oli vain Param1, nyt on myös Param2 olemassa)
int Luku1 = int.Parse(Console.ReadLine());
int Luku2 = Luku1; //Annan luvulle1 & -2 saman arvon yhdellä kertaa näin?

Console.WriteLine(); //Seuraavalla rivillä NelionKaava aliohjelman uudet arvot tulostetaan riville
Console.WriteLine("Antamasi luvun " + (Luku1) + " neliö on " + NelionKaava(Luku1, Luku2));
Console.WriteLine(); //Tehtävä oli paljon suppeampi kuin mitä edes tajusin
    