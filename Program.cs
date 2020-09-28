using System;

namespace SnakesAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Snakes and Ladders");
            //// Starting position of player

            int position = 0;
            Console.WriteLine("Start Position of Player 1 = 0");

            Random random = new Random();
            ////Generating value on a dice
            int dice = random.Next(1, 7); //// Dice will choose a number between 1 to 6

            
            Console.WriteLine("The number on dice =" + dice);
        }
    }
}
