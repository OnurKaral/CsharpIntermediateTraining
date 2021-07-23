using AccessModifiers;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CsharpIntermediate

{
    public class Program
    {
        private static void Main(string[] args)
        {
            var dbMigrator = new DBMigratorI(new FileLogger("C:\\Users\\onurk\\Desktop\\log.txt"));
            dbMigrator.Migrate();
        }

        private static void OverridingMethods()
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }

        private static void UpcastingDowncasting()
        {
            //Shape shape = new TextNew();
            //TextNew text = (TextNew) shape;

            TextNew text = new TextNew();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);
            Console.WriteLine(shape.Width);
        }

        private static void Boxing()
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Onur");

            var anotherlist = new List<int>();
            var names = new List<string>();

            var number = (int)list[1];
        }

        private static void AccessModifiers()
        {
            //Shape shape = new TextNew();
            //TextNew text = (TextNew) shape;

            //TextNew text = new TextNew();
            //Shape shape = text;

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width);
            //Console.WriteLine(shape.Width);

            var customer = new CustomerAccess();
            // AccessModifiers.RateCalculator calculator = new RateCalculator();
            customer.Promote();
            var car = new Car("123");
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