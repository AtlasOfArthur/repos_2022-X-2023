{   Console.WriteLine("Hei. Kerro oletko (U) -uros vai (N) -naaras");
    char un = Char.Parse(Console.ReadLine());
    Console.WriteLine();
    
    if (un == 'n' || un == 'N' || un == 'u' || un == 'U') //Tähän jos laittaisi "if" tilalle "while", jatkaisi kyselyä loputtomasti. Oli kätevä testatessa.
    {
        Console.Write("Kiitos että määritit sukupuolesi ohjeistuksen mukaan!");
        Console.WriteLine("Anna seuraavaksi ikäsi vuosina ... ");
        int ika = int.Parse(Console.ReadLine());

        if (ika >= 125)
        {
            Console.Write("Älä valehtele. Et voi olla noin vanha!");
            Console.WriteLine("Anna kelvollinen ikä ... ");
            ika = int.Parse(Console.ReadLine());
        }
        else if (ika < 125) 
        {
            Console.WriteLine();
            Console.WriteLine("Olet siis väittämäsi mukaan " + ika + " vuotias.");
        }

        if ((un == 'u') || (un == 'U'))
        {
            if ((ika >= 1) && (ika <= 14))
            {
                Console.WriteLine();
                Console.WriteLine("Valitsit uros ja ikäsi on " + ika + ". Olet siis poika");
            }
            else if ((ika >= 15) && (ika <= 25))
            {
                Console.WriteLine();
                Console.WriteLine("Valitsit uros ja ikäsi on " + ika + ". Olet siis nuori mies");
            }
            else if ((ika >= 16) && (ika <= 57))
            {
                Console.WriteLine();
                Console.WriteLine("Valitsit uros ja Ikäsi on " + ika + ". Olet siis mies parhaassa iässä! ");
            }
            else if ((ika >= 58) && (ika <= 124))
            {
                Console.WriteLine();
                Console.WriteLine("Valitsit uros ja ikäsi on " + ika + ". Olet siis pappa, eli mies korkeassa iässä! ");
            }
            else
            { }
        }

        if ((un == 'n') || (un == 'N'))
            {
                if ((ika >= 1) && (ika <= 14))
                {
                    Console.WriteLine();
                    Console.WriteLine("Valitsit naaras ja käsi on " + ika + ". Olet siis tyttö");
                }
                else if ((ika >= 15) && (ika <= 25))
                {
                    Console.WriteLine();
                    Console.WriteLine("Valitsit naaras ja ikäsi on " + ika + ". Olet siis nuori nainen");
                }
                else if ((ika >= 16) && (ika <= 57))
                {
                    Console.WriteLine();
                    Console.WriteLine("Valitsit naaras ja ikäsi on " + ika + ". Olet siis nainen parhaassa iässä! ");
                }
                else if ((ika >= 58) && (ika <= 124))
                {
                    Console.WriteLine();
                    Console.WriteLine("Valitsit naaras ja ikäsi on " + ika + ". Olet siis mummu, eli nainen korkeassa iässä! ");
                }
                else
                { }
        }
    }
}
