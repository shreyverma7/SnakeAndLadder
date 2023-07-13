using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SnakeAndLadder
{
    public class SnakeAndLadders
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        //UC1 
        int position = 0;

        //UC2
        Random random = new Random();
        public int DieRoll()
        {
            int diePosition = random.Next(1, 7); //random number between 1 to 6
            return diePosition;
        }


        //UC3
        public void Game()
        { 
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        break;

                    case LADDER:         
                         this.position += DieRoll();
                          break;
                    case SNAKE:
                         this.position -= DieRoll();
                    break;
                }
            

        }
        
    }
}
