using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
    {
    class Delivery : DriverDecorator
        {
        private string deliveryDestination;

        public Delivery(IDriver driver) : base(driver)
            {
            deliveryDestination = null;
            }

        public void SetDeliveryDestination(string destination)
            {
            this.deliveryDestination = destination;
            }

        public override void Drive()
            {
            if (String.IsNullOrEmpty(deliveryDestination))
                {
                Console.WriteLine("[Delivery] Destination is not specified not going anywhere.");
                return;
                }
            Console.WriteLine("[Delivery] Delivering stuff to " + deliveryDestination);
            base.Drive();
            }
        }
    }
