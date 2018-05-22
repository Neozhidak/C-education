using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program7
    {


        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int[] sortArr = new int[10];
            Random rnd = new Random();
            Console.Write("Массив: \n");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 101);
                Console.Write(arr[i] + "\n");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int x = 0; x < arr.Length - i - 1; x++)
                {
                    if (arr[x] > arr[x + 1])
                    {
                        int result = arr[x];
                        arr[x] = arr[x + 1];
                        arr[x + 1] = result;
                    }
                }
            }
            Console.Write("\nМинимум: " + arr[0] + "\n");
            Console.Write("Максимум: " + arr[9] + "\n");
            Console.ReadLine();
        }
    }
}