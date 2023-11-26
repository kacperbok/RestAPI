using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI
{
     public class DHLShipmentBuilder : ShipmentBuilder
     {
        private const string SERVICE = "DHL";

        public void SetService()
        {
            Shipment.ShipmentDefinition = SERVICE;
        }

        public void SetIdentifier()
        {
            Shipment.Identifier = DPDIdentcodeBuilder.GenerateIdentcode();
        }

        
        
        

            

     }
}
