using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI
{
    public class DPDIdentcodeBuilder : IdentcodeBuilder
    {
        
        const string PREFIX = "DPD";

        public static string GenerateIdentcode()
        {
           return PREFIX + GetCurrentNumberRange().ToString();
        }

    }
}
