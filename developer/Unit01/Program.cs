using System;

namespace Unit01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grid = new int[9];
            grid[0] = 0;
            grid[1] = 0;
            grid[2] = 0;
            grid[3] = 0;
            grid[4] = 0;
            grid[5] = 0;
            grid[6] = 0;
            grid[7] = 0;
            grid[8] = 1;

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Square " + i + " contains " + grid[i]);
            }
            



        }
    }
}
