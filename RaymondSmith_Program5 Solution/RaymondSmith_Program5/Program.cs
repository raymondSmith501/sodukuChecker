using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaymondSmith_Program5
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\CPT244\sudoku-bad-1.txt";
            int[,] sdku = new int[9, 9];

            Reader.readSodukuFile(file, sdku);

            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    Console.Write(sdku[r, c] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
