using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionObject
    {
    interface IDelivery : IExtension
        {
        void SetDeliveryDestination(string destination);
        bool ShouldDrive();
        }
    }
