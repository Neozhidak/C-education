using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program6
    {


        static void Main(string[] args)
        {
            string current = "Параметры надписи: ";
            int num = 0;
            string input;
            while (true)
            {
                Console.Write("Введите номер параметра\n1:bold\n2:italic\n3:underline\n4:reset\n");
                input = Console.ReadLine();
                Int32.TryParse(input, out num);

                switch (num)
                {
                    case 1:
                        current = current + "bold ";
                        break;
                    case 2:
                        current = current + "italic ";
                        break;
                    case 3:
                        current = current + "underline ";
                        break;
                    case 4:
                        current = "Параметры надписи: ";
                        break;
                }
                Console.Write(current + "\npress enter to change font");
                Console.ReadLine();
            }
        }
    }
}