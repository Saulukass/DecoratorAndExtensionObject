using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
    {
    class Bodyguard : DriverDecorator
        {
        public Bodyguard(IDriver driver) : base(driver)
            {}

        public void AddRisksToSalary()
            {
            int currentSalary = GetSalary();
            currentSalary *= 3;
            ChangeSalary(currentSalary);
            }

        public override void Drive()
            {
            Console.WriteLine("[Bodyguard] Check suroundings before moving.");
            base.Drive();
            }
        }
    }
