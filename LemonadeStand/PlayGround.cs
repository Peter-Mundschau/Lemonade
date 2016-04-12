using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class PlayGround
    {



        public void BuyInventory()
        {
            bool buyInventory = true;
            Console.WriteLine("Here is your current Inventory;\n");
            Console.WriteLine("Paper Cups;\t" + player.playerInventory.paperCupsOnHand);
            Console.WriteLine("Lemons;\t\t" + player.playerInventory.freshLemonsOnHand);
            Console.WriteLine("Cups of Sugar;\t" + player.playerInventory.sugarCupsOnHand);
            Console.WriteLine("Ice Cubes;\t" + player.playerInventory.iceOnHand);
            Console.WriteLine();
            Console.WriteLine("What would you like to buy?(Enter 1 - 5)\n1.\t PaperCups:\n2.\tLemons:\n3.\tSugar:\n4.\tIce:\n5.\tExit Store:");
            while (buyInventory == true)
            {
                userInput = Console.ReadLine();
                string[] s = { null, "1", "2", "3", "4", "5" };
                foreach (var input in s)
                {
                    int choice;
                    bool inputResult = int.TryParse(input, out choice);
                    if (choice == 1)
                    {
                        store.BuyPaperCups();

                    }
                    else if (choice == 2)
                    {
                        store.BuyLemons();

                    }
                    else if (choice == 3)
                    {
                        store.BuySugar();

                    }
                    else if (choice == 4)
                    {
                        store.BuyIceCubes();

                    }
                    else if (choice == 5)
                    {
                        buyInventory = false;
                        WhatNext();


                    }
                    else
                    {

                        Console.WriteLine("Not a Valid Choice\n");
                        Console.WriteLine("What would you like to buy?(Enter 1 - 5)\n1.\t PaperCups:\n2.\tLemons:\n3.\tSugar:\n4.\tIce:\n5.\tExit Store:");

                    }
                }

                // userInput = Console.ReadLine(int.TryParse(userInput, out choice));


            }


        }

    }
}
