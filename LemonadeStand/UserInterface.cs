using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UserInterface
    {
        public Inventory getInventory;
        public int numLemons;
        public int numCupSugar;
        public int numIce;
        public int numGallons;
        public int numCups;
        public string userInput;

        public UserInterface()
        {
            getInventory = new Inventory();
        }

        public void MakeLemonade()
        {

            Console.WriteLine("Make your Lemonade; \n(One Gallon will make 16cups of Lemonade");
            Console.WriteLine("Enter how many Lemons: ");
            numLemons = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many cups of Sugar: ");
            numCupSugar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many Gallons Water: ");
            numGallons = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many Ice Cubes per Cup: ");
            numIce = Convert.ToInt32(Console.ReadLine());

        }

        public int GetNumCups()
        {
            return numCups = numGallons * 16;


        }

        public int GetNumIce()
        {

            return numIce * 1;

        }

        public int GetNumLemons()
        {
            return numLemons;
        }

        public int GetNumCupsSugar()
        {
            return numCupSugar;
        }



        public void DisplayRecipe()
        {

            Console.WriteLine("You Chose the following: ");
            Console.WriteLine("Lemons: {0}", numLemons);
            Console.WriteLine("Cups Sugar: {0}", numCupSugar);
            Console.WriteLine("Gallons H\u2082O: {0}", numGallons);
            Console.WriteLine("\nWill make " + Convert.ToInt32(GetNumCups()) + " cups of Lemonade");
            Console.WriteLine("With " + Convert.ToInt32(numIce) + " Ice Cubes per Cup");

            Console.WriteLine("\nAre you satisfied with your Recipe? (Y or N)press Enter");
            userInput = Convert.ToString(Console.ReadLine());

            if (userInput.ToUpper()=="Y")
            {
               AdjustInventoryDown();
               // SetPricePerCup();
            }
            else
            {
                MakeLemonade();
            }


        }

        public void BuyInventory()
        {
            Console.WriteLine("Here is your current Inventory;\n");
            Console.WriteLine("Paper Cups;\t"+getInventory.paperCupsOnHand);
            Console.WriteLine("Lemons;\t\t"+getInventory.freshLemonsOnHand);
            Console.WriteLine("Cups of Sugar;\t" +getInventory.sugarCupsOnHand);
            Console.WriteLine("Ice Cubes;\t"+getInventory.iceOnHand);
            Console.WriteLine();

            
        }

        public void AdjustInventoryDown()
        {
            getInventory.paperCupsOnHand -= numCups;
            getInventory.freshLemonsOnHand -= numLemons;
            getInventory.sugarCupsOnHand -= numCupSugar;
            getInventory.iceOnHand -= numIce;


        }
    }

}