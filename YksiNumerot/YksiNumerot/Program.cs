namespace YksiNumerot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tapaa 1: merkkijonojen käyttö suoraan
            Console.WriteLine("Tapaa 1:");
            Console.WriteLine("1");
            Console.WriteLine("11");
            Console.WriteLine("101");
            Console.WriteLine("1001");
            Console.WriteLine("\n\n");

            // Tapaa 2: merkkijonojen muotoilu
            Console.WriteLine("Tapaa 2:");
            Console.WriteLine("{0}", 1);
            Console.WriteLine("{0}", 11);
            Console.WriteLine("{0}", 101);
            Console.WriteLine("{0}", 1001);
            Console.WriteLine("\n\n");

            // Tapaa 3: string.Format-metodi
            Console.WriteLine("Tapaa 3:");
            Console.WriteLine(string.Format("{0}", 1));
            Console.WriteLine(string.Format("{0}", 11));
            Console.WriteLine(string.Format("{0}", 101));
            Console.WriteLine(string.Format("{0}", 1001));
            Console.WriteLine("\n\n");

            // Tapaa 4: for-silmukkaa, potenssit(Marh.Pow) ja if ehto
            Console.WriteLine("Tapaa 4:");
            for (int i = 0; i < 4; i++)
            {
                int number = (int)Math.Pow(10, i);

                if (number >= 10) // Ilman ehtoa, printtaisi ensimäiseksi numeroksi (2)
                {
                    number += 1;
                }

                Console.WriteLine(number);
            }


        }
    }
}