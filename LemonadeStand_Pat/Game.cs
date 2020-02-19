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
        Puchase purchase;
        int numberOfDays;
        public List<string> days;
        public Game()
        {
            player1 = new Player();
            myStore = new Store();
            day = new Day();
            purchase = new Puchase();
            
            

        }
        


        public void RunGame()
        {
            //Console.WriteLine(player1.inventory.lemons.Count);
            myStore.RunStore(player1);
            player1.SetRecipe();
            purchase.CustomerDesireOutcomeOne(player1.recipe, day.weather);

            
        




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