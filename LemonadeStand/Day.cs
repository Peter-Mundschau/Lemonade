using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public Temperature getTemperature;
        public Weather getWeather;
        public int day = 0;

        public Day()
        {
            getWeather = new Weather();
            getTemperature = new Temperature();
        }
        
        public void EndOfDay()
        {
            day++;
        }

        
        public void DailyForeCast()
        {
            getWeather.GetTypeOfWeather();
            getTemperature.getRandomTempRange();

            Console.WriteLine("The ForeCast for today is ..."+ 
                getWeather +"and " + getTemperature +"degrees");

        }

        public void AdjustedTemperature()
        {
            getTemperature.HigherOrLower();
            Console.WriteLine("The ForeCast for today is still" +
               getWeather + "but it will be " + getTemperature + "degrees");

        }




    }
}
