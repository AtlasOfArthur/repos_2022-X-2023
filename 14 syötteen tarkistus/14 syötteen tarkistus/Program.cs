Console.WriteLine("Tehtävä 14 syötteen tarkistus");
Console.WriteLine(".............................\n");
/*
 * Tee ohjelma, joka kysyy käyttäjältä kokonaisluvun ("Anna kokonaisluku: ")
 * Joka muuntaa sen esimerkin mukaan                 ("Converted " ??? " to " ???")
 * Jos ei kelvollinen                                ("Attempted conversion of " ??? " failed. SORRY!"
 */
bool jatka = true;

while (jatka) // while looppi jatkaa kunnes TryParse muunnos onnistuu
{
    Console.Write("Anna kokonaisluku ");
    string eiNro = Console.ReadLine(); 
                          /* Tallennetaan kokonaisluku string muuttujaksi,
                           * koska se voi "esiintyä" sekä numerona että merkkijonona näytöllä
                           * (mutta on siis merkkijono kuitenkin, koska (string)) */
                           
    int numero = 0;       // int muuttuja TryParse muunnosta varten
    bool tryParseOnnistui = int.TryParse(eiNro, out numero);
                          // Pyrki muuntamaan string (eiNro) muuttujan int muuttujaksi (numero)

    if (tryParseOnnistui) // Jos try parse onnistuu
    {
        jatka = false;    // Asetetaan jatka falseksi, jotta ei jatka enää jos TryParse onnistuu
        Console.WriteLine("Converted " + eiNro + " to " + numero + "    CONGRATULATIONS!\n");
    }
    else                 // Jos TryParse ei onnistu
    {
        Console.WriteLine("Attempted conversion of " + eiNro + " failed. SORRY!");
                          // jos eiNro ei ole numero, se ei muunnu numeroksi, jolloin se ei tallennu (int) numero muuttujaan. (menee pieleen)
    }
    Console.WriteLine("\n\n"); // Pari väliä vaan jokaisen yrityksen jälkeen selkeytyksen vuoksi
}
Console.WriteLine("You reached the end of the program. Bye!");