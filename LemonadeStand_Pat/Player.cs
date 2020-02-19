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
        public string player;


        //Store store;


        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            pitcher = new Pitcher();
            recipe = new Recipe();

        }

        // member methods (CAN DO)
        public void GoToStore()
        {
          
        }
        public void SetRecipe()
        {
         
        }



    }
}