using System;

namespace SnakeAndLadder
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder !");
            int number1 =0,number2 = 0,count1,count2;
            SnakeAndLadders player1 = new SnakeAndLadders();
            SnakeAndLadders player2 = new SnakeAndLadders();
            // snakeAndLadders.Game();  single player
            //UC7
            while (number1 !=100 && number2 !=100)
            {
                Console.Write(" Player 1 :");
                number1 = player1.Game();
                Console.Write(" Player 2 :");
                number2 = player2.Game();

            }
            //getiing count value
            count1 = player1.COUNT();
            count2 = player2.COUNT();


            if (number1 == 100 )
            {
                Console.WriteLine("Player1 wins");
                Console.WriteLine("number of die throws " + count1);
            }
            else
            {
                Console.WriteLine("Player2 wins");
                Console.WriteLine("number of die throws " + count2);
            }


        }
    }

        
}