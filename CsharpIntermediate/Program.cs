using System;

namespace CsharpIntermediate

{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1982,1,1));
            Console.WriteLine(person.GetBirthdate());


        }

        static void UseCustomer()
        {
            var customer = new Customer(3, "Onur");
            var order = new Order();
            customer.Orders.Add(order);
            Console.WriteLine(customer.Id); 
            Console.WriteLine(customer.Name);
         
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            Console.WriteLine(customer.Orders.Count);

        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 3));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected  error");

            }
        }
    }
}
