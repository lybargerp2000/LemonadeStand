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
        public Game()
        {
            weather = new Weather();
            player = new Player();
            store = new Store();

           

        }


        public void RunGame()
        {
            store.RunStore(player);



        }
    }
}