Console.WriteLine("7.4   ArvontA & VeikkauS");
Console.WriteLine(" → for lauseen sisällä if-else lause");
Console.WriteLine("----------------------------------------------");
Console.WriteLine();
{
    Random rnd = new Random();
    int arvottu = rnd.Next(1, 13);

    int y = 0; //Yritys kertojen määrä menee tämän muuttujan sisään (5)
    int v = 0; //käyttäjän valinta
    Console.WriteLine("Anna veikkauksesi ... Valitse numero väliltä 1-12");
    v = int.Parse(Console.ReadLine());

    /*laitan valinnaksi (111), jotta saan if-elsen menemään loppuun asti varmasti*/

    for (y = 1; y <= 5; y++) //Pituus 5 koska: (5 yritystä)
    {


        if (y == 1 && arvottu != v)
        {
            Console.WriteLine("Arvasit väärin!");
            Console.WriteLine("Yritä uudestaan!");
           
        }
        else if (y == 1 && arvottu == v)
        {
            Console.WriteLine("Onneksi olkoon, arvasit HETI oikein!");
        }
        if (y == 2 && arvottu != v)
        {
            Console.WriteLine("Arvasit toisen kerran väärin!");
            Console.WriteLine("Yritä uudestaan!");
        }
        else if (y == 2 && arvottu == v)
        {
            Console.WriteLine("Onneksi olkoon, arvasit TOISELLA yrittämällä oikein!");
        }
        if (y == 3 && arvottu != v)
        {
            Console.WriteLine("Arvasit TAAS väärin ! Yrittäisit edes!");
            Console.WriteLine("Yritä uudestaan!!");

        }
        else if (y == 3 && arvottu == v)
        {
            Console.WriteLine("Onneksi olkoon, arvasit KOLMANNELLA yrittämällä oikein!");
        }
        if (y == 4 && arvottu != v)
        {
            Console.WriteLine("!VAROITUS! Vain yksi yritys jäljellä. Tietokoneesi !RÄJÄHTÄÄ! jos arvaat väärin vielä kerran.");
            Console.WriteLine("Yritä uudestaan!!! ARPA ONNEA!");

        }
        else if (y == 4 && arvottu == v)
        {
            Console.WriteLine("Onneksi olkoon, arvasit VIHDOINKIN oikein!");
        }
        if (y == 5 && arvottu != v)
        {
            Console.WriteLine("Sinulla on surkein tuuri ikinä!!!!");
            Console.WriteLine("Räjäytetään...");
            Console.Write("5... "); Thread.Sleep(1000); Console.Write("4... "); Thread.Sleep(1000); Console.Write("3... "); Thread.Sleep(1000); Console.Write("2... "); Thread.Sleep(1000);
            Console.WriteLine("HÖLMÖ! Ei mitään räjähdystä tule. Tämä on tietokone, Ei pommin teko kone! Tietokoneissa ei ole räjähteitä!... Yleensä ainakaan.");
        }
        else if (y == 5 && arvottu == v)
        {
            Console.WriteLine("Onneksi olkoon, arvasit VIIME TIPASSA oikein! Pelastuit juuri ja juuri!");
            Console.Write(". "); Thread.Sleep(1000); Console.Write(". "); Thread.Sleep(1000); Console.Write(". "); Thread.Sleep(1000);
            Console.WriteLine("HÖLMÖ! Ei mitään räjähdystä tule. Tämä on tietokone, ei pommin teko kone! Tietokoneissa ei ole räjähteitä!... Yleensä ainakaan.");
        }
        Console.ReadLine();
    }//for päättyy
}