// See https://aka.ms/new-console-template for more information


/* Alla..Hakee yhden randomin listasta  (Toimii)*/

string[] rewardItemList = { "[[Bismuth]]", " [[Aluminium]]", "[[Chrome]]", "[[Copper]]", "[[Quicksilver]]", "[[Iron]]", "[[Silver]]", "[[Gold]]", "[[Iridium]]", "[[Osmium]]" };
var randomItem1 = new Random(); // luo muuttujan jonka perusteella voidaan valita satunnainen luku (ei monesko)


int indexForP1 = randomItem1.Next(rewardItemList.Length); // (monesko) Luo satunnainen järjestysluku. Pienempi kuin arrayn pituus.
int indexForP2 = randomItem1.Next(rewardItemList.Length);
int indexForP3 = randomItem1.Next(rewardItemList.Length);
int indexForP4 = randomItem1.Next(rewardItemList.Length);
/*----------------------------------------*/

Console.WriteLine("Select size of the team ( 1 - 4 )");
    int userTeamSizeSelection = int.Parse(Console.ReadLine());

while (userTeamSizeSelection < 0 || userTeamSizeSelection > 4)
{
    Console.WriteLine("Invalid selection. Select number 1, 2, 3, or 4 ");

    userTeamSizeSelection = int.Parse(Console.ReadLine()); 
}
if (userTeamSizeSelection == 1)
{
    Console.WriteLine();
    Console.WriteLine(rewardItemList[indexForP1]);
    Console.WriteLine();
}
else if (userTeamSizeSelection == 2)
{
    Console.WriteLine();
    Console.WriteLine("Player1 gets " + rewardItemList[indexForP1] + " as a reward!");
    Console.WriteLine() ;
    Console.WriteLine("Player2 gets " + rewardItemList[indexForP2] + " as a reward!");
    Console.WriteLine();
}
else if (userTeamSizeSelection == 3)
{
    Console.WriteLine();
    Console.WriteLine("Player1 gets " + rewardItemList[indexForP1] + " as a reward!");
    Console.WriteLine();
    Console.WriteLine("Player2 gets " + rewardItemList[indexForP2] + " as a reward!");
    Console.WriteLine();
    Console.WriteLine("Player3 gets " + rewardItemList[indexForP3] + " as a reward!");
    Console.WriteLine();
}
else if (userTeamSizeSelection == 4)
{
    Console.WriteLine();
    Console.WriteLine("Player1 gets " + rewardItemList[indexForP1] + " as a reward!");
    Console.WriteLine();
    Console.WriteLine("Player2 gets " + rewardItemList[indexForP2] + " as a reward!");
    Console.WriteLine();
    Console.WriteLine("Player3 gets " + rewardItemList[indexForP3] + " as a reward!");
    Console.WriteLine();
    Console.WriteLine("Player4 gets " + rewardItemList[indexForP4] + " as a reward!");
    Console.WriteLine();
}



/*
 * Tiimin koko: Käyttäjän valinta 1-4. tallenna variableen
 * jos valittu muuta kuin 1-4 valittaa virheestä ja palaa alkuun
 
 *tulostaa jokaisella kierroksella random itemin arraysta (random * 1-4)



 random rng (kertoimella) 1-4 .. miten?
 */



/*
 Tämä on vain perus tapa luoda random
    kommenttina, koska ei käytetä

Random rng = new Random();
int x = 0;
*/

// -----------------MALLI---------------------
/*
{ 
  Console.WriteLine("Hei. Kerro oletko (U) -uros vai (N) -naaras");
  char un = Char.Parse(Console.ReadLine());
  Console.WriteLine();

  if (un == 'n' || un == 'N' || un == 'u' || un == 'U') //Tähän jos laittaisi "if" tilalle "while", jatkaisi kyselyä loputtomasti. Oli kätevä testatessa.
  {
      Console.Write("Kiitos että määritit sukupuolesi ohjeistuksen mukaan!");
      Console.WriteLine("Anna seuraavaksi ikäsi vuosina ... ");
      int ika = int.Parse(Console.ReadLine());

      if (ika >= 125)
      {
          Console.Write("Älä valehtele. Et voi olla noin vanha!");
          Console.WriteLine("Anna kelvollinen ikä ... ");
          ika = int.Parse(Console.ReadLine());
      }
      else if (ika < 125)
      {
          Console.WriteLine();
          Console.WriteLine("Olet siis väittämäsi mukaan " + ika + " vuotias.");
      }

      if ((un == 'u') || (un == 'U'))
      {
          if ((ika >= 1) && (ika <= 14))
          {
              Console.WriteLine();
              Console.WriteLine("Valitsit uros ja ikäsi on " + ika + ". Olet siis poika");
          }
          else if ((ika >= 15) && (ika <= 25))
          {
              Console.WriteLine();
              Console.WriteLine("Valitsit uros ja ikäsi on " + ika + ". Olet siis nuori mies");
          }
          else if ((ika >= 16) && (ika <= 57))
          {
              Console.WriteLine();
              Console.WriteLine("Valitsit uros ja Ikäsi on " + ika + ". Olet siis mies parhaassa iässä! ");
          }
          else if ((ika >= 58) && (ika <= 124))
          {
              Console.WriteLine();
              Console.WriteLine("Valitsit uros ja ikäsi on " + ika + ". Olet siis pappa, eli mies korkeassa iässä! ");
          }
          else
          { }
      }

      if ((un == 'n') || (un == 'N'))
      {
          if ((ika >= 1) && (ika <= 14))
          {
              Console.WriteLine();
              Console.WriteLine("Valitsit naaras ja käsi on " + ika + ". Olet siis tyttö");
          }
          else if ((ika >= 15) && (ika <= 25))
          {
              Console.WriteLine();
              Console.WriteLine("Valitsit naaras ja ikäsi on " + ika + ". Olet siis nuori nainen");
          }
          else if ((ika >= 16) && (ika <= 57))
          {
              Console.WriteLine();
              Console.WriteLine("Valitsit naaras ja ikäsi on " + ika + ". Olet siis nainen parhaassa iässä! ");
          }
          else if ((ika >= 58) && (ika <= 124))
          {
              Console.WriteLine();
              Console.WriteLine("Valitsit naaras ja ikäsi on " + ika + ". Olet siis mummu, eli nainen korkeassa iässä! ");
          }
          else
          { }
      }
  }
} 
*/
