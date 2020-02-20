using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_Pat
{
    //***The Solid principle of Open/Closed responsibility is applied here. Later on another developer could add an
    //   updated new class pitcher with more capabilities using the Recipe class in the same manner. Keeping the Recipe
    //   class separate assists with future additions.***
    public class Pitcher : Recipe
    {
        public int cupsInPitcher;
    
       
       

        public Pitcher()
        {
            cupsInPitcher = 5;
        }
        



       
    }
}
