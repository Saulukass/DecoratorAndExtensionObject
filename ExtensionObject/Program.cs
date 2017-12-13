using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionObject
    {
    class Program
        {
        static void Main(string[] args)
            {
            IDriver driver = new Driver(500);
            Console.WriteLine("New driver gets " + driver.GetSalary() + " per month.");

            driver.AddExtension("Bodyguard", new Bodyguard(driver));
            Console.WriteLine("Now driver is also a bodyguard.");
            driver.Drive();

            driver.AddExtension("BusDriver", new Bus());
            Console.WriteLine("Also working as bus driver. Now gets " + driver.GetSalary() + " per month");

            (driver.GetExtension("BusDriver") as Bus).SetPassengersLimit(30);
            Console.WriteLine("More passengers are coming, salary is now " + driver.GetSalary() + " per month");

            Console.WriteLine("Driver also delivers deliveries");
            driver.AddExtension("Delivery", new Delivery(driver));
            (driver.GetExtension("Delivery") as Delivery).SetDeliveryDestination("Vilnius");
            driver.Drive();

            driver.RemoveExtension("BusDriver");
            Console.WriteLine("Lost job as bus driver. Salary " + driver.GetSalary() + " per month");

            (driver.GetExtension("Bodyguard") as Bodyguard).AddRisksToSalary();
            Console.WriteLine("Considering risks working as bodyguard driver's salary " + driver.GetSalary() + " per month");
            driver.RemoveExtension("Bodyguard");
            driver.RemoveExtension("Delivery");
            Console.WriteLine("Now just regular driver " + driver.GetSalary() + " per month");
            driver.Drive();

            Console.ReadKey();
            }
        }
    }
