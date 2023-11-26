using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI
{
    class DHLIdentcodeBuilder : IdentcodeBuilder
    {

        const string PREFIX = "DPD";

        public static string GenerateIdentcode()
        {
            return PREFIX + GetCurrentNumberRange().ToString();
        }
    }
}
