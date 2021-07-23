using System;

namespace CsharpIntermediate
{
    public class Rectangle : Shape
    {
        public sealed override void Draw()
        {
            Console.WriteLine("Draw rectangle");
        }
    }
}