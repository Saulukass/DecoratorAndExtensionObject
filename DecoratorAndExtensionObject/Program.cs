using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
    {
    class Program
        {
        static void Main(string[] args)
            {
            IDriver driver = new Driver(500);
            Console.WriteLine("New driver gets " + driver.GetSalary() + " per month.");

            driver = new Bodyguard(driver);
            Console.WriteLine("Now driver is also a bodyguard.");
            driver.Drive();

            driver = new Bus(driver);
            Console.WriteLine("Also working as bus driver. Now gets " + driver.GetSalary() + " per month");

            (driver as DriverDecorator).GetRole<Bus>().SetPassengersLimit(30);
            Console.WriteLine("More passengers are coming, salary is now " + driver.GetSalary() + " per month");

            Console.WriteLine("Driver also delivers deliveries");
            driver = new Delivery(driver);
            (driver as DriverDecorator).GetRole<Delivery>().SetDeliveryDestination("Vilnius");
            driver.Drive();

            driver = (driver as DriverDecorator).RemoveRole<Bus>();
            Console.WriteLine("Lost job as bus driver. Salary " + driver.GetSalary() + " per month");

            (driver as DriverDecorator).GetRole<Bodyguard>().AddRisksToSalary();
            Console.WriteLine("Considering risks working as bodyguard driver's salary " + driver.GetSalary() + " per month");
            driver = (driver as DriverDecorator).RemoveRole<Delivery>();
            driver = (driver as DriverDecorator).RemoveRole<Bodyguard>();
            Console.WriteLine("Now just regular driver " + driver.GetSalary() + " per month");
            driver.Drive();

            Console.ReadKey();
            }
        }
    }
