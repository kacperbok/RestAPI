using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI
{
    public class ServiceSelector
    {
        public static Shipment CarrierSelector() //there should be PrepareShipmentData object passed in future
        {
            PrepareShipmentData deserializedShipment = new PrepareShipmentData();

            if (deserializedShipment.Shipment.ShipmentDefinition.Contains("DPD"))
            {
                DPDShipmentBuilder shipmentBuilder = new DPDShipmentBuilder();
                shipmentBuilder.SetIdentifier();
                shipmentBuilder.SetShipmentId();
                shipmentBuilder.AddReceiverData(deserializedShipment);

                return shipmentBuilder.GetShipment();
            }
            else if (deserializedShipment.Shipment.ShipmentDefinition.Contains("DHL"))
            {
                DHLShipmentBuilder shipmentBuilder = new DHLShipmentBuilder();
                shipmentBuilder.SetIdentifier();
                shipmentBuilder.SetShipmentId();
                shipmentBuilder.AddReceiverData(deserializedShipment);

                return shipmentBuilder.GetShipment();
            }
            else
            {
                throw new Exception("No ShipmentDefinition found.");
            }     
        }

    }
}
