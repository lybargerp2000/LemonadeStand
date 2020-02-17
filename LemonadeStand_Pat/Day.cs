using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_Pat
{
    class Day
    {
        public Weather weather;
        public List<Customer> customers;
        public double PricePerCup;
        public string weatherCondition;
        int temperature;
        Cup cup;


        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
            cup = new Cup();
            return;
        }

        public void CustomerDesireOutcome()
        {
            if (PricePerCup < 1.0 && weatherCondition == "sunny" && temperature > 85)
            {
                cup.CupGetBought();
            }
            else if (PricePerCup > 1.0 && weatherCondition == "cloudy" && temperature < 85)
            {
             
            }
            else if (PricePerCup > 1.0 && weatherCondition == "rainy" && temperature < 85)
            {

            }
            Console.WriteLine(cup);
        }







    }
}
