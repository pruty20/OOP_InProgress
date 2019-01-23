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

        private bool isBankAccOpen = false;

        private decimal amount;

        public bool IsBankAccOpen
        {
            get { return isBankAccOpen; }
        }


        public decimal Amount
        {
            get
            { 
                return amount;
            }
        }


        public void Open()
        {
            isBankAccOpen = true;
        }

        public void Close()
        {
            isBankAccOpen = false;
        }


        public void Deposit(decimal amountToDeposit)
        {
            if(isBankAccOpen == false)
            {
                throw new ArgumentException("\"Cannot perform any operations against a closed account\"");
            }
            else
            {
                amount += amountToDeposit;
            }

        }


        public void Withdraw(decimal amountToWithdraw)
        {
            if (isBankAccOpen == false)
            {
                throw new ArgumentException ("Cannot perform any operations against a closed account");
            }
            else
            {
                amount -= amountToWithdraw;
            }

        }




    }
}
