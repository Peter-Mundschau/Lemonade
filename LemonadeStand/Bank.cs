using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Bank
    {
        
        public decimal bankNet;
        public decimal lemonProfit;
        public decimal lemonLoss;
        public decimal bankBalance = 20.00M;



        public decimal BankBalance()
        {
            return bankBalance;
        }

        public decimal LemonProfit()
        {
            return bankBalance += lemonProfit;
        }

        public bool LemonLoss(decimal lemonLoss)
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
            Console.WriteLine("Bank Balance: {0:C}",BankBalance());

        }
       
        

    }
}
