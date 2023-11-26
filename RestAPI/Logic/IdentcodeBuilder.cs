using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI
{
    public class IdentcodeBuilder
    {
        private static int _currentNumberRange;

        protected static int GetCurrentNumberRange()
        {
           _currentNumberRange = DataBaseEntity.GetCurrentNumberRange();
           return _currentNumberRange;
        }
      
    }
}
