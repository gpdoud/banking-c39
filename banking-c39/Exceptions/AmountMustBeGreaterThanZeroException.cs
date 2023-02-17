using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_c39.Exceptions;
internal class AmountMustBeGreaterThanZeroException : Exception {

    public AmountMustBeGreaterThanZeroException() 
        : base() { }
    
    public AmountMustBeGreaterThanZeroException(string Message) 
        : base(Message) { }

    public AmountMustBeGreaterThanZeroException(string Message, Exception InnerException) 
        : base(Message, InnerException) { }
}
