Console.WriteLine("7.2 Lukujen laskenta");
{
    int x;
    int y;
    int i;
    Console.Write("Anna luku ");
    x = int.Parse(Console.ReadLine());
    {
        for (y = 1; y <= 5; y++)
        for (i = 1; i <= x; i++)
        {
            Console.Write(i+" * "+y+" = "+(i * y)+"   ");
            
            Console.Write(i + " / " + y + " = " + (i / y) + "   ");
            
            Console.Write(i + " % " + y + " = " + (i % y) + "   ");
                Console.WriteLine();
                Console.WriteLine();
        }
    }
}