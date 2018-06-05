using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    public class MyString
    {
        private string input;
        private char[] chars;

        public MyString(string input)
        {
            this.input = input;
        }

        public char[] ToArray()
        {
            chars = input.ToArray();
            return input.ToArray();
        }

        public override string ToString()
        {
            return new string(chars);
        }

        public bool IsChar(char x)
        {
            if (input.IndexOf(x) < 0) { return false; }
            return true;
        }

        public string Concat(string SumString)
        {
            return input + SumString;
        }

        public bool IsEqual(string EqString)
        {
            if (input == EqString) { return true; }
            else { return false; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var MyString = new MyString("строка");

            Console.Write(
                $"В массив: {MyString.ToArray()[2]}\n" +
                $"В строку: {MyString.ToString()}\n" +
                $"Поиск символа Ж: {MyString.IsChar('Ж')}\n" +
                $"Поиск символа а: {MyString.IsChar('а')}\n" +
                $"Сложить строки: {MyString.Concat("Привет")}\n" +
                $"Сравнение: {MyString.IsEqual("Привет")}\n"
                );

            Console.ReadLine();
        }
    }
}
