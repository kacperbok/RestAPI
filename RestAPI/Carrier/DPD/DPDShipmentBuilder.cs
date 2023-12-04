﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI
{
     public class DPDShipmentBuilder : ShipmentBuilder
     {
        public void SetIdentifier()
        {
            Shipment.Identifier = DPDIdentcodeBuilder.GenerateIdentcode();
        }     
     }
}
