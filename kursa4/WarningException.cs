using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    internal class WarningException : Exception
    {
        public WarningException() { }
        public WarningException(string message) : base(message) { }
        public WarningException(string message, Exception e) : base(message, e) { }
    }
}
