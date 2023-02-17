using banking_c39.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_c39;
internal class Account {

    public string AccountId { get; set; } = string.Empty; // unique id
    public decimal Balance { get; set; } = 0;
    public string Description { get; set; } = String.Empty;

    public bool Deposit(decimal Amount) {
        if(Amount <= 0) {
            throw new AmountMustBeGreaterThanZeroException();
        }
        Balance += Amount; // Balance = Balance + Amount;
        return true;
    }

    public bool Withdraw(decimal Amount) {
        if(Amount <= 0) {
            throw new AmountMustBeGreaterThanZeroException();
        }
        if (Amount > Balance) {
            throw new InsufficientFundsException($"Insufficient Funds!", Amount, Balance);
        }
        Balance -= Amount;
        return true;
    }

    public bool Transfer(decimal Amount, Account ToAccount) {
        if (Amount <= 0) {
            Console.WriteLine($"Amount cannot be zero or negative.");
            return false;
        }
        // ----------------------
        var success = Withdraw(Amount);
        if(!success) {
            return false;
        }
        ToAccount.Deposit(Amount);
        return true;
        // ----------------------

/*
 *      if(Withdraw(Amount) {
 *          ToAccount.Deposit(Amount);
 *          return true;
 *      }
 *      return false;
 */
    }

}
