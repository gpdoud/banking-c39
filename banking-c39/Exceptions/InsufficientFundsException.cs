using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_c39.Exceptions;
internal class InsufficientFundsException : Exception {

    public decimal Balance { get; set; }
    public decimal Amount { get; set; }

    public InsufficientFundsException() 
        : base() { }
    
    public InsufficientFundsException(string Message) 
        : base(Message) { }

    public InsufficientFundsException(string Message, Exception InnerException) 
        : base(Message, InnerException) { }

    public InsufficientFundsException(string Message, decimal Amount, decimal Balance)
        : base($"{Message} Amount: {Amount:C}, Balance: {Balance:C}") {
        this.Amount = Amount;
        this.Balance = Balance;
    }

}
