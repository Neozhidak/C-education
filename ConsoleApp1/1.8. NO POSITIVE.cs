using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program8
    {
        public static int ifpositive(int a)
        {
            if ((a % 2) == 0)
            {
                return 0;
            }
            return a;
        }


        static void Main(string[] args)
        {
            int[,,] arr = new int[3, 3, 3]
            {
            {{1,2,3},{4,5,6},{7,8,9}},
            {{10,11,12},{13,14,15},{16,17,18}},
            {{19,20,21},{22,23,24},{25,26,27}}
            };

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        arr[x, y, z] = ifpositive(arr[x, y, z]);
                        Console.Write(arr[x, y, z]);
                    }
                }
            }
            Console.ReadLine();

        }
    }
}