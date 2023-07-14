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
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100, STARTING_POSITION = 0;
        //UC1
        int position = 0, count = 0;

        //uc2 
        Random random = new Random();

        //die Function
            public int DieRoll()
            {
                int diePosition = random.Next(1, 7);
                return diePosition;
            }
        //uc3
            public int Game()
            {
                    int option = random.Next(1, 3);
                    switch (option)
                    {
                        case NO_PLAY:
                        Console.WriteLine(" Position" +" "+ this.position );
                        count++;
                        break;

                        case LADDER:
                            int dieRoll = DieRoll();
                            if (this.position + dieRoll <= WINNING_POSITION)
                            {
                                this.position += dieRoll;
                            }
                             Console.WriteLine(" Position" + " " + this.position);
                            count++;
                        break;

                        case SNAKE:
                            dieRoll = DieRoll();
                            if (this.position - dieRoll < STARTING_POSITION)
                            {
                                this.position -= 0;
                            }
                            else
                            {
                                this.position -= dieRoll;
                            }
                        Console.WriteLine(" Position" + " " + this.position);
                        count++;
                        break;
                    }
       
                     return this.position;
             }

        //for count number of time played
            public int COUNT()
            {
                return count;

            }


    }
}

