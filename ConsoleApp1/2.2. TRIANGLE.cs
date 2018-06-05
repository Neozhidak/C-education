using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Triangle
    {
        private int a;
        private int b;
        private int c;
        private int p;

        public Triangle(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a > c + b || b > a + c || c > b + a )
            {
                throw new ArgumentException();
            }

            this.a = a;
            this.b = b;
            this.c = c;

            p = (a + b + c) / 2; ;

        }

        public double getS
        {
            get => (double)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public int getP
        {
            get => a + b + c;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(3,5,4);

            Console.Write($"Периметр = {triangle.getP}, Площадь = {triangle.getS}");
            Console.ReadLine();
        }
    }
}
