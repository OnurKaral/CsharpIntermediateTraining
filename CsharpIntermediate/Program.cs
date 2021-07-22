using AccessModifiers;
using System;

namespace CsharpIntermediate

{
    public class Program
    {
         static void Main(string[] args)
        {
            var customer = new CustomerAccess();
            // AccessModifiers.RateCalculator calculator = new RateCalculator();
            customer.Promote();
        }

        private static void Log()
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();

            var text = new Text();
            text.Width = 100;
            text.Copy();
        }

        private static void HttpCookie()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Onur";
            Console.WriteLine(cookie["name"]);
        }

        private static void PropAge()
        {
            var person = new Person(new DateTime(1998, 09, 18));
            //  person.SetBirthdate(new DateTime(1982,1,1));
            //  Console.WriteLine(person.GetBirthdate());

            Console.WriteLine(person.Age);
        }

        private static void UseCustomer()
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

        private static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 3));
        }

        private static void UsePoints()
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