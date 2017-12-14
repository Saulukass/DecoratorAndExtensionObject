using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
    {
    class Bodyguard : DriverDecorator
        {
        private int risks;
        public Bodyguard(IDriver driver) : base(driver)
            {
            risks = 0;
            }

        public void CountRisksBasedOnSalary()
            {
            int currentSalary = GetSalary();
            risks = currentSalary * 3;
            }

        public override void Drive()
            {
            Console.WriteLine("[Bodyguard] Check suroundings before moving.");
            base.Drive();
            }

        public override int GetSalary()
            {
            return base.GetSalary() + risks;
            }
        }
    }
