


    char YN1;
    Console.WriteLine("Press (Y/N)");
    YN1 = Char.Parse(Console.ReadLine());


while (YN1 != 'Y' || YN1 != 'y')
{
    Console.WriteLine("Invalid experssion press Y or N !");
    YN1 = Char.Parse(Console.ReadLine());
    if (YN1 == 'Y' || YN1 == 'y')
    {

        Console.WriteLine("You pressed Y or y");
        Console.WriteLine("Press now N");

        while (YN1 != 'N' || YN1 != 'n')
        {
            Console.WriteLine("Please press N or n to continue");
            YN1 = Char.Parse(Console.ReadLine());
            if (YN1 == 'N' || YN1 == 'n')
            {
                Console.WriteLine("Congratulations!");
            }
        }
    }
}