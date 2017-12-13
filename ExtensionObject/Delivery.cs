using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionObject
    {
    class Delivery : IDelivery
        {
        private string destination;
        public Delivery(IDriver driver)
            {
            destination = null;
            }

        public bool ShouldDrive()
            {
            if (string.IsNullOrEmpty(destination))
                {
                Console.WriteLine("[Delivery] No destination, not going anywhere");
                return false;
                }
            Console.WriteLine("Delivering stuff to " + destination);
            return true;
            }

        public void SetDeliveryDestination(string destination)
            {
            this.destination = destination;
            }
        }
    }
