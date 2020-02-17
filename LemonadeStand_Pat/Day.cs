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
        int numberOfDays;
       


        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
           
            return;
        }

        public void NumberOfDays()
        {
            numberOfDays = 7;
        }

        public void DecreaseDays()
        {
            numberOfDays--;
        }

        public void RunDay()
        {

            NumberOfDays();

         while (numberOfDays <= 7)
            {
                DecreaseDays();
                RunDay();
            }




        }

        






    }
}
