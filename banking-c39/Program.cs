
using banking_c39;
using banking_c39.Exceptions;

using System.Runtime.Intrinsics.Arm;

try {

    var s1 = new Savings();

    s1.AccountId = "Greg";
    s1.Description = "My Savings Account";
    s1.Balance = 1000;

    try {

        s1.Withdraw(10000);
        s1.Deposit(-100);
    
    } catch (InsufficientFundsException ex) {
    
        Console.WriteLine(ex.Message);
    
    } catch (AmountMustBeGreaterThanZeroException ex) {
    
        Console.WriteLine("Account is not positive");
    
    } catch(Exception) {

    }

    //Console.WriteLine($"S1 paid interest of {interest:C}");

    Console.WriteLine($"S1 balance is {s1.Balance:C}");

} catch (Exception ex) {
    Console.WriteLine($"Exception: {ex.Message}");
}