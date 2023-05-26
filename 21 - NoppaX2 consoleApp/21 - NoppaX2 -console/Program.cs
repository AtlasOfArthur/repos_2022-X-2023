Random rnd = new Random();
int yht = 0;

for (int indx = 0; indx < 5; indx++) // Pyöräyttää 5 kertaa
{
    int noppa1 = rnd.Next(1, 7); // Arvotaan luku 1 ja 6 väliltä, noppa1
    int noppa2 = rnd.Next(1, 7); // Arvotaan luku 1 ja 6 väliltä, noppa2
       // Luvut ovat 1 ja 7 välillä, eli isompia kuin 0 ja pienempiä kuin 7 (eli max 6)
    Console.WriteLine("Heitto {0}: Noppa 1: {1}, Noppa 2: {2}", indx + 1, noppa1, noppa2); // Tulostetaan noppien arvot

    int summa = noppa1 + noppa2; // Lasketaan noppien summa
    Console.WriteLine("Summa: {0}\n", summa); // Tulostetaan summa omalla rivillään ja lisää tyhjän rivin sen jälkeen (\n)

    yht += summa; // Lisätään joka kierroksella kahden nopan summa yhteissummaan
}
                     // \n tuolostaa tyhjän ruvun ennen kuin tulostaa
Console.WriteLine("\nHeittojen yhteenlaskettu summa: {0}", yht); // Tulostetaan heittojen yhteissumma