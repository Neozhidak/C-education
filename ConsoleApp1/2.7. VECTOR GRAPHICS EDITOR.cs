using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    public abstract class Figure
    {
        public virtual int GetLength() => 0;
        public virtual int GetArea() => 0;
    }

    public class Line:Figure
    {
        private int length;
        public Line(int length)
        {
            if (length <= 0) { throw new ArgumentException(); }
            this.length = length;
        }
        public override int GetLength(){ return length; }
    }

    public class Round:Figure
    {
        protected internal int radius;
        public Round(int radius)
        {
            if (radius <= 0) { throw new ArgumentException(); }
            this.radius = radius;
        }
        public override int GetLength()
        {
            return (int)(2 * Math.PI) * radius;
        }
    }

    public class Circle: Round
    {
        public Circle(int radius):base(radius){ }
        public override int GetArea()
        {
            return (int)(Math.PI * Math.Pow(radius, 2));
        }
    }

    public class Ring: Circle
    {
        private int radiusInt;
        public Ring(int radius, int radiusInt) : base(radius)
        {
            if (radiusInt <= 0) { throw new ArgumentException(); }
            this.radiusInt = radiusInt;
        }
        public override int GetArea()
        {
            return (int)(Math.PI * (Math.Pow(radius, 2) - Math.Pow(radiusInt, 2)));
        }
        public override int GetLength()
        {
            return (int)(((2 * Math.PI) * radiusInt) + base.GetLength());
        }
    }
    public class Rectangle: Figure
    {
        internal int width;
        internal int height;
        public Rectangle(int width, int height)
        {
            if (width <= 0 || height <= 0 || height == width) { throw new ArgumentException(); }
            this.width = width;
            this.height = height;
        }
        public override int GetArea()
        {
            return width * height;
        }
        public override int GetLength()
        {
            return width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Figure[] arr = new Figure[5];
            Console.Write("Введите число чтобы создать объект:\n1:Линия\n2:Окружность\n3:Круг\n4:Кольцо\n5:Прямоугольник\n");

            arr[0] = new Line(10);
            arr[1] = new Round(10);
            arr[2] = new Circle(10);
            arr[3] = new Ring(10, 5);
            arr[4] = new Rectangle(10, 15);

            foreach (var i in arr)
            {
                Console.Write($"Тип: {i.GetType()}\nПлощадь: {i.GetArea()}\nДлина: {i.GetLength()}\nPress enter\n");
                Console.ReadLine();
            }


        }
    }
}
