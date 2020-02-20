using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_Pat
{
    public class Customer
    {
        public List<string> customers;
        public string customer;
        Random random = new Random();
      
        public Customer()
        {
            customers = new List<string>() { "Sue", "Sam", "Fred", "Doug", "Greg", "Patrick", "Kelvin" };
         
          
        }
        public void GenerateCustomer()
        {
            int val = random.Next(0, 7);
            customer = customers[val];
            Console.WriteLine(val);

        }






        //public void CustomerAction()
        //{

        //}





    }
}
