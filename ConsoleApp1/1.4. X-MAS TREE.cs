using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program4
    {
        static void Main(string[] args)
        {
            string star = "*";
            string space = " ";
            string enter = "\n";
            int count = 10;
            int starsCount = 1;
            string result = "";

            Console.Write("Введите длинну\n");
            string input = Console.ReadLine();
            Int32.TryParse(input, out count);

            while (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    result = result + space;
                }
                for (int i = 0; i < starsCount; i++)
                {
                    result = result + star;
                }
                result = result + enter;
                count--;
                starsCount = starsCount + 2;
                Console.Write(result);
            };
            Console.ReadLine();
        }
    }
}