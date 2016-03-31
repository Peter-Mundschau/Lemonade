using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Customer GetCustomers = new Customer();
            //GetCustomers.GenerateCustomers();


            //Temperature GetRandomTemperature = new Temperature();
            //GetRandomTemperature.getRandomTempRange();

            Day GetTheForecast = new Day();
            GetTheForecast.DailyForeCast();
            GetTheForecast.AdjustedTemperature();
            


        }
    }
}
