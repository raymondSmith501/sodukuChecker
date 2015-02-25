using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaymondSmith_Program5
{
    class Checker
    {
        public static bool checkColumns(int[,] sdku, ArrayList errors)
        {
            bool valid = true;

            for (int col = 0; col < Program.SODUKU_SIZE; col++)
            {
                ArrayList input = new ArrayList();
                
                for (int row = 0; row < Program.SODUKU_SIZE; row++)
                {
                    if(input.Contains(sdku[row, col]))
                    {
                        valid = false;
                        string err = "Col: " + col;             
                        errors.Add(err);
                    }
                }

            }

            return valid;
        }

        public static bool checkRows(int[,] sdku, ArrayList errors)
        {
             bool valid = true;

             for (int row = 0; row < Program.SODUKU_SIZE; row++)
             {
                 ArrayList input = new ArrayList();

                 for (int col = 0; col < Program.SODUKU_SIZE; row++)
                 {
                     if (input.Contains(sdku[row, col]))
                     {
                         valid = false;
                         string err = "Row: " + col;
                         errors.Add(err);
                     }
                 }
             }

             return valid;
        }

        public static bool checkBlocks(int[,] sdku, ArrayList errors)
        {
            bool valid = true;


            return valid;
        }
    }
}
