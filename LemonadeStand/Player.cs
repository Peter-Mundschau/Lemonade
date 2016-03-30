using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public Player()
        {

        }
        public string playerName;
        public double bankBalance = 20.00;
        


        public void PlayerName()
        {
            Console.WriteLine("Please Enter your Name: ");
            playerName = Console.ReadLine();

        }

    }
}
