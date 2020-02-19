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

            PricePerCup = 0;
            lemonQuantity = 0;
            sugarCubeQuantity = 0;
            iceCubeQuantity = 0;
          

            
        }
        //public int UpdateQuantityOfItems(Inventory inventory)
        //{
        //    lemonQuantity = inventory.lemons;


        //}
     



    }
}
