using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionObject
    {
    interface IBus : IExtension
        {
        void SetPassengersLimit(int limit);
        int GetBonusPerPassenger();
        }
    }
