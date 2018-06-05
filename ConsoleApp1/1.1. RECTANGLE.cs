using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program1
    {
        public static void CheckLength(out string input, out int length)
        {
            Console.Write("Ввведите длинну\n");
            input = Console.ReadLine();
            while (!Int32.TryParse(input, out length) | length <= 0)
            {
                Console.WriteLine("Вводимое значение должно быть не отрицательным целым числом");
                Console.Write("Введите длинну\n");
                input = Console.ReadLine();
            }
        }
        public static void CheckWidth(out string input, out int width)
        {
            Console.Write("Ввведите ширину\n");
            input = Console.ReadLine();
            while (!Int32.TryParse(input, out width) | width <= 0)
            {
                Console.WriteLine("Вводимое значение должно быть не отрицательным целым числом");
                Console.Write("Введите ширину\n");
                input = Console.ReadLine();
            }
        }


        static void Main(string[] args)
        {
            int length = 0;
            int width = 0;
            string input = "";
            CheckLength(out input, out length);
            CheckWidth(out input, out width);
            Console.Write("result: " + length * width);
            Console.ReadLine();
        }
    }
}
