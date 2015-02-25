using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaymondSmith_Program5
{
    class Output
    {
        public static void outputSodku(int[,] sdku)
        {
            for (int row = 0; row < Program.SODUKU_SIZE; row++)
            {
                for(int col = 0; col < Program.SODUKU_SIZE; col++)
                {
                    Console.Write("{0,2}", sdku[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static void outputValidity(bool valid, ArrayList errors)
        {
            if(valid)
            {
                Console.WriteLine("\n\n" + "VALID\n");
            }
            else
            {
                Console.WriteLine("\n\n" + "INVALID\n");
                foreach(String s in errors)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
