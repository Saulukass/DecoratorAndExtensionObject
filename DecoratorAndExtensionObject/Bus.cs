using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
    {
    class Bus : DriverDecorator
        {
        private int maxPassengers;

        public Bus(IDriver driver) : base(driver)
            {
            maxPassengers = 10;
            }

        public override int GetSalary()
            {
            return base.GetSalary() + 20 * maxPassengers;
            }

        public void SetPassengersLimit(int limit)
            {
            maxPassengers = limit;
            }
        }
    }
