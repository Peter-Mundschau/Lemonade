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

        public void Percent()
        {
            Random percent = new Random();

            oneHundred = percent.Next(101);

        }



    }
}
