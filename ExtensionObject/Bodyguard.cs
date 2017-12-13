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

        public void AddRisksToSalary()
            {
            int currentSalary = driver.GetSalary();
            currentSalary *= 3;
            driver.ChangeSalary(currentSalary);
            }

        public void CheckSuroundings()
            {
            Console.WriteLine("[Bodyguard] Checking suroundings before moving");
            }
        }
    }
