﻿using System;

namespace SnakesAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Snakes and Ladders");
            //// Starting position of player

            int counter = 0;
            int position = 0;
            Console.WriteLine("Start Position of Player 1 = 0");



            int position = 0;
            Console.WriteLine("Start Position of Player 1 = 0");









            Random random = new Random();
            ////Generating value on a dice
            int dice = random.Next(1, 7); //// Dice will choose a number between 1 to 6


            Console.WriteLine("The number on dice =" + dice);

            ////User chooses a value to move ahead in the game
            /// For no play, user remains in the same position
            /// For Ladder, user moves ahead
            /// For Snake, user moves behind
            
            Console.WriteLine("Enter a number - 1. No play, 2.Ladder, 3.Snake");
            int option = Console.Read();
            switch (option)
            {
                case 1:
                    position = dice;
                    break;
                case 2:
                    position = position + dice;
                    break;
                case 3:
                    position = position - dice;
                    break;
                default: break;


                    //// If player reaches below 0:

    //// If player reaches below 0:

                    
                    if (position < 0)
                        position = 0;
                    Console.WriteLine("The position of player =" + position);



                    //// Game is completed when position reaches 100
                    if (position == 100)
                    {
                        Console.WriteLine("Game completed");
                        break;
                    }

                    counter++;
            }
            ////Printing number of moves

            Console.WriteLine("Number of moves by player1 =" + counter);

        }
    }
    }

            }

            }

            }

            
            Console.WriteLine("The number on dice =" + dice);




        }
    }
}
master
