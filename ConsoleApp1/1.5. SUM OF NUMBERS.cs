using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program5
    {
        static void Main(string[] args)
        {
            int num = 0;
            int firstmult = 3;
            int secondmult = 5;
            string input;
            int result = 0;

            Console.Write("Введите число\n");
            input = Console.ReadLine();
            Int32.TryParse(input, out num);

            for (int i = 0; i < num; i++)
            {
                if (i % firstmult == 0 | i % secondmult == 0)
                {
                    result = result + i;
                }
            }

            Console.Write("result: " + result);
            Console.ReadLine();
        }
    }
}