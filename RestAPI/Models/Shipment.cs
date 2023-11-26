using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI
{
     public class Shipment
     {
        public string? ReceiverName1 { get; set; }
        public string? ReceiverName2 { get; set; }
        public string? Identifier { get;  set; }
        public string? ReceiverCity { get;  set; }
        public int? ShipmentId { get;  set; }
        public string? ShipmentDefinition { get;  set; }
        public bool? ShipmentDG { get; set; }
        public bool? ShipmentExpress { get; set;}

     }
}
