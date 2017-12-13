using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionObject
    {
    class Bus : IBus
        {
        private int maxPassengers;
        public Bus()
            {
            maxPassengers = 10;
            }

        public int GetBonusPerPassenger()
            {
            return 20 * maxPassengers;
            }

        public void SetPassengersLimit(int limit)
            {
            maxPassengers = limit;
            }
        }
    }
