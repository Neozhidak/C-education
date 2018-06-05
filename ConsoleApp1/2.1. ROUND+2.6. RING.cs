using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round
{
    public class Round
    {
        private int centerX;
        private int centerY;
        private int radius;
        public double pi = 3.14;

        public Round() { }

        public Round(int centerX, int centerY, int radius)
        {
            if (centerX <= 0 || centerY <= 0 || radius <= 0 || centerY > radius || centerX > radius || centerX < radius || centerY < radius)
            {
                Console.Write("Ошибка!");
                throw new ArgumentException();
            }

            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
        }

        public int GetLength
        {
            get => (int)((2 * pi) * radius);
        }
        public int GetArea
        {
            get => (int)(pi * Math.Pow(radius, 2));
        }
        public int GetRadius
        {
            get => radius;
        }
    }

    public class Ring : Round
    {
        private int radiusInt;

        public Ring(int radius, int radiusInt, int centerX, int centerY) : base(radius, centerX, centerY)
        {
            if (radiusInt <= 0 || radiusInt == GetRadius)
            {
                throw new ArgumentException();
            }

            this.radiusInt = radiusInt;
        }

        public int GetRingArea
            {
            get => (int)(pi * (Math.Pow(GetRadius, 2) - Math.Pow(radiusInt, 2)));
            }

        public int GetRingLength
        {
            get => (int)(((2 * pi) * radiusInt) + GetLength);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var round = new Round(10, 10, 10);

            Console.Write($"Площадь круга = {round.GetArea} \n");
            Console.Write($"Длина окружности = {round.GetLength} \n");
            Console.ReadLine();

            var ring = new Ring(10, 5, 10, 10);
            Console.Write($"Площадь кольца = {ring.GetRingArea} \n");
            Console.Write($"Суммарная длина кольца  = {ring.GetRingLength} \n");
            Console.ReadLine();

        }
    }
}
