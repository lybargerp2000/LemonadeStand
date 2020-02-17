using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_Pat
{
    class Weather
    {
        public string weatherCondition;
        public int temperature;
        public List<string> weatherConditions;
        string weatherGenerated;
        Random weatherChoosen = new Random();


        public Weather()
        {
            weatherConditions = new List<string>();
            
     
            GenerateWeather();

            


        }

        public void WeatherCondition()
        {
            weatherConditions.Add("cloudy");
            weatherConditions.Add("rainy");
            weatherConditions.Add("sunny");
           
        }
        public void GenerateWeather()
        {
            int val = weatherChoosen.Next(0, 17);
            weatherCondition = weatherConditions[val];
            Console.WriteLine(val);
            Console.ReadLine();

        }
        public void TemperatureGenerator()
        {

        }
        
    }
}
