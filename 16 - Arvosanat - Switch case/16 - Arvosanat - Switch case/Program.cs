Console.WriteLine("16 - Arvosanat\n\n");


bool exit = false;

while (!exit)
{
    Console.WriteLine("Anna arvosana väliltä 4-10:");
    string valinta = Console.ReadLine();

    if (int.TryParse(valinta, out int arvosana))
    {
        switch (arvosana)
        {
            case 4:
                Console.WriteLine("4 ... Paska. Jos saat näitä, häpeä.");
                break;
            case 5:
                Console.WriteLine("5 ... No ehkä et ole ihan paska jos näitä tulee.");
                break;
            case 6:
                Console.WriteLine("6 ... Kyllähän tämä välttää. Arvosana on välttävä.");
                break;
            case 7:
                Console.WriteLine("7 ... Tyydyttävä arvosana. Onneksi olkoon. Jos saat tätä arvosanaa paljonkin, sinut voi luokitella ihmiseksi apinan sijaan.");
                break;
            case 8:
                Console.WriteLine("8 ... Hyvä arvosana. Tästä ei ole enää mitään huonoa sanottavaa. Ole tyytyväinen jos olet kasin oppilas.");
                break;
            case 9:
                Console.WriteLine("9 ... Kiitettävä arvosana! Näistä ansaitset jo mitallin!");
                break;
            case 10:
                Console.WriteLine("10 ... Erinomaista! Tämä on paras mahdollinen arvosana! (Erinomainen)");
                break;
            default:
                Console.WriteLine("Virheellinen arvo!!\n");
                continue;
        }
    }
    else
    {
        Console.WriteLine("Anna numero!\n ");
        continue;
    }

    Console.WriteLine("Lopetetaanko? Valitse (k) lopettaaksesi tai (e) jatkaaksesi.");
    string exitK = Console.ReadLine();

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