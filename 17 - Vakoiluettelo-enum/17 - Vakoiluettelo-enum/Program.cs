
enum Valinta
{
    LisaaNimi = 1,
    LisaaIka = 2,
    NaytaNimi = 3,
    NaytaIka = 4,
    Poistu = 5,
}

class Program
{
    static void TulostaValikko()
    {
        Console.WriteLine("---------------------\nValitse toiminto:\n- - - - - - - - - - -");
        Console.WriteLine($"{(int)Valinta.LisaaNimi}. Lisää nimi");
        Console.WriteLine($"{(int)Valinta.LisaaIka}. Lisää ikä");
        Console.WriteLine($"{(int)Valinta.NaytaNimi}. Näytä nimi");
        Console.WriteLine($"{(int)Valinta.NaytaIka}. Näytä ikä");
        Console.WriteLine($"{(int)Valinta.Poistu}. Poistu ohjelmasta\n---------------------\n");
    }

    static void Main()
    {
        bool exitRequest = false;
        string nimi = " ";
        double ika = 0;

        while (!exitRequest)
        {
            TulostaValikko();
            string input = Console.ReadLine();

            if (Enum.TryParse(input, out Valinta valinta))
            {
                switch (valinta)
                {
                    case Valinta.LisaaNimi:
                        Console.WriteLine("Lisää nimi valittu.");
                    AnnaNimi:
                        Console.Write("\nOle hyvä ja anna nimesi: ");
                        nimi = Console.ReadLine();
                        break;

                    case Valinta.LisaaIka:
                        Console.WriteLine("Lisää ikä valittu.");
                    AnnaIka:
                        Console.Write("\nOle hyvä ja anna ikäsi: ");
                        string ikaInput = Console.ReadLine();
                        if (double.TryParse(ikaInput, out double parsedIka))
                        {
                            ika = parsedIka;
                        }
                        else
                        {
                            Console.WriteLine("Virheellinen syöte. Anna ikä numerona.");
                            goto AnnaIka;
                        }
                        break;

                    case Valinta.NaytaNimi:
                        Console.WriteLine("Näytä nimi valittu.");
                        if (string.IsNullOrEmpty(nimi))
                        {
                            Console.WriteLine("Nimeä ei ole vielä annettu.");
                            goto AnnaNimi;
                        }
                        else
                        {
                            Console.WriteLine(nimi);
                        }
                        break;

                    case Valinta.NaytaIka:
                        Console.WriteLine("Näytä ikä valittu.");
                        if (ika == 0)
                        {
                            Console.WriteLine("Ikää ei ole vielä annettu.");
                            goto AnnaIka;
                        }
                        else
                        {
                            Console.WriteLine(ika);
                        }
                        break;

                    case Valinta.Poistu:
                        Console.WriteLine("Haluatko poistua? (k/e).");
                        string exitvastaus = Console.ReadLine();
                        if (exitvastaus.ToLower() == "k")
                        {
                            exitRequest = true;
                        }
                        else
                        {
                            continue;
                        }
                        break;

                    default:
                        Console.WriteLine("Virheellinen valinta.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Virheellinen valinta. Syötä oikea valinta numerona.");
            }

            Console.WriteLine();
        }
    }
}