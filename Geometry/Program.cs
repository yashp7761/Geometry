using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new square() { width = 5 };
            var rectangle = new rectangle() { width = 2, length = 3 };

            square.display();
            rectangle.display();
        }

    }

    abstract class Shape
    {
        public abstract int getarea();

        public void display()
        {
            Console.WriteLine("Area is {0}", getarea());
        }
    }

    class square : Shape
    {
        public int width;

        public override int getarea()
        {
            return width * width;
        }
    }
    class rectangle : Shape
    {
        public int width;
        public int length;

        public override int getarea()
        {
            return width * length;
        }
    }
}
