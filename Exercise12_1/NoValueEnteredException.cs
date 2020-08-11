using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12_1
{
    public class NoValueEnteredException : System.ApplicationException
    {
        public NoValueEnteredException(string exceptionType) : base(exceptionType) 
        {
        }
    }
}
