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
        public Purchase purchase;
        public List<string> days;
        int numberOfDays;
        public Game()
        {
            player1 = new Player();
            myStore = new Store();
            day = new Day();
            purchase = new Purchase();
            numberOfDays = 7;
           
        }
        
        public void RunGame()
        {

            myStore.RunStore(player1);
            player1.SetRecipe();
            purchase.CustomerDesireOutcomeOne(player1.recipe, day.weather, day.customers);
            purchase.CustomerDesireOutcomeTwo(player1.recipe, day.weather, day.customers);
            player1.CupGetBought(purchase);
            RunDay();
        }

     

        public void DecreaseDays()
        {
            numberOfDays--;
        }

        public void RunDay()
        {
            day.weather.GenerateWeather();
            day.weather.TemperatureGenerator();




            while (numberOfDays >= 0)
            {

                DecreaseDays();
                RunGame();
                

            }
        }

    }
}