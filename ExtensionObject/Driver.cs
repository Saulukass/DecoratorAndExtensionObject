using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionObject
    {
    class Driver : IDriver
        {
        private Dictionary<string, IExtension> extensions;
        private int salary;

        public Driver(int salary)
            {
            this.salary = salary;
            extensions = new Dictionary<string, IExtension>();
            }

        public void AddExtension(string name, IExtension extension)
            {
            extensions.Add(name, extension);
            }

        public void ChangeSalary(int salary)
            {
            this.salary = salary;
            }

        public void Drive()
            {
            foreach (var e in extensions)
                {
                if (e.Value is IDelivery && !(e.Value as IDelivery).ShouldDrive())
                    return;
                else if (e.Value is IBodyguard)
                    (e.Value as IBodyguard).CheckSuroundings();
                }
            Console.WriteLine("[Driver] Driving to location.");
            }

        public IExtension GetExtension(string name)
            {
            IExtension toReturn;
            extensions.TryGetValue(name, out toReturn);
            return toReturn;
            }

        public int GetSalary()
            {
            int toReturn = salary;
            foreach(var e in extensions)
                {
                if (e.Value is IBus)
                    toReturn += (e.Value as IBus).GetBonusPerPassenger();
                }
            return toReturn;
            }

        public void RemoveExtension(string name)
            {
            extensions.Remove(name);
            }
        }
    }
