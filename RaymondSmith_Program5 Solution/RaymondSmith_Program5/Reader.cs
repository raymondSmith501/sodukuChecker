using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaymondSmith_Program5
{
    class Reader
    {
        public static void readSodukuFile(string file, int[,] array)
        {
            StreamReader reader = new StreamReader(new FileStream(file, FileMode.Open, FileAccess.Read));
            {

                char[] delim = { ',' };

                for (int row = 0; row < 9; row++)          
                {          
                        string line = reader.ReadLine();
                        string[] fields = line.Split(delim);

                        for (int i = 0; i < fields.Length; i++)
                        {
                            array[row, i] = int.Parse(fields[i]);
                        }                    
                }
            }


        }
    }
}
