// Author: Carly Jensen Michel

using System;

namespace Unit01
{
    class Program
    {
        static int[] grid = new int[9];
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tic Tac Toe Program!");
            for ( int i = 0; i < 9; i++)
            {
                grid[i] = 0;
            }

            int userInput = -1;
            int CompInput = -1;
            Random rand = new Random();

            while (chooseWinner() == 0)
            {
                // don't allow the human to choose an already occupied square
                while (userInput == -1 || grid[userInput] != 0)
                {
                    Console.WriteLine("Please enter a number from 0 to 8");
                    userInput = int.Parse( Console.ReadLine());
                    Console.WriteLine("You typed " + userInput);
                }

                grid[userInput] = 1;

                // don't allow the computer pick an invalid number
                while(CompInput == -1 || grid[CompInput] != 0)
                {
                    CompInput = rand.Next(8);
                    Console.WriteLine("Computer Chooses " + CompInput);
                }
                grid[CompInput] = 2;
                printGrid();
            }
            Console.WriteLine("Player " + chooseWinner() + " won the game");
           

        }

        private static int chooseWinner()
        {
            // return a 0 if nobody won, return the player number if they won
            if (grid[0] == grid[1] && grid [1] == grid[2])
            {
                return grid[0];
            }

            // second row
            if (grid[3] == grid[4] && grid [4] == grid[5])
            {
                return grid[3];
            }

            // third row
            if (grid[6] == grid[7] && grid [7] == grid[8])
            {
                return grid[6];
            }

            // first column
            if (grid[0] == grid[3] && grid [3] == grid[6])
            {
                return grid[0];
            }

            // second column
            if (grid[1] == grid[4] && grid [4] == grid[7])
            {
                return grid[1];
            }

            // third column
            if (grid[2] == grid[5] && grid [5] == grid[8])
            {
                return grid[2];
            }

            // first diagonal
            if (grid[0] == grid[4] && grid [4] == grid[8])
            {
                return grid[0];
            }

            // second diagonal
            if (grid[2] == grid[4] && grid [4] == grid[6])
            {
                return grid[2];
            }
            return 0;

        }
        
        private static void printGrid()
        {
          for (int i = 0; i < 9; i++)
            {
                // print the board
                //Console.WriteLine("Square " + i + " contains " + grid[i]);

                // print x or o for each square
                // 0 means unoccupied, 1 means player 1(x) 2 means player 2 (0)

                if (grid[i] == 0 )
                {
                    Console.Write(".");
                }
                if (grid[i] == 1 )
                {
                    Console.Write("x");
                }
                if (grid[i] == 2 )
                {
                    Console.Write("o");
                }

                //Print a new line of every 3rd character
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                }
            }  
        } 

    }
}
