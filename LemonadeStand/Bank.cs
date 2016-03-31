using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Bank
    {
        public decimal bankBalance;
        public decimal bankNet;
        public decimal lemonProfit;
        public decimal lemonLoss;




       public decimal getBankBalance()
        {
            return bankBalance;
        }

        public decimal getLemonProfit()
        {
            return bankBalance += lemonProfit;
        }

        public bool getLemonLoss(decimal lemonLoss)
        {
            if (bankBalance < lemonLoss)
            {
                Console.WriteLine("You are Bankrupt!"); 
                return false; 
            

            }

            else
            {
                bankBalance -= lemonLoss;
                return true;
            }

        }


        public void showBankBalance()
        {
            Console.WriteLine("Bank Balance: {0:C}",getBankBalance());

        }
       
        

    }
}
