using SnakeAndLadder;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Snake and Ladder !");
       SnakeAndLadders snakeandladder = new  SnakeAndLadders(); //object
        Console.WriteLine(snakeandladder.DieRoll());
        snakeandladder.Game();





    }
}