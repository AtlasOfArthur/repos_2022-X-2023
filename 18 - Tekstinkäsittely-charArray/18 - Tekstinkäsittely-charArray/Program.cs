
        Console.Write("Anna haluamasi syöte ja vääntelen sen solmuun: "+"\n\n");
        string syote = Console.ReadLine();
        string takap = " ";
        string harv = " ";
        string takapharv = " ";

        /*--------------------EXTRA-----------------------*/
        string etup246 = " ";
        string takap246 = " ";
        /*-------------------^EXTRA^----------------------*/

        for (int i = syote.Length - 1; i >= 0; i--)
        {
             takap += syote[i];
        }


        for (int i = 0; i < syote.Length; i ++)
        {
              harv += syote[i] + " ";
        }


        for (int i = syote.Length - 1; i >= 0; i --)
        {
              takapharv += syote[i] + " ";
        }

        /*--------------------EXTRA-----------------------*/
        for (int i = 0; i < syote.Length; i += 2)
        {
            etup246 += syote[i];
        }
        for (int i = syote.Length - 1; i >= 0; i -= 2)
        {
            takap246 += syote[i];
        }
        /*-------------------^EXTRA^----------------------*/
        
        Console.Write("Antamasi syöte: "+ (syote) + "\n\n");
        Console.Write( "Syöte takaperin: " + (takap) + "\n\n");
        Console.Write("Syöte harvasti: " + (harv) + "\n\n");
        Console.Write("Syöte takaperin ja harvasti: " + (takapharv) + "\n\n\n\n");

        /*--------------------EXTRA-----------------------*/
        Console.WriteLine("EXTRA\n");
        Console.Write("Etuperin, jokatoinen merkki poistettu: " + etup246 + "\n\n");
        Console.Write("Takaperin, jokatoinen merkki poistettu: " + takap246 + "\n\n");
        /*-------------------^EXTRA^----------------------*/