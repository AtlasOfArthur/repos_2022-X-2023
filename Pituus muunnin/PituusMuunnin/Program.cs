// See https://aka.ms/new-console-template for more information


{
    Console.WriteLine("Kuinka pitkä olet? (Sentteinä) ");
    int pituus = int.Parse(Console.ReadLine()); /*pituuden muuttuja*/
    Console.WriteLine(); /*Tyhjä rivi*/
    Console.WriteLine("  Muunnos:");

    double tuumaa = pituus * 0.3937;
    double mailia = pituus * 0.000006;
    double jaardia = pituus * 0.0109;
    double metriä = pituus * 0.0100;
    /*Muunnoksen määrä suhteessa lukuun 1 metri*/

    string tuu = string.Format("{0:0.00}", tuumaa);
    string mai = string.Format("{0:0.00}", mailia);
    string jaa = string.Format("{0:0.00}", jaardia);
    string met = string.Format("{0:0.00}", metriä);
    /*Muunto alue*/

    Console.WriteLine(met + "metriä");
    Console.WriteLine(mai + "mailia");
    Console.WriteLine(jaa + "jaardia");
    Console.WriteLine(tuu + "tuumaa");
}   /*Muunnoksen kirjoitus säännöt
      = Muunto alue + selite/"otsikko"*/