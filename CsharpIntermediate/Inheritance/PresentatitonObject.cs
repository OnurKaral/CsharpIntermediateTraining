using System;

namespace CsharpIntermediate
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Copied..");
        }

        public void Duplicate()
        {
            Console.WriteLine("duplicated..");
        }
    }
}