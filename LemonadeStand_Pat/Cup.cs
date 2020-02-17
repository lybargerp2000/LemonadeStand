using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_Pat
{
    class Cup : Item

    {
        int cups;
        // member variables (HAS A)

        // constructor (SPAWNER)
        public Cup()
        {
            name = "cup";
            CupGetBought();
        }

        // member methods (CAN DO)
        public int CupGetBought()
        {
            cups--;
            Console.WriteLine(cups);
            return cups;
        }
    }
}

