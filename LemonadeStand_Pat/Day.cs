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
        public Customer customers;
        public double PricePerCup;
        public string weatherCondition;
        List<string> days;



        public Day()
        {
            days = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Friday" };
            weather = new Weather();
            customers = new Customer();

        }

        






    }
}
