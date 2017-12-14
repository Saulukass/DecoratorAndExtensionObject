using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionObject
    {
    interface IBodyguard : IExtension
        {
        int GetSalaryIncludingRisks();
        void CheckSuroundings();
        }
    }
