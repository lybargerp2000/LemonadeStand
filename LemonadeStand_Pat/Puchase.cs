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
        public bool CustomerDesireOutcomeOne(Recipe recipe, Weather weather, Customer customer)
        {
            if (recipe.PricePerCup < 5.0 && weather.weatherCondition == "sunny" && weather.temperature > 85 && customer.customer == "sam")
            {
                return true;

            }
            else if (recipe.PricePerCup > 5.0 && weather.weatherCondition == "cloudy" && weather.temperature < 85 && customer.customer == "Kelvin")
            {
                return true;
            }
            else if (recipe.PricePerCup > 5.0 && weather.weatherCondition == "rainy" && weather.temperature < 85 && customer.customer == "Doug")
            {
                return true;
            }
            return false;

        }
        public bool CustomerDesireOutcomeTwo(Recipe recipe, Weather weather, Customer customer)
        {
            if (recipe.PricePerCup < 5.0 && weather.weatherCondition == "sunny" && weather.temperature > 85 && customer.customer == "Patrick")
            {
                return true;
            }
            else if (recipe.PricePerCup > 5.0 && weather.weatherCondition == "cloudy" && weather.temperature < 85 && customer.customer == "Greg")
            {
                return true;
            }
            else if (recipe.PricePerCup > 5.0 && weather.weatherCondition == "rainy" && weather.temperature < 85 && customer.customer == "Fred")
            {
                return true;
            }
            return false;

        }







    }
}
