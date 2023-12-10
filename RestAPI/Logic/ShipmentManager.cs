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
            PrepareShipmentData prepareShipmentData = new PrepareShipmentData();
            return ServiceSelector.CarrierSelector(prepareShipmentData); 
        }

        public static void DeleteShipment(Shipment shipment)
        { 
        
        }

    }
}
