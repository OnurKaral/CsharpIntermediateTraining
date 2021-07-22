using System;

namespace CsharpIntermediate
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
        : base(registrationNumber)
        {
            Console.WriteLine("car created.. {0}", registrationNumber);
        }
    }
}