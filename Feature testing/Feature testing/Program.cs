// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Thread.Sleep(4000);
Console.Write("Tervetuloa käyttämään säätilat sovellusta 1.0 ...");
Thread.Sleep(4000);
Console.Write(" paina mitä tahansa näppäintä jatkaaksesi ... ");
Thread.Sleep(4000);

{
    {
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            var randomString1 = GenerateRandomString(random, 4);
            Console.WriteLine(randomString1);
        }
        Console.WriteLine("text1");
        Console.ReadKey();
    }
    static string GenerateRandomString(Random random, int stringLength)
    {
        const string allowedWords = { "One", "Two", "Three", "Four" };
        var randomString1 = new string(Enumerable.Repeat(allowedWords, stringLength)
            .select(a => a[Random.Next(a.Length)]).ToAttay());
        return randomString1;
    }

}