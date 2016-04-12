using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public double paper25CupsPrice = 0.50;
        public double freshLemonsPrice = 0.25;
        public double sugarCupsPrice = 0.50;
        public double icePrice = 0.03;

        public int paper25Cups = 25;
        public int freshLemons = 1;
        public int sugarCups = 1;
        public int ice = 10;
        public int userInput;

        public Store()
        {
            
        }

 

        public void BuyPaperCups()
        {
            Console.Write("Paper Cups 25 for $0.30\nHow many Packs of 25?>\n" );
            userInput = Convert.ToInt32(Console.ReadLine());

        }
        public void BuyLemons()
        {

        }

        public void BuySugar()
        {

        }

        public void BuyIceCubes()
        {

        }



    }
}
