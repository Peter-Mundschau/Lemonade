using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player 
    {
        public string playerName;

        Inventory playerInventory;
        Bank bank;
        public Player()
        {
            bank = new Bank();
            playerInventory = new Inventory();
        }



       public void getBankBalance()
        {
            bank.showBankBalance();
                
        }
        
         


        public void PlayerName()
        {
            Console.WriteLine("Please Enter your Name: ");
            playerName = Console.ReadLine();

        }

    }
}
