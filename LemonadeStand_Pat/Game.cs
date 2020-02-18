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
        public Game()
        {
            player = new Player();
            day = new Day();
          
            store = new Store();

           

        }


        public void RunGame()
        {
            store.RunStore(player);



        }
    }
}