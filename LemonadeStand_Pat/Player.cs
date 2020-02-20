using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_Pat
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        


        //Store store;


        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();

        }

        // member methods (CAN DO)
  
        public void SetRecipe()
        {
            recipe.LemonsInPitcher();
            recipe.IceCubesInPitcher();
            recipe.SugarcubesInPitcher();
           
        }
        public void CupGetBought(Purchase purchase)
        {
         if (purchase.cupIsPurchased == true)
            {
                pitcher.cupsInPitcher--;
            }

        }



    }
}