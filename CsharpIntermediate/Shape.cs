using System;

namespace CsharpIntermediate
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw triangle");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Heigth { get; set; }

        public virtual void Draw()
        {
        }
    }
}