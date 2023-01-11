Console.WriteLine("7.3   'half' pyramid");
Console.WriteLine();
Console.WriteLine("----------------------");
Console.WriteLine();
{
    int a, b, c;
    int d; //käyttäjän valinta
    Console.WriteLine("Määritä pyramidin korkeus antamalla lukema");
    d = int.Parse(Console.ReadLine());
    for (a = 1; a <= d; a++) // (d) käyttäjän valinta
    {
        for (b = 1; b <= a; ++b)
            Console.Write(b);

        for (c = d - a; c >= 1; c--) /* Huomasin että (c) voi olla
                                        mitä vain niin kauan kun ei printata mitään
            (c) on siis periaatteessa tässä tehtävässä turha, mutta tein sen
            havainnollistamis mielessä kuitenkin  */
            Console.Write("*"); //Printtaan "*" että näkee mihin tämä merkki tulisi
                                //  "**" Printtaisi ylös alaisin olevan kolmion puolipyramidin oikealle puolelle
        Console.Write("\n");
        //tyhjänä printtaa: 1       12      123     1234    12345   123456  1234567 12345678 123456789 12345678910

    }                        /* "\n" siirtyy uudelle riville
                                jokaisen printatun numerosarjan jälkeen */

    Console.ReadLine(); /* Toimii ilmankin tätä, mutta
                           ohjelma odottaa käyttäjän näppäin komentoa,
                           ennen kuin ohjelma ehdottaa sulkemista */

}