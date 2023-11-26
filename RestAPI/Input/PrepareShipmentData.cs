using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestAPI
{
    public class PrepareShipmentData
    {
        ///TEST PURPOSES ONLY
        private const string FILE_PATH = @"C:\Users\kacperbok\Desktop\Nauka\C#\RestAPI\RestAPI\test.json";

        public Shipment Shipment { get; private set; }
        public PrepareShipmentData()
        {
            var serializedShipment = File.ReadAllText(FILE_PATH);
            Shipment = JsonConvert.DeserializeObject<Shipment>(serializedShipment);
        }

        public static void DeserializeShipmentData()
        { 
            
        }
      
    }
}
