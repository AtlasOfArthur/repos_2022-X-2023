  /* Tee ohjelma, joka laskee käyttäjän antamia kokonaislukuja reaaliajassa
   * ja näyttää annetun luvun jälkeen sen hetkisen summan. 
   * Ohjelma jatkaa lukujen kyselyä while-lauseella, kunnes summa on >=100. 
   * Lopuksi käyttäjälle tulostetaan teksti "Raja on saavutettu !". */
Console.WriteLine("10.1 Lukujen summa \n");
Console.WriteLine("Anna kokonaislukuja, niin lasken niiden summan reaaliajassa. \n");

int j_num = 0;
int kokluk = 0;
int summa = 0;

while (summa < 100)
{
    j_num++;
    Console.WriteLine("Anna luku numero " + j_num + ".");
    kokluk = int.Parse(Console.ReadLine());
    summa = summa + kokluk;
    Console.WriteLine("Kokonaiskukujen summa on nyt: " + summa + "\n");

}
if (summa == 100)
{
    Console.WriteLine("Tasan 100! Raja on saavutettu.");
}
else if (summa >= 101)
{
    Console.WriteLine("Kokonaislukujen summa on nyt: " + summa + " Raja on ylitetty!");
}