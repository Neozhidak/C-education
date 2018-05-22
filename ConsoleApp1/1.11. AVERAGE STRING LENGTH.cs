using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program11
    {
        static void Main(string[] args)
        {
            string input = " ну тут1gh1.3, типа, написано3!   ";
            input = input.Trim();
            char[] chars = input.ToArray();
            int wordsCount = 1;
            int charsCount = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]) | char.IsDigit(chars[i])) { charsCount++; }
                else if (char.IsSeparator(chars[i])) { wordsCount++; }
            }

            Console.Write("Слов:" + wordsCount + "\n");
            Console.Write("Символов:" + charsCount + "\n");
            Console.Write("Среднее число символов:" + charsCount / wordsCount + "\n");
            Console.ReadLine();
        }
    }
}