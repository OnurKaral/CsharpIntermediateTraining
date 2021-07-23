using System;

namespace CsharpIntermediate
{
    public class Triangle : Shape
    {
        public sealed override void Draw()
        {
            Console.WriteLine("Draw triangle");
        }
    }
}