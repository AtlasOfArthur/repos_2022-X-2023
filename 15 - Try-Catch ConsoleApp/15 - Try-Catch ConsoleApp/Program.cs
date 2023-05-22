using System.Reflection.Emit;
using System.Runtime.CompilerServices;

Console.WriteLine("Weell heelloo, Maailma!\n");
Console.WriteLine("Tehtävä 15. Try Catch Finally");
Console.WriteLine("-----------------------------\n");



label:
// Try block: The code which may raise exception at runtime
try
{
    int luku1, luku2;
    decimal tulos;

    Console.WriteLine("Jakolasku ohjelma: Anna 2 lukua ja palautan tuloksen");
    Console.WriteLine("Anna eka luku: ");
    luku1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Anna toka luku: ");
    luku2 = Convert.ToInt32(Console.ReadLine());

    tulos = (decimal)luku1 / (decimal)luku2;
    Console.WriteLine("Divide : " + tulos.ToString());
    Console.ReadLine();
}

//Multiple Catch block to handle exception

catch (DivideByZeroException dex)
{
    Console.WriteLine("Annoit luvun 0.Ei voi jakaa nollalla! ");
    Console.WriteLine("Lisää tietoja virheestä: \n\n" + dex.ToString() + "\n\n");
    goto label;
}

catch (FormatException fex)
{
    Console.WriteLine("Virheellinen valinta!");
    Console.WriteLine("Lisää tietoja virheestä: \n\n" + fex.ToString() + "\n\n");
    goto label;
}

//Parent Exception: Catch all type of exception

catch (Exception ex)
{
    Console.WriteLine("Muut poikkeuikset" + ex.ToString() + "\n\n"); 
    // voi olla muukin kuin ex (ex on vain muuttujan nimi) mutta yleisesti tämän poikkeuksen nimeä käytetään ex
    goto label;
}

//Finally block: it always executes || Kun kaikki menee oikein pääsee tänne ja tämä osio suoritetaan aina loopin lopussa

finally
{
    Console.WriteLine("Finally: Jatkaaksesi paina [ENTER] & [CTRL + C] poistuaksesi");
    Console.ReadLine();
}
