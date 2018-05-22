using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program9
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 1, -2, 1, -4, -53, 1, 1, -8, 1, 0 };
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    result = result + arr[i];
                }
            }
            Console.Write(result);
            Console.ReadLine();

        }
    }
}