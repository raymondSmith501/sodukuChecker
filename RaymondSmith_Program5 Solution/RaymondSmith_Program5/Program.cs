using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaymondSmith_Program5
{
    class Program
    {
        public const int  SODUKU_SIZE = 9;

        static void Main(string[] args)
        {
            
            string file = @"C:\CPT244\sudoku-bad-1.txt";
            int[,] sdku = new int[9, 9];
            

            Reader.readSodukuFile(file, sdku);

            
        }
    }
}
