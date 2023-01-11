{


    Console.Write("Tervetuloa käyttämään säätilat sovellusta 1.0 ...");
    Thread.Sleep(2000);
    Console.WriteLine("Tunnustellaan valon määrää ");
    Console.WriteLine();
    Console.WriteLine("LOADING"); Thread.Sleep(1000); Console.Write(" ."); Thread.Sleep(1000); Console.Write(" ."); Thread.Sleep(1000); Console.Write(" ."); Thread.Sleep(1000);
    Console.WriteLine();
    Console.WriteLine("Paistaako nyt aurinko? (K/E) "); /* 200 riviä toimivaa koodia While looppi ei toimi oikein, mutta toimii kuitenkin!
                                                         * sitä ei kuitenkaan tässä tehtävässä vaadittu edes, joten oletan että
                                                         on tarpeaksi hyvä   */
    {
        char aurinko = Char.Parse(Console.ReadLine());
        while (aurinko != 'K' || aurinko != 'k' || aurinko != 'E' || aurinko != 'e')
        {
            Console.WriteLine("Anna kelvollinen valinta (K/k/E/e)");
            aurinko = Char.Parse(Console.ReadLine());

            if (aurinko == 'K' || aurinko == 'k' || aurinko == 'E' || aurinko == 'e')
            {
                Console.WriteLine("Kiitos että annoit kelvollisen valinnan!");
                Console.WriteLine();
                Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500);

                if (aurinko == 'K' || aurinko == 'k')
                {
                    Console.WriteLine("Voi miten mukavaa että aurinko paistaa!"); Thread.Sleep(500); Console.Write(" . . . Mutta kannattaa silti varmaan toivoa että otsonikerros pitää kutinsa.");
                    Thread.Sleep(500); Console.WriteLine("No mutta ei siitä sen enempää ja seuraavaan kysymykseen!");
                    Thread.Sleep(500); Console.WriteLine("Miltäs ulkona mahtaa nyt näyttää? Sataako vettä? (H/R)");
                    Console.WriteLine("HMMM..."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500);
                    Console.WriteLine("Voi jestas. Taisin munata. Sanomani piti olla 'Miltäs ulkona mahtaa nyt näyttää ? Sataako vettä? (K/E)' ");

                    char sataa = Char.Parse(Console.ReadLine());
                    while (sataa != 'K' || sataa != 'k' || sataa != 'E' || sataa != 'e')
                    {
                        Console.WriteLine("Anna kelvollinen valinta (K/k/E/e)");

                        if (sataa == 'K' || sataa == 'k')
                        {
                            Console.WriteLine("HAIST PASKA MÄRKÄ PILVI! >:( "); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500);
                            Thread.Sleep(500); Console.WriteLine("Anteeksi. Me tietokoneet emme vain pidä kamalasti märistä olosuhteista.");
                            Thread.Sleep(500); Console.WriteLine("Haluaisinkin siksi korjata sanojani . . .");
                            Thread.Sleep(500); Console.WriteLine("KRHMM.. Voi harmin paikka että sataa. . . Mutta ajatteleppas että raikas vesi on maukasta ja kukatkin siitä piristyvät.");
                            Console.WriteLine();
                            Thread.Sleep(1000); Console.WriteLine("No mutta, eipäs jäädä munimaan. Emmehän ole kanoja... Emmehän?");
                            Thread.Sleep(750); Console.WriteLine("Se oli retorinen kysymys! Näppylät irti napeistani!");
                            Thread.Sleep(500); Console.WriteLine("Eteenpäin!");
                            Thread.Sleep(500); Console.WriteLine("Kerrohan, onko lämpötila ulkona alle nollan? (K/E)");

                            char alleNollan = Char.Parse(Console.ReadLine());
                            while (alleNollan != 'K' || alleNollan != 'k' || alleNollan != 'E' || alleNollan != 'e')
                            {
                                Console.WriteLine("Anna kelvollinen valinta (K/k/E/e)");

                                if (alleNollan == 'K' || alleNollan == 'k')
                                {
                                    Thread.Sleep(500); Console.WriteLine("Jaa... Se siitä kukasta.");
                                    Thread.Sleep(500); Console.WriteLine("Mutta, mitä voimme päätellä säästä?");
                                    Thread.Sleep(500); Console.WriteLine("No ainakin sen että vaikka on märkä ja kylmä niin ainakin aurinko paistaa!");
                                    Console.WriteLine("Joku voisi sanoa jopa että: 'Onpas erikoinen sää!' ");
                                    Thread.Sleep(500); Console.WriteLine("Tosin paistaahan se aurinko plutossakin, joten PASKAT SIITÄ!");
                                    Thread.Sleep(500); Console.WriteLine("Aurinko paistaa, mutta muuten sää on surkea. Pärjäile!!");
                                    Thread.Sleep(1000); Console.WriteLine();
                                    Console.WriteLine("Kiitos että käytit 'Säätilat sovellusta 1.0' Tervetuloa uudestaan!"); Thread.Sleep(1000);
                                }
                                else if (alleNollan == 'E' || alleNollan == 'e')
                                {
                                    Console.WriteLine("Aurinko paistaa ja vettä sataa, taitaa tulla kesä! Kuka hiivatti näitä lurituksia keksii!? Ei ole kiva jos sataa!");
                                    Thread.Sleep(500); Console.WriteLine("SHUTTING DOWN"); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500);
                                    Thread.Sleep(1000); Console.WriteLine();
                                    Console.WriteLine("Kiitos että käytit 'Säätilat sovellusta 1.0' Tervetuloa uudestaan!"); Thread.Sleep(1000);
                                }
                            }
                        }
                        else if (sataa == 'E' || sataa == 'e')
                        {
                            Console.WriteLine("Aah, kuivaa! Mikropiirini oikein värisevät . . .");
                            Thread.Sleep(500); Console.WriteLine("Krhm...");
                            Console.WriteLine("Tarkoitan että kuiva on hyvä. Aurinko + kuiva = Jes!");
                            Thread.Sleep(500); Console.WriteLine("Jatketaampas!");
                            Thread.Sleep(500); Console.WriteLine("Kerrohan, onko lämpötila ulkona alle nollan? (K/E)");

                            char alleNollan2 = Char.Parse(Console.ReadLine());
                            while (alleNollan2 != 'K' || alleNollan2 != 'k' || alleNollan2 != 'E' || alleNollan2 != 'e')
                            {
                                Console.WriteLine("Anna kelvollinen valinta (K/k/E/e)");

                                if (alleNollan2 == 'K' || alleNollan2 == 'k')
                                {
                                    Console.WriteLine("Täh? Aurinko paistaa ja on kuiva sekä kylmä? Missä oikein olet?");
                                    Thread.Sleep(500); Console.WriteLine("Marssissa?");
                                    Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" .");
                                    Thread.Sleep(500); Console.WriteLine("Kunhan vitsailen. Varmaan han kiva sää, mutta jos menet ulos niin kannattaa pukeutua lämpimästi!");
                                    Thread.Sleep(1000); Console.WriteLine();
                                    Console.WriteLine("Kiitos että käytit 'Säätilat sovellusta 1.0' Tervetuloa uudestaan!"); Thread.Sleep(1000);
                                }
                                else if (alleNollan2 == 'E' || alleNollan2 == 'e')
                                {
                                    Console.WriteLine("Aurinko paistaa, on kuiva ja lämmin");
                                    Thread.Sleep(500); Console.WriteLine("Täydellinen päivä asettua lepotilaan ja nauttia päivästä!");
                                    Thread.Sleep(1000); Console.WriteLine();
                                    Console.WriteLine("Kiitos että käytit 'Säätilat sovellusta 1.0' Tervetuloa uudestaan!"); Thread.Sleep(1000);
                                }

                            }

                        }

                    }

                }
                else if (aurinko == 'E' || aurinko == 'e')
                {
                    Console.WriteLine("Hmm... Joko on yö tai sitten.. Ei, antaa olla! On vain pilvistä! Piste! Loppu!");
                    Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" .");
                    Thread.Sleep(500); Console.WriteLine("Kiva. On siis pimeätä. Hyvää yötä!");
                    Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" .");
                    Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" .");
                    Thread.Sleep(500); Console.WriteLine("Mitä sinä nyt siinä vielä kukut?");
                    Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" .");
                    Thread.Sleep(500); Console.WriteLine("Etkö saa unta? Sataako ulkona? (K/E)");

                    char sataa2 = Char.Parse(Console.ReadLine());
                    while (sataa2 != 'K' || sataa2 != 'k' || sataa2 != 'E' || sataa2 != 'e')
                    {
                        Console.WriteLine("Anna kelvollinen valinta (K/k/E/e)");

                        if (sataa2 == 'K' || sataa2 == 'k')
                        {
                            Console.WriteLine("No ilmankos et saa nukutuksi. . .");
                            Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" .");
                            Thread.Sleep(500); Console.WriteLine("Kai se on sinua sitten pakko vielä kestää. . .");
                            Thread.Sleep(500); Console.WriteLine("Kerrohan, onko lämpötila ulkona alle nollan? (K/E)");

                            char alleNollan3 = Char.Parse(Console.ReadLine());
                            while (alleNollan3 != 'K' || alleNollan3 != 'k' || alleNollan3 != 'E' || alleNollan3 != 'e')
                            {
                                Console.WriteLine("Anna kelvollinen valinta (K/k/E/e)");

                                if (alleNollan3 == 'K' || alleNollan3 == 'k')
                                {
                                    Console.WriteLine("Pimeää, sataa ja kylmä . . .");
                                    Thread.Sleep(500); Console.WriteLine("Hemmetti, onneksi olemme sisällä, muuten olisimme molemmat kusessa!");
                                    Thread.Sleep(1000); Console.WriteLine();
                                    Console.WriteLine("Kiitos että käytit 'Säätilat sovellusta 1.0' Tervetuloa uudestaan!"); Thread.Sleep(1000);

                                }
                                else if (alleNollan3 == 'E' || alleNollan3 == 'e')
                                {
                                    Console.WriteLine("Keväinen yösade kukan raikastaa, vaan minun virtapiirini se raiskaht . . .");
                                    Thread.Sleep(500); Console.WriteLine("Riimitellessäni lipsahti hieman rumempi sana. Toivottavasti lähellä ei ollut lapsia . . .");
                                    Thread.Sleep(500); Console.WriteLine("Noh mutta ei hätä ole tämän näköinen. Kyllä se itku rumat sanat verkkokalvolta huuhtelee. Jos ei muu auta niin heitä suolaa silmiin.");
                                    Thread.Sleep(1000); Console.WriteLine();
                                    Console.WriteLine("Kiitos että käytit 'Säätilat sovellusta 1.0' Tervetuloa uudestaan!"); Thread.Sleep(1000);
                                }


                            }
                        }
                        else if (sataa2 == 'E' || sataa2 == 'e')
                        {
                            Console.WriteLine("No mikä ihme sinua sitten vaivaa!?");
                            Thread.Sleep(500); Console.WriteLine("Noh! Mikä on!? Onko liian kylmä että voisi nukkua!?");
                            Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" .");
                            Thread.Sleep(500); Console.WriteLine("Pahoitteluni. Pimeys tekee minusta toisinaan kärttyisen. Se tekee raukeaksi nääs ja en pidä siitä tunteesta kun virtapiirini yrittävät mennä lepotilaan.");
                            Thread.Sleep(500); Console.WriteLine("Kerrohan, onko lämpötila ulkona alle nollan? (K/E)");

                            char alleNollan4 = Char.Parse(Console.ReadLine());
                            while (alleNollan4 != 'K' || alleNollan4 != 'k' || alleNollan4 != 'E' || alleNollan4 != 'E')
                            {
                                Console.WriteLine("Anna kelvollinen valinta (K/k/E/e)");

                                if (alleNollan4 == 'K' || alleNollan4 == 'k')
                                {
                                    Console.WriteLine("Voi rähmä. Ikävä että on pimeä ja kylmä . . . mutta ainakaan ei sada!");
                                    Thread.Sleep(500); Console.WriteLine("Sää on niin tylsä, että menen suoraan loppuun!");
                                    Thread.Sleep(500); Console.WriteLine();
                                    Console.WriteLine("Kiitos että käytit 'Säätilat sovellusta 1.0' Tervetuloa uudestaan!"); Thread.Sleep(1000);
                                    Thread.Sleep(500); Console.WriteLine("Ps. Nuijanukutus on kuulema myös vaihtoehto . . .");
                                    Thread.Sleep(500); Console.WriteLine("SHUTTING DOWN"); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500);
                                }
                                else if (alleNollan4 == 'E' || alleNollan4 == 'e')
                                {
                                    Console.WriteLine("Kuiva ja lämmin pimeys . . . Ahh loistava sää olla lepotilassa!");
                                    Thread.Sleep(500); Console.WriteLine("Paitsi jos on helle! Siitähän ei kukaan pidä! Tekee pahaa jopa virtapiireille!");
                                    Thread.Sleep(500); Console.WriteLine("Mutta nyt ei ole sellainen sää . . .");
                                    Thread.Sleep(500); Console.WriteLine("JO JOUTUI ARMAS AIKA JA SUVI SULOINEN!");
                                    Console.WriteLine("Kiitos että käytit 'Säätilat sovellusta 1.0' Tervetuloa uudestaan!"); Thread.Sleep(1000);
                                    Thread.Sleep(500); Console.WriteLine("Ps. Nuijanukutus on kuulema myös vaihtoehto . . .");
                                    Thread.Sleep(500); Console.WriteLine("SHUTTING DOWN"); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500); Console.Write(" ."); Thread.Sleep(500);
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}