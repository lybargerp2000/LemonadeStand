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
        double PricePerCup;
        Cup cup;
        int we;
        

        public Customer()
        {
            customers = new List<string>();
            cup = new Cup();
            return;
        }

        public void Customers()
        {
            customers.Add("Keith");
            customers.Add("Kevin");
            customers.Add("Sue");
        }



        public void CustomerAction()
        {
           cup.CupGetBought();
        }

        

    }    
}
