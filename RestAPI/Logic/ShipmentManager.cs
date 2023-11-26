using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI
{
    public abstract class ShipmentManager
    {

        public static Shipment CreateShipment()
        {
            return ServiceSelector.CarrierSelector();
        }


        public static void DeleteShipment(Shipment shipment)
        { 
        
        }

    }
}
