namespace Assignments
{/// <summary>
/// This is s derived class from the base class BankAccount
/// </summary>
    public class SavingsAccount : BankAccount
    {
        /// <summary>
        /// Variables to store acc details
        /// </summary>
        private string _accNumber;
        private double _accBalance;
        /// <summary>
        /// Initializes a new instance of the <see cref="SavingsAccount"/> class.
        /// Account number and account balance
        /// </summary>
        /// <param name="accNumber">Account Number</param>
        /// <param name="accBalance"> Account Balance</param>
        public SavingsAccount(string accNumber, double accBalance) 
        {
           _accBalance = accBalance;
           _accNumber = accNumber;
        }
        /// <summary>
        /// Amount to be deposited
        /// </summary>
        /// <param name="depositAmount">1000</param>
        public void Deposit(double depositAmount)
        {
            base.Deposit(depositAmount);
        }
        /// <summary>
        /// Withdrawn Amonut
        /// </summary>
        /// <param name="withdrawAmount">1000</param>
        public void Withdraw(double withdrawAmount)
        {
            if (withdrawAmount < _accBalance) 
            {
                base.Withdraw(withdrawAmount);
             }
            else
            {
                Console.WriteLine("Minium Balance Exceeded");
            }
        }
    }
}