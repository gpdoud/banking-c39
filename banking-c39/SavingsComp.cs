using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_c39;
internal class SavingsComp {

    private Account acct = new Account();

    //public decimal InterestRate { get; set; } = 0.12m;

    public string AccountId {
        get {
            return acct.AccountId;
        }
        set {
            acct.AccountId = value;
        }
    }
    public string Description {
        get {
            return acct.Description;
        }
        set {
            acct.Description = value;
        }
    }

    public decimal Balance {
        get {
            return acct.Balance;
        }
        set {
            acct.Balance = value;
        }
    }

    public bool Deposit(decimal Amount) {
        return acct.Deposit(Amount);
    }
    public bool Withdraw(decimal Amount) {
        return acct.Withdraw(Amount);
    }
    public bool Transfer(decimal Amount, SavingsComp ToAccount) {
        return acct.Transfer(Amount, ToAccount.acct);
    }
}
