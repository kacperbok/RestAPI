using System;

namespace RestAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            DPDRoutingValidator asd = new DPDRoutingValidator();
            asd.DownloadRoutingData();

        }
    }
}


