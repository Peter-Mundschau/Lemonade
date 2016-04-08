using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
       // public Temperature getTemperature;
        public Weather getWeather;
        public int day = 0;
        Customer getCustomers;

        public Day()
        {
            getWeather = new Weather();
          //  getTemperature = new Temperature();
            getCustomers = new Customer();

        }
        
        public void EndOfDay()
        {
            day++;
        }

        
        public void DailyForeCast()
        {
            getWeather.GetTypeOfWeather();
            getWeather.getRandomTempRange();

            Console.WriteLine("The ForeCast for today is ..."+ 
                getWeather.weatherValue +" and " + getWeather.getTempRange +"degrees");

        }

        public void AdjustedTemperature()
        {
            getWeather.HigherOrLower();
            Console.WriteLine("The ForeCast for today is still " +
               getWeather.weatherValue + " but it will be " + getWeather.temperature + "degrees");

        }




    }
}
