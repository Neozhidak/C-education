using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program12
    {
        static void Main(string[] args)
        {
            string input = "написать программу, которая";
            string template = "описание";

            char[] inputChars = input.ToArray();
            char[] templateChars = template.Distinct().ToArray();

            for (int i = 0; i < templateChars.Length; i++)
            {
                string x = templateChars[i].ToString();
                input = input.Replace(x, x + x);
            }

            Console.Write(input);
            Console.ReadLine();
        }
    }
}