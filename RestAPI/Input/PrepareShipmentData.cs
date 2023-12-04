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
        private const string FILE_PATH =
        @"C:\Users\kacperbok\Desktop\Nauka\C#\RestAPI\RestAPI\test.json";

        private string _serializedShipment;
        public Shipment Shipment { get; private set; }


        public PrepareShipmentData()
        {
            if (File.Exists(FILE_PATH))
            {
                _serializedShipment = File.ReadAllText(FILE_PATH);
                Shipment = JsonConvert.DeserializeObject<Shipment>(_serializedShipment);
                Console.WriteLine(Shipment.ReceiverName1);
                Console.WriteLine(Shipment.ReceiverName2);
                Console.WriteLine(Shipment.ReceiverCity);
                Console.WriteLine(Shipment.ReceiverZip);
                Console.WriteLine(Shipment.ShipmentDG);
                Console.WriteLine(Shipment.ShipmentExpress);
                Console.WriteLine("Shipment has been deserialized");
            }

        }

        public static void DeserializeShipmentData()
        { 
            
        }
      
    }
}
