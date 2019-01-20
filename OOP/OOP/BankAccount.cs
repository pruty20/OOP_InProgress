using System;
namespace OOP
{
    /*
     *  Simulate a bank account supporting opening/closing, withdrawals, and deposits of money.
        It should be possible to close an account; operations against a closed account must fail.
        Remember you are working with money so you should use an appropriate data type for it.
     */

    public class BankAccount
    {
        public BankAccount()
        {
        }

        public static int accountNumber;




        public static string SetAccountNo()
        {
            accountNumber = 1000000000 + 1;
            string stringAccount = accountNumber.ToString();
            string officialAccountNumber;

            return officialAccountNumber = "ROINGB" + stringAccount;
        }

        public void PrintAccountNo()
        {
            Console.WriteLine($"Your account number is: {SetAccountNo()}");
        }

    }
}
