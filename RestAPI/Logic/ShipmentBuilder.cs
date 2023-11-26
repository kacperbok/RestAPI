using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI
{
      public abstract class ShipmentBuilder 
      {
        private Shipment _shipment;
        public Shipment Shipment
        {
            get { return _shipment; }
            protected set { _shipment = value; }
        }
        public ShipmentBuilder()
        {
            _shipment = new Shipment();
        }

        public void AddReceiverData(PrepareShipmentData deserializedShipment)
        {
            _shipment.ReceiverName1 = deserializedShipment.Shipment.ReceiverName1;
            _shipment.ReceiverName2 = deserializedShipment.Shipment.ReceiverName2;
            _shipment.ReceiverCity = deserializedShipment.Shipment.ReceiverCity;
        }

        public void SetShipmentId()
        {
            _shipment.ShipmentId = DataBaseEntity.GetCurrentShipmentId() + 1;
        }

        public void IsShipmentDG(PrepareShipmentData deserializedShipment)
        {
            _shipment.ShipmentDG = deserializedShipment.Shipment.ShipmentDG;
        }

        public Shipment GetShipment()
        {
            return _shipment;
        }

      }

    

}



/*
 * model shipment +
 *  shipmentbuilder [ wzorzec builder] => zwraca shipmenta
 * 
 * shipment manager => decyduje jaki serwis przypisac + manifest/closing + delete
 */