// See https://aka.ms/new-console-template for more information

{
    Console.Write("Anna summa euroina ... ");
    int euro = int.Parse(Console.ReadLine()); /*Käyttäjä määrittää euromäärän, tietokone tallentaa sen muuttujaan euro*/
    Console.WriteLine(); /*Tyhjä rivi*/
    Console.WriteLine("Annoit summaksi" + euro + " Euroa");
    Console.WriteLine("Valitse seuraavaksi mihin seuraavista rahayksiköistä haluat muuntaa eurojasi ... ");
    Console.WriteLine();
    Console.WriteLine("Englannin puntaan, valitse 1.");
    Console.WriteLine("Amerikan Dollariin, Valitse 2.");
    Console.WriteLine("Kiinan Juaniin, valitse 3.");
    Console.WriteLine("Japanin Jeniin, valitse 4.");
    Console.WriteLine("Venäjän Ruplaan, valitse 5.");
    /*  ^ Määritellään käyttäjän valinta variableiksi */

    double GBPe = 0.8457;
    double USDe = 1.0562;
    double JUANe = 7.0695;
    double JENe = 0.0100;
    double RUBe = 65.4875;

    double GBP = (euro * GBPe);
    double USD = (euro * USDe);
    double JUAN = (euro * JUANe);
    double JEN = (euro * JENe);
    double RUB = (euro * RUBe);
    /* ^ Muunnoksen määrä suhteessa lukuun 1 euro */

    string.Format("{0:0.00}", GBP);
    string.Format("{0:0.00}", USD);
    string.Format("{0:0.00}", JUAN);
    string.Format("{0:0.00}", JEN);
    string.Format("{0:0.00}", RUB);
    /* ^ Muunto alue */

    int kauttajanValinta = int.Parse(Console.ReadLine());
    /* Tämän linjan alle tulee if lauseet  */

    while (kauttajanValinta > 5) 
    {
        Console.WriteLine("Virheellinen valinta. Valitse muunnos: ");
        Console.WriteLine("  1   Englannin puntaan.");
        Console.WriteLine("  2   Amerikan Dollariin.");
        Console.WriteLine("  3   Kiinan Juaniin.");
        Console.WriteLine("  4   Japanin Juaniin,");
        Console.WriteLine("  5   Venäjän Ruplaan.");
        kauttajanValinta = int.Parse(Console.ReadLine());

        if (kauttajanValinta == 1)
        {
            Console.WriteLine();
            Console.WriteLine(euro + " Euroa on:");
            Console.WriteLine(Math.Round(GBP, 2) + " Englannin Puntaa");
            Console.WriteLine("Valuutan kurssi verrattuna Euroon:  " + GBPe);

        }
        else if (kauttajanValinta == 2)
        {
            Console.WriteLine();
            Console.WriteLine(euro + " Euroa on:");
            Console.WriteLine(Math.Round(USD, 2) + " Amerikan Dollaria");
            Console.WriteLine("Valuutan kurssi verrattuna Euroon:  " + USDe);
        }
        else if (kauttajanValinta == 3)
        {
            Console.WriteLine();
            Console.WriteLine(euro + " Euroa on:");
            Console.WriteLine(Math.Round(JUAN, 2) + " Kiinan Juania");
            Console.WriteLine("Valuutan kurssi verrattuna Euroon:  " + JUANe);
        }
        else if (kauttajanValinta == 4)
        {
            Console.WriteLine();
            Console.WriteLine(euro + " Euroa on:");
            Console.WriteLine(Math.Round(JEN, 2) + " Japanin Jeniä");
            Console.WriteLine("Valuutan kurssi verrattuna Euroon:  " + JENe);
        }
        else if (kauttajanValinta == 5)
        {
            Console.WriteLine();
            Console.WriteLine(euro + " Euroa on:");
            Console.WriteLine(Math.Round(RUB, 2) + " Venäjän Ruplaa");
            Console.WriteLine("Valuutan kurssi verrattuna Euroon:  " + RUBe);
        }
        /* Muunnoksen kirjoitus säännöt ja pyöristys 2 desimaaliin
                    = Muunto alue + selite */
        else
        { }
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine(" Valuuttojen kurssit viimeksi päivitetty: 21.5.2022 ");
    Console.WriteLine("   Tervetuloa uudelleen!");
}
/*
            

            Console.WriteLine("Virheellinen valinta. Valitse muunnos: ");
            Console.WriteLine("     Englannin puntaan, 1.");
            Console.WriteLine("     Amerikan Dollariin, 2.");
            Console.WriteLine("     Kiinan Juaniin, 3.");
            Console.WriteLine("     Japanin Juaniin, 4,");
            Console.WriteLine("     Venäjän Ruplaan, 5.");
 */