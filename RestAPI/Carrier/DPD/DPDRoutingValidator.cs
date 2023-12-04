using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI
{
    public class DPDRoutingValidator : RoutingValidator
    {
        private const string FILE_PATH = 
        @"C:\Users\kacperbok\Desktop\Nauka\C#\RestAPI\RestAPI\dpd2.json";

        private string _serializedRoutingData;
        private List<string> ZipCode;


        public bool ValidateRoutingData(PrepareShipmentData prepareShipmentData)
        {
            DownloadRoutingData();

            if (ZipCode.Contains(prepareShipmentData.Shipment.ReceiverZip))
            {
                return true;
            }
            else return false;
        }

        
        
        public List<string> DownloadRoutingData()
        {
            _serializedRoutingData = File.ReadAllText(FILE_PATH);
            ZipCode = JsonConvert.DeserializeObject<List<string>>(_serializedRoutingData);

            foreach (var item in ZipCode)
            {
                Console.WriteLine(item);
            }

            return ZipCode;


        }
    }
}
