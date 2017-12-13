using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
    {
    class Driver : IDriver
        {
        private int salary;

        public Driver(int salary)
            {
            this.salary = salary;
            }

        public void ChangeSalary(int salary)
            {
            this.salary = salary;
            }

        public void Drive()
            {
            Console.WriteLine("[Driver] Driving to location");
            }

        public int GetSalary()
            {
            return salary;
            }
        }
    }
