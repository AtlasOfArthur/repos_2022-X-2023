/*Tee ohjelma, joka ensin arpoo kokonaisluvun 1-12 väliltä.
 * Käyttäjältä kysytään arvauksia luvusta (While-lause) kunnes käyttäjä arvaa oikein ("Onneksi olkoon, arvasit oikein !!")
 * Tai käyttäjä haluaa lopettaa "L" kirjaimella ("Lopetetaan..." + "Halusit lopettaa LUUSERI !!" + kerrotaan oikea vastaus). */
Console.WriteLine("10.2 Luvun arvaus \n");
Console.WriteLine("Ohjelma arpoo kokonaisluvun 1-12 väliltä.");
Console.WriteLine("Tehtäväsi on arvata arvottu luku. Voit myös halutessasi lopettaa kesken painnamalla (L) näppäintä.\n");

Random rnd = new Random();          // Luo uuden randomin
int satunnainen = rnd.Next(1, 13);  // Arvotaan luku 1-12 väliltä 

int yritysnum = 0;                  // Käyttäjän yrityskerrat
int arvaus = 0;                     // Käyttäjän valinta
int pelit = 0;                      // Laskee pelattujen pelien määrän
string lopetusvastaus = "";         // Oikean vastauksen jälkeen (Jatketaanko (K/E)
string keskeytys = "";              // Käytetään kun käyttäjä haluaa lopettaa kesken (L)


while (keskeytys != "L")
{
    yritysnum++;                    //Toimii
    Console.WriteLine("Anna  " + yritysnum + ". arvauksesi tai voit lopettaa kesken (L)"); //Toimii
    Console.WriteLine("Satunnaisnumero on " + satunnainen); //Auttaa testaamisessa
    keskeytys = Console.ReadLine();
    keskeytys = keskeytys.ToUpper();
    if (keskeytys != "L")
    {
        if (int.TryParse(keskeytys, out arvaus)) ; //Katso (TryParse) esimerkkejä netistä
        //Keskeytys(String) arvauksesta (int) eli jos ei ole numero, sanoo vaan että VÄÄRIN
            //yritysnum--; //vähentää yhden, koska ei ollut numero... miten?
            if (arvaus == satunnainen)
            {
                Console.WriteLine("ONNEKSIOLKOON! Vastasit OIKEIN!");
                Console.WriteLine("Peli päättyi. Jatketaanko? K/E"); // Valitse K jatkaaksesi tai E lopettaaksesi
                lopetusvastaus = Console.ReadLine();
                lopetusvastaus = lopetusvastaus.ToUpper();  //Aina iso kirjain vaikka laittaisit pienen
                if (lopetusvastaus == "K")
                {
                    Console.WriteLine("Peli alkoi alusta."); Thread.Sleep(1000);
                    Console.WriteLine("Arvotaan uusi satunnainen"); Thread.Sleep(1000); Console.Write("."); Thread.Sleep(300); Console.Write("."); Thread.Sleep(300); Console.Write(".  "); Thread.Sleep(300);
                    //PITÄISI NOLLATA yritysnum JOTTA ALKAA TAAS NUMEROSTA 1.
                    yritysnum = 0; //Näin
                    pelit++;
                }
                else if (lopetusvastaus == "E")
                {
                    keskeytys = "L";
                    Console.WriteLine("Hei hei. Toivottavasti pelaat uudestaan"); Thread.Sleep(5000); // Lopettaa kesken sen jälkeen kun vähintään yksi oikea vastaus on saatu
                    Console.WriteLine("Oikea satunnainen oli: " + satunnainen);
                    break;
                }
                rnd = new Random();          // Luo uuden randomin
                satunnainen = rnd.Next(1, 13);  // Arvotaan luku 1-12 väliltä
                Console.WriteLine("Satunnaisnumero on " + satunnainen);
            }
            else if (arvaus != satunnainen)
            {
                Console.WriteLine("VÄÄRIN! Yritä uudestaan. Lopeta kesken vastaamalla L"); //Antaa vain viestin ja alaa kysymään kunnes oikein
            }
                //(VASTAAMINEN (E)LLÄ EI SAISI OLLA MAHDOLLISTA TÄSSÄKOHTAA. VAIN yritysnum TAI (L) ?MITEN TEEN?
                 // (Ei kuulunut tehtävään, joten ratkaise joskus toiste)
    }
}
if (keskeytys == "L" && pelit == 0 && yritysnum == 1) Console.WriteLine("LUUSERI! Et edes pelannut! Oikea satunnainen oli: " + satunnainen);//Jos lopettaa pelaamatta ollenkaan
if (keskeytys == "L" && pelit == 1 && yritysnum == 1) Console.WriteLine("Olisit edes yrittänyt! LUUSERI! Oikea satunnainen oli: " + satunnainen);
if (keskeytys == "L" && pelit == 1 && yritysnum >= 2) Console.WriteLine("Hyvä yritys! Toivottavasti pelaat uudestaan! Oikea satunnainen oli: " + satunnainen);
if (keskeytys == "L" && pelit >= 2 && yritysnum >= 2) Console.WriteLine("Kiitos että jaksoit pelata ainakin yhden kierroksen! Toivottavasti pelaat uudestaan! Oikea satunnainen oli: " + satunnainen);
yritysnum--; //Vähentää yhden koska lopetuksessa lisätty yritysnumero on ylimääräinen
Console.WriteLine("Pelin tulokset: Pelatut pelit: " + pelit + "   Yritykset edellisen pelin aikana: " + yritysnum) ;