﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_Pat
{
    public class Weather
    {
        public string weatherCondition;
        public int temperature;
        public List<string> weatherConditions;
        Random random = new Random();


        public Weather()
        {
            weatherConditions = new List<string>{"cloudy", "rainy", "sunny"};


            GenerateWeather();
            TemperatureGenerator();
          
        }


        public void GenerateWeather()
        {
            int val = random.Next(0, 3);
            weatherCondition = weatherConditions[val];
            Console.WriteLine(val + ". 0 is cloudy, 1 is rainy, 2 is sunny");
            
            
            

        }
        public void TemperatureGenerator()
        {
            temperature = random.Next(65, 95);
            Console.WriteLine(temperature + " is the temperature in Fahrenheit");
            
            
        }
        
    }
}
