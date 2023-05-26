bool done = false;

while (!done)
{
    Console.Write("\"Anna jokin merkki, niin analysoin sen: ");
    string syote = Console.ReadLine();

    try // Yrittää koodia
    {
        char merkki = syote[0]; // Muuttuja (merkki) johon tallennetaan käyttäjän syöte, muuttujasta (syote)

        if (syote.Length != 1) // Jos syötteen pituus on enemmän kuin 1 merkki, jolloin se ei ole enää merkki, vaan tring.
        {
            throw new Exception("Virhe: Syötä vain yksi merkki kerrallaan!"); //  Antaa virheenkorjaus viestin
        }

        string vastaus = ""; //Tarvitaan väliaikaiseksi tallennuspaikaksi, jotta voidaan koota eri tulostus vaihtoehdot

        if (char.IsLetter(merkki))
        {
            if (char.IsUpper(merkki))
                vastaus = "Antamasi merkki '" + merkki + "' on iso kirjain.\n\n";
            else
                vastaus = "Antamasi merkki '" + merkki + "' on pieni kirjain.\n\n";
        }
        else if (char.IsDigit(merkki))
        {
            vastaus = "Antamasi merkki '" + merkki + "' on numero.\n\n";
        }
        else
        {
            vastaus = "Antamasi merkki '" + merkki + "' on erikoismerkki.\n\n";
        }

        Console.WriteLine(vastaus); // Tulostaa jonkin ylläolevista viesteistä riippuen annetusta merkistä
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message); // Nappaa ja tulostaa virhe ilmoituksen
    }

    Console.WriteLine();

    Console.Write("Haluatko suorittaa ohjelman uudelleen? (k/e): ");
    string valinta = Console.ReadLine();

    if (valinta == "e")
    {
        done = true;
    }
    else if (valinta != "k")
    {
        Console.WriteLine("Virhe: Anna joko 'k' tai 'e'.\n\n");
        continue;
    }

    Console.WriteLine();
}