using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Temperature
    {
        public Temperature() { }

        public void getTemperature()
        {
            for (int i = 0; i < 20; i++)
            {

            RandomGen T100 = new RandomGen();
            T100.Percent();

            Console.WriteLine(T100.oneHundred);
                Thread.Sleep(20);
            }

        }








    }
}
