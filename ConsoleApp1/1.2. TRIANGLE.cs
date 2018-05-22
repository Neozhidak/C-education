using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program2
    {
        public static void CheckInput(out string input, out int num)
        {
            Console.Write("Ввведите число строк\n");
            input = Console.ReadLine();
            while (!Int32.TryParse(input, out num) | num <= 0)
            {
                Console.WriteLine("Вводимое значение должно быть не отрицательным целым числом");
                Console.Write("Введите число строк\n");
                input = Console.ReadLine();
            }
        }

        public static void WriteStars(out string input, int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (var x = i + 1; x > 0; x--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            input = Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int num = 0;
            string input = "";
            CheckInput(out input, out num);
            WriteStars(out input, num);
        }
    }
}