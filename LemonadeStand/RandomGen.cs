using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class RandomGen
    {
        public int oneHundred;
        public int RangeOfTemp;

        public void Percent()
        {
            Random percent = new Random();

            oneHundred = percent.Next(101);
            
        }


        
        public void RandomTemperature()
        {
            Random randomTemp = new Random();

            RangeOfTemp = randomTemp.Next(55, 96);

        }



    }
}
