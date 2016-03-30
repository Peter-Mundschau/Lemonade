using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {

        public int temperature;
        public int Rain1 = 1;
        public string rain = "Rain";
        public int cloudy2 = 2;
        public string cloudy = "Cloudy";
        public int sunny3 = 3;
        public string sunny = "Sunny";
        public int sunnyHumid4 = 4;
        public string sunnyHumid = "Sunny and Humid";
        public int typeOfWeather;
        public int weatherValue;

        public Weather()
        {
            
        }

        public void GetTypeOfWeather()
        {
            

            { 
            Random TypeOfWeather = new Random();
            typeOfWeather = TypeOfWeather.Next(1, 4);
            }
            Thread.Sleep(20);
            return;

            if (true)
            {
                typeOfWeather = 1;
                Console.WriteLine(rain);
                weatherValue = 1;

            }
            else if (true)
            {
                typeOfWeather = 2;
                Console.WriteLine(cloudy);
                weatherValue = 2;
            }
            else if (true)
            {
                typeOfWeather = 3;
                Console.WriteLine(sunny);
                weatherValue = 3;
            }
            else
            {
                typeOfWeather = 4;
                Console.WriteLine(sunnyHumid);
                weatherValue = 4;
            }


        }





















    }
}
