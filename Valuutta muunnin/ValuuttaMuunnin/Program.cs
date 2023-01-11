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
    string kauttajanValinta = Console.ReadLine(); 
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

    /* Tämän linjan alle tulee if lauseet tai switch case */

    switch (kauttajanValinta)
    {
        case "1":
            Console.WriteLine(Math.Round(GBP, 2) + " Englannin Puntaa");
            Console.WriteLine("Valuutan kurssi verrattuna Euroon:  " + GBPe);
            break;
        case "2":
            Console.WriteLine(Math.Round(USD, 2) + " Amerikan Dollaria");
            Console.WriteLine("Valuutan kurssi rerrattuna Euroon:  " + USDe);
            break;
        case "3":
            Console.WriteLine(Math.Round(JUAN, 2) + " Kiinan Juania");
            Console.WriteLine("Valuutan kurssi rerrattuna Euroon:  " + JUANe);
            break;
        case "4":
            Console.WriteLine(Math.Round(JEN, 2) + " Japanin Jeniä");
            Console.WriteLine("Valuutan kurssi rerrattuna Euroon:  " + JENe);
            break;
        case "5":
            Console.WriteLine(Math.Round(RUB, 2) + " Venäjän Ruplaa");
            Console.WriteLine("Valuutan kurssi rerrattuna Euroon:  " + RUBe);
            break;
        default:
            Console.WriteLine("Virheellinen valinta. Valitse muunnos: ");
            Console.WriteLine("     Englannin puntaan, 1.");
            Console.WriteLine("     Amerikan Dollariin, 2.");
            Console.WriteLine("     Kiinan Juaniin, 3.");
            Console.WriteLine("     Japanin Juaniin, 4,");
            Console.WriteLine("     Venäjän Ruplaan, 5.");
            break;
    }      /*Muunnoksen kirjoitus säännöt ja pyöristys 2 desimaaliin
                = Muunto alue + selite/"otsikko"*/

    if (kauttajanValinta != "1" || "2" || "3" || "4" || "5")
    {
        Console.WriteLine("Syötä kelvollinen valinta: ");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine(" Valuuttojen kurssit viimeksi päivitetty: 21.5.2022 ");
    Console.WriteLine("Tervetuloa uudelleen!");

}
