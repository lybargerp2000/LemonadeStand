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
   

      


        public Recipe()
        {

            PricePerCup = 1;
            lemonQuantity = 0;
            sugarCubeQuantity = 0;
            iceCubeQuantity = 0;
            
          

            
        }

        public void LemonsInPitcher()
        {
            lemonQuantity = UserInterface.MakeRecipe("lemons");
           

        }

        public void SugarcubesInPitcher()
        {
            sugarCubeQuantity = UserInterface.MakeRecipe("sugar cubes");


        }
        public void IceCubesInPitcher()
        {
            iceCubeQuantity = UserInterface.MakeRecipe("ice cubes");


        }

 
        //public int UpdateQuantityOfItems(Inventory inventory)
        //{
        //    lemonQuantity = inventory.lemons;


        //}




    }
}
