class Program
{
    static void Main()
    {
        // Antaa päivämäärän
        DateTime currentDate = DateTime.Now.Date;
        Console.WriteLine("Päivämäärä tänään: " + currentDate.ToString("dd.MM.yyyy"));

        // Kysyy käyttäjän nimen
        Console.Write("Anna käyttäjänimi: ");
        string userName = Console.ReadLine();

        // Kysytään käyttäjän input
        Console.WriteLine("Anna mitä tahansa tekstiä ja paina Enter:");
        string userInput = Console.ReadLine();

        while (true)
        {
            // Lisää nykyisen kellonajan inputin eteen
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("\n\n\n" + currentTime.ToString("HH:mm:ss") + "\n\n" + userName + " " + userInput + "\n\n");
            // Asettelu on näin kai ihan riittävän hyvä...
            Console.WriteLine("Odottaa käyttäjän inputtia... Paina Enter kun olet valmis (lopettaaksesi syötä 'exit'):");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                break;
            }

            // Päivitä käyttäjän input
            userInput = input;
        }

        Console.WriteLine("Ohjelma päättyy.");
    }
}
