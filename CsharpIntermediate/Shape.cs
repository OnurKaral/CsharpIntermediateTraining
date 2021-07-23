using System;

namespace CsharpIntermediate
{
    public /*abstract*/  class Shape
    {
        public int Width { get; set; }
        public int Heigth { get; set; }

        public /*abstract*/ virtual void Draw()
        {
        }

        public void Copy()
        {
            Console.WriteLine("Copy..");
        }
    }
}