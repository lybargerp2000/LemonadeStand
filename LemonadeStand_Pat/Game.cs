using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_Pat
{
    public class Game
    {
        
        Player player1;
        Store myStore;
        Day day;
        int numberOfDays;
        public List<string> days;
        public Game()
        {
            player1 = new Player();
           
            myStore = new Store();
            day = new Day();
            

        }
        


        public void RunGame()
        {
            //Console.WriteLine(player1.inventory.lemons.Count);
            myStore.RunStore(player1);
            player1.SetRecipe();

            
        




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