using System;

namespace MiscConcepts
{
    class Shape
    {
        public const float PI = 3.14F;
    }

    class Circle : Shape 
    {
        public double Radius { get; set; }

        public Circle (double radius)
        {
            Radius = radius;
        }
    }

    class Rectangle : Shape
    {
        public int Length { get; set; }

        public int Height { get; set;}

        public Rectangle(int length, int height)
        {
            Length = length;
            Height = height;
        }
    }

    class Triangle : Shape
    {
        public double Base { get; set; }

        public double Height { get; set; }

        public Triangle(double @base, int height)
        {
            Base = @base;
            Height = height;
        }
    }
    public class Program
    {
        static void Calculate(Shape shape)
        {
            if (shape is Circle)
            {
                Circle c = (Circle)shape;
                Console.WriteLine("Area of Circle:" + (c.Radius * c.Radius * Shape.PI));
            }
            else if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;
                Console.WriteLine("Area of Rectangle:" + (rectangle.Height * rectangle.Length));

            }
            else if (shape is Triangle triangle)
            {
                // triangle = (Triangle)shape;
                Console.WriteLine("Area of Triangle :" + (0.5 * triangle.Base * triangle.Height));
            }
            else
            {
                throw new ArgumentException("Invalid Shape");
            }

        }
        static void CalculateArea(Shape shape)
        {
            switch(shape)
            {
                case Circle circle when circle.Radius!=0:
                    Console.WriteLine("Area of Circle:" + (circle.Radius * circle.Radius * Shape.PI));
                        break;
            }
        }


        static void Main(string[] args)
        {
            Circle c = new Circle(10);
            Calculate(c);
            Rectangle r = new Rectangle(10, 5);
            Calculate(r);

        }
    }
    
}
