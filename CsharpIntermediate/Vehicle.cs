using System;

namespace CsharpIntermediate
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle created..");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle created.. {0}", registrationNumber);
        }
    }
}