using System;

namespace CsharpIntermediate
{
    public class Circle : Shape
    {
        public sealed override void Draw()
        {
            Console.WriteLine("Draw circle");
        }
    }
}