using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UserInterface
    {
        int numLemons;
        int numCupSugar;
        int numIce;
        int numPitcher;
        int numGallons;
        int numCups;

        public void AcceptDetails()
        {


            Console.WriteLine("Enter how many Lemons: ");
            numLemons = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many cups of Sugar: ");
            numCupSugar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many Gallons Water: ");
            numGallons = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many Ice Cubes per Cup: ");
            numIce = Convert.ToInt32(Console.ReadLine());

        }

        public int GetnumCups()
        {
            return numGallons * 16;


        }

        public int GetnumIce()
        {

            return numIce * 1;

        }

        public void DisplayRecipe()
        {
            Console.WriteLine("You Chose the following: ");
            Console.WriteLine("Lemons: {0}", numLemons);
            Console.WriteLine("Cups Sugar: {0}", numCupSugar);
            Console.WriteLine("Gallons H\u2082O: {0}", numGallons);
            Console.WriteLine("\nWill make " + Convert.ToInt32(GetnumCups()) + " cups of Lemonade");
            Console.WriteLine("With " + Convert.ToInt32(numIce) + " Ice Cubes per Cup");

            Console.ReadKey();



        }
    }
}