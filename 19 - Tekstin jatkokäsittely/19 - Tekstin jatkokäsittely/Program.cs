bool jatkaOhjelmaa = true;

while (jatkaOhjelmaa)
{

    Console.Write("\nAnna teksti ja lasken kuinka monta 'a' kirjainta tekstissä on.\nLisäksi kerron monesko kirjain merkkijonossa kukin 'a' kirjain on\n\n");
    string syote = Console.ReadLine();

    int maara = 0;
    string aat = "";

    for (int i = 0; i < syote.Length; i++)
    {
        if (syote[i] == 'a' || syote[i] == 'A') 
        {                         /* Vertaa milloin syötteen sisällä indeksi(#) == ([i] = indeksi) on täytetty kirjaimella 'a' tai'A' */        
            maara++;              /* Aina kun syötteessä indeksi vastaa (a) kirjainta lisätää laskuriin yhden */
            aat += (i + 1) + " "; /* Aina kun (a) on löydetty syötteestä, kirjataan sen indeksi aat muuttujaan */
        } /*       (i + 1) Koska eka indeksi on 0           */
    }
    if (maara > 0)                /* Jos yhtään a kirjainta ei löydy */
    {
        Console.WriteLine("\n\nAntamassasi tekstissä on " + maara + " 'a' kirjainta\n ");
        Console.WriteLine("'a'-kirjainten paikat: " + aat);
    }
    else
    {
        Console.WriteLine("\n\nAntamassasi tekstissä ei ole yhtään 'a' kirjainta.");
    }
    Console.WriteLine("\nJatkaaksesi valitse 'k' ja paina enter ");
    string vastaus = Console.ReadLine();

    if (vastaus.ToLower() != "k" && vastaus.ToLower() != "kyllä")
    {
        jatkaOhjelmaa = false;
    }
}