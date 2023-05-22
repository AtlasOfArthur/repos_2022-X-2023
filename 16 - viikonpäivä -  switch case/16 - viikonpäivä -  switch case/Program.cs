Console.WriteLine("Tehtävä 16 - Viikonpäivät, switch case\n--------------------------------------\n\n");

static string GetPaivanNimi(int numero) // Aliohjelma viikonpäiville. Tulostaa viikonpäivän annetun numeron perusteella.
{
    switch (numero)
    {
        case 1:
            return "Maanantai";
        case 2:
            return "Tiistai";
        case 3:
            return "Keskiviikko";
        case 4:
            return "Torstai";
        case 5:
            return "Perjantai";
        case 6:
            return "Lauantai";
        case 7:
            return "Sunnuntai";
        default:
            return null;
    }
}
bool exit = false; // Exit boolean lopettamista varten
string exitK; // string muuttuja käyttäjän vastaukselle kun kysytään että lopetetaanko
string valinta; // Käyttöjän valinta (viikonpäivän numero) 1-7 tallentuu tähän
string paivanNimi; // Päivän nimi tallentuu tähän käyttäjän valinnan mukaan 1-7

while (!exit)
{
    {
        Console.WriteLine("Anna numero väliltä 1-7:");
        valinta = Console.ReadLine();

        if (int.TryParse(valinta, out int numero))
        {
            paivanNimi = GetPaivanNimi(numero); // Hakee vastaavuutta annetulle valinnalle aliohjelmasta (GetPaivanNimi)
            if (paivanNimi != null) // Kun paivanNimi muuttuja ei ole tyhjä ja valinta löytyy switch case rakenteesta (GetPaivanNimi)
            {
                Console.WriteLine($"Antamaasi numeroa vastaava viikonpäivä on: {paivanNimi}"); //Tulostaa annettua numeroa vastaavan päivän nimen
            }
            else // Kun käyttäjän antama numero (tai arvo/merkki) ei ole switch case rakenteen sisällä
            {
                Console.WriteLine("Virheellinen valinta! Anna numero väliltä 1-7\n\n ");
                continue;
            }
        }
        else
        {
            Console.WriteLine("Anna numero kiitos...\n");
            continue;
        }

        Console.WriteLine("Lopetetaanko? Valitse (k) lopettaaksesi tai (e) jatkaaksesi.");
        exitK = Console.ReadLine();

        if (exitK.ToLower() == "k")
        {
            exit = true;
        }
        else if (exitK.ToLower() == "e")
        {
            continue;
        }
        else
        {
            Console.WriteLine("Valitse (k) tai (e)\n");
        }

        Console.WriteLine();
    }
}