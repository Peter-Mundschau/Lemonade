﻿using System;
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
        public string weatherValue;
        public int getTempRange;
        public int temperatureChange;

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
            

            if (true)
            {
                typeOfWeather = 1;
                Console.WriteLine(rain);
                weatherValue = "Rain";

            }
            else if (true)
            {
                typeOfWeather = 2;
                Console.WriteLine(cloudy);
                weatherValue = "Cloudy";
            }
            else if (true)
            {
                typeOfWeather = 3;
                Console.WriteLine(sunny);
                weatherValue = "Sunny";
            }
            else
            {
                typeOfWeather = 4;
                Console.WriteLine(sunnyHumid);
                weatherValue = "Sunny and Humid";
            }

            return;
        }


        public void getRandomTempRange()
        {

            {
                Random tempRange = new Random();
                getTempRange = tempRange.Next(55, 98);

                Thread.Sleep(20);

            }


        }

        public void HigherOrLower()
        {
            Random rand = new Random();
            temperatureChange = rand.Next(0, 2);
            if (temperatureChange == 1)
            {
                getTempRange += 5;
                temperature = getTempRange;
            }
            else
            {
                getTempRange -= 10;
                temperature = getTempRange;
            }
        }






    }
}
