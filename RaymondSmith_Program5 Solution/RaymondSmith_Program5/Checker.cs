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
                    if (input.Count != 0)
                    {
                        if (input.Contains(sdku[row, col]))
                        {
                            valid = false;
                            string err = "Col: " + col + "  Multiple: " + sdku[row,col] + "'s";
                            errors.Add(err);
                        }
                    }

                    input.Add(sdku[row, col]);
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

                 for (int col = 0; col < Program.SODUKU_SIZE; col++)
                 {
                     if (input.Count != 0)
                     {
                         if (input.Contains(sdku[row, col]))
                         {
                             valid = false;
                             string err = "Row: " + row + "  Multiple: " + sdku[row, col] + "'s";
                             errors.Add(err);
                         }
                     }

                     input.Add(sdku[row, col]);
                 }
             }

             return valid;
        }

        public static bool checkBlocks(int[,] sdku, ArrayList errors)
        {
            bool valid = true;
            int blk = 0;

            //Loop through each set of 3 rows
            for (int row = 0; row <= 6; row += 3)
            {
                //While in each set of 3 rows loop through each set of 3 columns
                for (int col = 0; col <= 6; col += 3)
                {
                    ArrayList input = new ArrayList(9);

                    for (int r = row; r < (row + 3); r++)
                    {
                        for (int c = col; c < (col + 3); c++)
                        {
                            if (input.Count != 0)
                            {
                                if (input.Contains(sdku[r, c]))
                                {
                                    valid = false;
                                    string err = "Block: " + blk + "  Multiple: " + sdku[r, c] + "'s";
                                    errors.Add(err);
                                }
                            }

                            input.Add(sdku[r, c]);
                        }
                    }
                    
                    //Track what block the loop is in
                    blk++;
                }
            }

            return valid;
        }
    }
}
