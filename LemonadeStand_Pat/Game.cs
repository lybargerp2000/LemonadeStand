using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_Pat
{
    public class Game
    {
        Weather weather;
        Player player1;
        Store myStore;
        Day day;
        int numberOfDays;
        public List<string> days;
        public Game()
        {
            player1 = new Player();
            days = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Friday" };
            myStore = new Store();
            

        }
        


        public void RunGame()
        {
            Console.WriteLine(player1.inventory.lemons.Count);
            myStore.RunStore(player1);
            
        




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