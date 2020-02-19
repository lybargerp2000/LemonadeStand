using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_Pat
{
    public class Recipe
    {
        public int lemonQuantity;
        public int sugarCubeQuantity;
        public int iceCubeQuantity;
        public double PricePerCup;
        Inventory inventory;

      


        public Recipe()
        {

            PricePerCup = 1.5;
            lemonQuantity = 3;
            sugarCubeQuantity = 5;
            iceCubeQuantity = 10;
            Console.WriteLine(PricePerCup);

            return;
        }
        //public int UpdateQuantityOfItems(Inventory inventory)
        //{
        //    lemonQuantity = inventory.lemons;


        //}
     



    }
}
