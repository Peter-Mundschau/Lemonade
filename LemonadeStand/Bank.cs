using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Bank
    {
        public double bankBalance;
        public double bankNet;
        public double lemonProfit;
        public double lemonLoss;




       public double getBankBalance()
        {
            return bankBalance;
        }

        public double getLemonProfit()
        {
            return bankBalance += lemonProfit;
        }

        public bool getLemonLoss(double lemonLoss)
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
