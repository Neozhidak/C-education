using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program10
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 5] {
            {1,3,1,3,1},
            {3,1,3,1,3},
            };
            int result = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if ((i + x) % 2 == 0)
                    {
                        result = result + arr[i, x];
                    }
                }
            }
            Console.Write(result);
            Console.ReadLine();
        }
    }
}