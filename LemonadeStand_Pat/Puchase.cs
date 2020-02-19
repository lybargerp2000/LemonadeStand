using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_Pat
{
    class Puchase
    {
        public Puchase()
        {
         
        }
        public bool CustomerDesireOutcomeOne(Recipe recipe, Weather weather)
        {
            if (recipe.PricePerCup < 1.0 && weather.weatherCondition == "sunny" && weather.temperature > 85)
            {
                return true;

            }
            else if (recipe.PricePerCup > 1.0 && weather.weatherCondition == "cloudy" && weather.temperature < 85)
            {
                return false;
            }
            else if (recipe.PricePerCup > 1.0 && weather.weatherCondition == "rainy" && weather.temperature < 85)
            {
                return false;
            }
            return false;

        }
        public bool CustomerDesireOutcomeTwo(Recipe recipe, Weather weather)
        {
            if (recipe.PricePerCup < 1.5 && weather.weatherCondition == "sunny" && weather.temperature > 85)
            {
                return true;
            }
            else if (recipe.PricePerCup > 1.0 && weather.weatherCondition == "cloudy" && weather.temperature < 85)
            {
                return true;
            }
            else if (recipe.PricePerCup > 1.0 && weather.weatherCondition == "rainy" && weather.temperature < 85)
            {
                return false;
            }
            return false;

        }







    }
}
