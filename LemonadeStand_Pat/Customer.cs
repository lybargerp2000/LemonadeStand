using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_Pat
{
    class Customer
    {
        public List<string> names;
        string name;
        double PricePerCup;
        

        public Customer()
        {
            names = new List<string>();
            return;
        }

        public void Names()
        {
            names.Add("Keith");
            names.Add("Kevin");
            names.Add("Sue");
        }



    }
}
