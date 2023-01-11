Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("8.3 - Tuotteet & Hinnat yhteensä");
Console.WriteLine();                                      //  Switch case laske yhteensä kahvi kone https://www.youtube.com/watch?v=YsBU-tbTOy4
Console.WriteLine("---------------"); //Anna tuotteen 1. nimi:  
Console.WriteLine();                  //Anna tuotteen 1. hinta:  
                                      //Anna tuotteen 1. määrä:  (Hinnan kerroin)
                                      //Anna tuotteen 2. Nimi:
                                      // Anna  -||- ... jne.

Console.WriteLine("Anna tuotekategorioiden määrä (Kuinka monta erilaista tuotetta lisätään?)");
int num_of_product_categories = int.Parse(Console.ReadLine()); //Kuinka monta tuotetta lisätään 


        string[] nimi = new string[num_of_product_categories];
        int[] hinta = new int[num_of_product_categories];
        int[] maara = new int[num_of_product_categories]; 
        int jar_nro = 0;


    for (int j = 0; j <= num_of_product_categories - 1; j++)
    {

        jar_nro++;
        Console.Write("Anna " + jar_nro + ". tuotteen nimi ? "); //Tuotteen nimi
        nimi[j] = Console.ReadLine();
        Console.Write("Anna " + jar_nro + ". tuotteen määrä ? "); //Tuotteen määrä
        maara[j] = int.Parse( Console.ReadLine());
        Console.Write("Anna " + jar_nro + ". tuotteen hinta ? "); //Tuotteen hinta
        hinta[j] = int.Parse( Console.ReadLine());
        }

    for (int j = 0; j <= num_of_product_categories - 1; j++)
    {
        Console.WriteLine(nimi[j] + " " + hinta[j] * maara[j] + " euroa"); 
    }

/*
string[] prices = new string[] {products_amount};
string[] prices = new string[] {product_prices};  
*/
/*
Console.Write("How many different producte will be added to the list?");
int products_list_size = int.Parse(Console.ReadLine());
string[,,] products = new string[products_list_size];
while (int i = 0; i <= products_list_size; i++)
{
    Console.Write("Give name for a product {1} ", string.Parse(i)); // How do i assign code to give order number of the product? 1, 2, 3, etc. (Use while, or do while (0++) adds one during each cycle.)
    products[i] = Console.ReadLine(); 
} 
for (int i = 0; i < products.Length; i++)
{
    Console.Write(products[i] + " ");
}
Console.WriteLine();
Console.WriteLine();
*/
//(Ylläolevat tallessa vain ihan varmuudeksi)