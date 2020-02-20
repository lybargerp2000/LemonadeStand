using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_Pat
{
    class Player
    {

        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();

        }

 
  
        public void SetRecipe()
        {
            recipe.LemonsInPitcher();
            recipe.IceCubesInPitcher();
            recipe.SugarcubesInPitcher();
           
        }

        //***Solid Single Responsibility Principle is applied below. This was the most basic method I wrote of a single method doing
        // one thing only and doing well. An item is purchased and the value is decremented.***
        public void CupGetBought(Purchase purchase)
        {
         if (purchase.cupIsPurchased == true)
            {
                pitcher.cupsInPitcher--;
            }

        }



    }
}