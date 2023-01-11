{
        Console.WriteLine("Using languake EN");
        Console.WriteLine("Hello, person that i dont know. What is your first name?");
        var firstName = Console.ReadLine();
        Console.WriteLine("I see. your first name is " + firstName + " Nice to meet you " + firstName);
        Console.WriteLine("My name is CSharpOne code. Arent i sharp one! ^_^ " + firstName);
        Console.WriteLine("Now that i know your first name, how about telling me your family name?");
        var familyName = Console.ReadLine();
        Console.WriteLine("Oh, you have such a unique name " + firstName + " " + familyName);
        Console.WriteLine("So... How old are you now?");
        var myAgeNow = Console.ReadLine();
        Console.WriteLine("Oh wow!" + myAgeNow + "you are so old! ..OMG! I didnt want to be rude! (XoX) " + firstName + familyName);
        Console.WriteLine("It must be because I was just born a few minutes a go. Years have so many minutes (0o0)");
        Console.WriteLine("It was so nice to meet you " + firstName + familyName + " of respectable age of" + myAgeNow + " years!");

        Console.WriteLine("Lets play some math now. Useing languake FI");

    {
        int luku1, luku2;
        double jaa, kerro, jjaannos;
        do
        {
            Console.Write("Anna ensimmäinen luku väliltä 1-10: ");
            luku1 = int.Parse(Console.ReadLine());
            if (luku1 < 1)
            {
                Console.WriteLine("Luku liian pieni! Anna suurempi luku.");
            }
            else if (luku1 > 10)
            {
                Console.WriteLine("Luku liian suuri! Anna pienempi luku.");
            }
        }
        while (luku1 >= 1 && luku1 <= 10);
        do
        {
            Console.Write("Anna seuraava luku väliltä 1-10: ");
            luku2 = int.Parse(Console.ReadLine());
            if (luku2 < 1)
            {
                Console.WriteLine("Luku liian pieni! Anna suurempi luku.");
            }
            else if (luku2 > 10)
            {
                Console.WriteLine("Luku liian suuri! Anna pienempi luku.");
            }
        }
        while (luku2 >= 1 && luku2 <= 10);

                    jaa = luku1 / luku2;
                    kerro = luku2 * luku1;
                    jjaannos = luku1 % luku2;
                    Console.WriteLine("Lukujen {0} ja {1} jakolaskun vastaus on {2}", luku1, luku2, jaa);
                    Console.WriteLine("Lukujen {0} ja {1} kertolaskun vastaus on {2}", luku1, luku2, kerro);
                    Console.WriteLine("Lukujen {0} ja {1} jakojäännös on {2}", luku1, luku2, jjaannos);
            
        
    }
        Console.WriteLine("Well done! Now I'M sorry, but have to go. " + firstName + " Follow the following isntructions to exit me.");
}