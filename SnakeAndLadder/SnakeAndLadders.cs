using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadders
    {
        //UC1 
        int position = 0;

        //UC2
        Random random = new Random();
        public int DieRoll()
        {
            int diePosition = random.Next(1, 7); //random number between 1 to 6
            return diePosition;
        }
    }
}
