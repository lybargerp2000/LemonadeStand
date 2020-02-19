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
        Player player;
        Store store;
        Day day;
        int numberOfDays;
        public List<string> days;
        public Game()
        {
            player = new Player();
            days = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Friday" };

            store = new Store();



        }


        public void RunGame()
        {
            store.RunStore(player);




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