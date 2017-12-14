using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionObject
    {
    class Bodyguard : IBodyguard
        {
        IDriver driver;
        public Bodyguard(IDriver driver)
            {
            this.driver = driver;
            }

        public int GetSalaryIncludingRisks()
            {
            return driver.GetSalary() * 3;
            }

        public void CheckSuroundings()
            {
            Console.WriteLine("[Bodyguard] Checking suroundings before moving");
            }
        }
    }
