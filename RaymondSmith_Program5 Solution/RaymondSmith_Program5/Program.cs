using System;
using System.Collections;
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
            
            string file = @"C:\CPT244\sudoku-bad-3.txt";
            int[,] sdku = new int[9, 9];
            ArrayList errors = new ArrayList(10);

            //Read Soduku answer file into 2-Dimensional Array
            Reader.readSodukuFile(file, sdku);

            //Check for accuracy in columms, rows, and blocks           
            bool rows = Checker.checkRows(sdku, errors);
            bool columns = Checker.checkColumns(sdku, errors);
            bool blocks = Checker.checkBlocks(sdku, errors);
            bool valid = (columns && rows && blocks);

            //Display findings
            Output.outputSodku(sdku);
            Output.outputValidity(valid, errors);

            
        }
    }
}
