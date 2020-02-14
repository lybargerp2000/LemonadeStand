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

        public Weather()
        {
            weatherConditions = new List<string>();
            return;


        }

        public void WeatherCondition()
        {
            weatherConditions.Add("cloudy");
            weatherConditions.Add("rainy");
            weatherConditions.Add("sunny");
           
        }
        
    }
}
