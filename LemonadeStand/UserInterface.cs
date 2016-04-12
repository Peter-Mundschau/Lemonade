using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UserInterface
    {
        //public Inventory getInventory;
        public Player player;
        public Store store;
        public int numLemons;
        public int numCupSugar;
        public int numIce;
        public int numGallons;
        public int numCups;
        public string userInput;

        public UserInterface()
        {
            //getInventory = new Inventory();
            player = new Player();
            store = new Store();
            
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
               
                player.SetPricePerCup();
            }
            else
            {
                MakeLemonade();
            }


        }

        public void BuyInventory()
        {
            bool buyInventory = true;
            Console.WriteLine("Here is your current Inventory;\n");
            Console.WriteLine("Paper Cups;\t"+player.playerInventory.paperCupsOnHand);
            Console.WriteLine("Lemons;\t\t"+player.playerInventory.freshLemonsOnHand);
            Console.WriteLine("Cups of Sugar;\t" +player.playerInventory.sugarCupsOnHand);
            Console.WriteLine("Ice Cubes;\t"+player.playerInventory.iceOnHand);
            Console.WriteLine();
            Console.WriteLine("What would you like to buy?(Enter 1 - 5)\n1.\t PaperCups:\n2.\tLemons:\n3.\tSugar:\n4.\tIce:\n5.\tExit Store:");
            while (buyInventory == true)
            {
                userInput = Console.ReadLine();
                string [] s =  { null, "1","2","3","4","5"};
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
                    else if (choice==3)
                    {
                        store.BuySugar();
                        
                    }
                    else if (choice==4)
                    {
                        store.BuyIceCubes();
                        
                    }
                    else if (choice ==5)
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

        public void AdjustInventoryDown()
        {
            player.playerInventory.paperCupsOnHand -= numCups;
            player.playerInventory.freshLemonsOnHand -= numLemons;
            player.playerInventory.sugarCupsOnHand -= numCupSugar;
            player.playerInventory.iceOnHand -= numIce;


        }
        public void WhatNext()
        {

        }

    }

}