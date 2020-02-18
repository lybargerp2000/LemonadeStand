using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_Pat
{
    class Customer
    {
        public List<string> customers;
        string name;
        // double PricePerCup;
        // Cup cup;
        // public Weather weather;
        // string weatherCondition;
        // int temperature;
     
  

        public Customer()
        {
            customers = new List<string>() {"" +20};

            cup = new Cup();
            // weather = new Weather();

            return;
        }

  
        public void CustomerAction()
        {
          
        }
        public bool CustomerDesireOutcomeOne(Weather weather, double price)
        {
            if (price < 1.0 && weather.weatherCondition == "sunny" && weather.temperature > 85)
            {
                return true;
            }
            else if (price > 1.0 && weather.weatherCondition == "cloudy" && weather.temperature < 85)
            {

            }
            else if (price > 1.0 && weather.weatherCondition == "rainy" && weather.temperature < 85)
            {

            }
            Console.WriteLine();
        }
        public void CustomerDesireOutcomeTwo()
        {
            if (PricePerCup < 1.5 && weatherCondition == "sunny" && temperature > 85)
            {
                cup.CupGetBought();
            }
            else if (PricePerCup > 1.0 && weatherCondition == "cloudy" && temperature < 85)
            {
                cup.CupGetBought();
            }
            else if (PricePerCup > 1.0 && weatherCondition == "rainy" && temperature < 85)
            {

            }
            Console.WriteLine(cup);
        }

        public void CustomerAssighnmentOne()
        {
         
        }



    }    
}
