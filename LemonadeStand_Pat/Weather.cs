using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_Pat
{
    class Weather
    {
        string condition;
        int temperature;
        List<string> weatherConditions;

        public Weather()
        {
            weatherConditions = new List<string>();
            return;
            condition = "sunny";
            temperature = 65;
        }

        public void AddWeatherCondition()
        {
            weatherConditions.Add("cloudy");
            weatherConditions.Add("rainy");
            weatherConditions.Add("sunny");
           

        }
    }
}
