
using banking_c39;

using System.Runtime.Intrinsics.Arm;

var s1 = new SavingsComp();

s1.AccountId = "Greg";
s1.Description = "My Savings Account";
s1.Balance = 1000;

//Console.WriteLine($"S1 paid interest of {interest:C}");

Console.WriteLine($"S1 balance is {s1.Balance:C}");
