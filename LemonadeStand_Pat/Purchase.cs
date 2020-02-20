using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_Pat
{
    public class Purchase
    {
        public bool cupIsPurchased;
        public Purchase()
        {
            cupIsPurchased = false;
        }
        public bool CustomerDesireOutcomeOne(Recipe recipe, Weather weather, Customer customer)
        {
            if (recipe.PricePerCup < 5.0 && weather.weatherCondition == "sunny" && weather.temperature > 85 && customer.customer == "sam")
            {
                return cupIsPurchased = true;

            }
            else if (recipe.PricePerCup > 5.0 && weather.weatherCondition == "cloudy" && weather.temperature < 85 && customer.customer == "Kelvin")
            {
                return cupIsPurchased = true;
            }
            else if (recipe.PricePerCup > 5.0 && weather.weatherCondition == "rainy" && weather.temperature < 85 && customer.customer == "Doug")
            {
                return cupIsPurchased = true;
            }
            return cupIsPurchased = false;

        }
        public bool CustomerDesireOutcomeTwo(Recipe recipe, Weather weather, Customer customer)
        {
            if (recipe.PricePerCup < 5.0 && weather.weatherCondition == "sunny" && weather.temperature > 85 && customer.customer == "Patrick")
            {
                return cupIsPurchased = true;
            }
            else if (recipe.PricePerCup > 5.0 && weather.weatherCondition == "cloudy" && weather.temperature < 85 && customer.customer == "Greg")
            {
                return cupIsPurchased = true;
            }
            else if (recipe.PricePerCup > 5.0 && weather.weatherCondition == "rainy" && weather.temperature < 85 && customer.customer == "Fred")
            {
                return cupIsPurchased = true;
            }
            return cupIsPurchased = false;

        }







    }
}
