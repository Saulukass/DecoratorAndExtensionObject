using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionObject
    {
    interface IDriver
        {
        void Drive();
        int GetSalary();
        void ChangeSalary(int salary);
        IExtension GetExtension(string name);
        void AddExtension(string name, IExtension extension);
        void RemoveExtension(string name);
        }
    }
