﻿namespace olio1
{
    public class Kirjasto
    {
        // Kentät (field)  -  määriteltäväsi tyypit (mm. kirjan nimi, sivumäärä, kirjailija jne.)
        // (Kentät kirjoitetaan isolla (PascalCase), koska parametrit kirjoitetaan pienellä (camelCase)
        // Menee parametrit ja kentät helposti sekaisin jos näin ei tee. Koulun materiaali ei taaskaan kerro tätä ja malli on tältä osin tehty väärin.
        public string KirjanNimi;
        public string LehdenNimi;
        public string Kirjailija;
        public string Takakansi;
        public string Juttu;
        public int SivuMaara;
        public bool Kuuluisa;
        

        

        // OLETUSKONSTRUKTORI (Huomioi että konstruktoreilla ei ole oletus palautus tyyppiä koten muilla metodeilla)
        // (Konstruktori on siis metodi. Miksi tätä ei kerrottu koulun materiaalissa!? Koulun materiaali on muutenkin tosi usein hyvin epämääräinen. En ymmärrä siitä koskaan mitään.)
        public Kirjasto() // Kuomioi, että sama nimi kuin luokalla (class). Kutsutaan kun luokan Kirjasto instanssi (ilmentymä) luodaan.
        {

            

        } 

       /* YLIKUORMITETTU KONSTRUKTORI

       {

           _

       } */

        /* ominaisuusfunktiot:

        {

            _

        }*/
        

        //metodit esim:

        public string PalautaTeoksenNimi()
        {
            Console.WriteLine("PalautaTeoksenNimi metodia käytetty");
            return KirjanNimi;


        }
        public void TietojaTeoksesta()
        {
            Console.WriteLine($"Teoksen nimi on {KirjanNimi} ja sen on kirjoittanut {Kirjailija}. \n\n Takakannen teksti: \n {Takakansi} ");
        }

        // + Metodit: Lainaa + Palauta
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //luodaan esim. kirja-olio
            Kirjasto remesKirjaOlio = new Kirjasto();
            remesKirjaOlio.Kirjailija = "Ilkka Remes";
            remesKirjaOlio.KirjanNimi = "Kertomus kahdesta kaupungista";
            remesKirjaOlio.SivuMaara = 550;
            remesKirjaOlio.Takakansi = "\tKertomus kahdesta kaupungista on jännittävä, tositapahtumiin perustuva romaani, joka sijoittuu\n\t1800-luvun lopun Lontooseen ja Pietariin.\n\n\tKaksi nuorta miestä, venäläinen Dimitri ja britti Arthur, rakastuvat samaan naiseen, kauniiseen ja\n\tälykkääseen Nataliaan. Natalian isä on venäläinen diplomaatti, joka asuu Lontoossa. Kun Natalian isä \n\tjoutuu salaperäisesti murhatuksi, Dimitri ja Arthur joutuvat keskelle vaarallista juonittelua, joka \n\tulottuu molempien maiden hallitusten korkeimpiin kerroksiin.\n\n\tKertomus kahdesta kaupungista on jännittävä ja kiehtova tarina, joka pitää lukijan otteessaan\n\tloppuun asti. ";
            remesKirjaOlio.Kuuluisa = true;

            remesKirjaOlio.TietojaTeoksesta();

            //luodaan esim. lehti-olio
            Kirjasto helsinginSanomatKirjastoOlio = new Kirjasto();
            helsinginSanomatKirjastoOlio.LehdenNimi = "Helsingin Sanomat";
            helsinginSanomatKirjastoOlio.Juttu = "Suomen presidentti Sauli Niinistö tapaa Venäjän presidentti Vladimir Putinin Moskovassa tiistaina. Tapaamisessa käsitellään muun muassa Suomen ja Venäjän välisiä suhteita sekä Euroopan turvallisuustilannetta.\n\tSuomi voitti jääkiekon maailmanmestaruuden voittamalla loppuottelussa Kanadan maalein 4-3. Suomi voitti maailmanmestaruuden ensimmäistä kertaa sitten vuoden 2019.\n\tHallitus päätti uusista koronarajoituksista, jotka tulevat voimaan ensi viikolla. Rajoitukset koskevat muun muassa ravintoloita, tapahtumia ja matkustamista.\n\tMetsäpalot riehuvat Etelä-Euroopassa, ja niiden leviämisen odotetaan jatkuvan. Metsäpalot ovat aiheuttaneet jo merkittävää tuhoa.\n\tYhdysvaltalainen liikemies Elon Musk on ostanut Twitterin 44 miljardilla dollarilla. Musk on kertonut, että aikoo tehdä Twitteristä vapaamman ja avoimemman alustan.";

            //luodaan esim. dokumentti-olio

            //tulostetaan tiedot
        }
    }
} 


