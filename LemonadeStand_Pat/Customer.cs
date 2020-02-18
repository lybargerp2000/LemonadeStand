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

        Recipe PricePerCup;
        Weather weatherCondition;
     
       

        // double PricePerCup;
        // Cup cup;
        // public Weather weather;
        // string weatherCondition;
        // int temperature;
     
  

        public Customer()
        {
            customers = new List<string>() {"Sue", "Sam", "Fred", "Doug", "Greg", "Patrick"};
            SetValueToCustomers();


            //cup = new Cup();
            // weather = new Weather();

            return;
        }

  
        //public void CustomerAction()
        //{
          
        //}
        public bool CustomerDesireOutcomeOne(Weather weather, Recipe recipe)
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
        public bool CustomerDesireOutcomeTwo(Weather weather, Recipe recipe)
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

        public void SetValueToCustomers()
        {
            CustomerDesireOutcomeOne(weatherCondition, PricePerCup);

            
        }

        //public void CustomerAssighnmentOne()
        //{
         
        //}



    }    
}
