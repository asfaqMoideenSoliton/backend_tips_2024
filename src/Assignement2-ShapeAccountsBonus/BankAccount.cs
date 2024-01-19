namespace Assignments
{
    /// <summary>
    /// A parent class called Bank Account
    /// </summary>
    public class BankAccount
    {
        private double _accBalance;
        /// <summary>
        /// Method t withdraw amount
        /// </summary>
        /// <param name="withdrawAmount">lsdhfjs</param>
        public void Withdraw(double withdrawAmount)
        {
            this._accBalance -= withdrawAmount;

            Console.WriteLine("Account Balance after withdraw" + _accBalance);
        }

        /// <summary>
        /// Method to deposit amount
        /// </summary>
        /// <param name="depositAmount">1000</param>
        public void Deposit(double depositAmount)
        {
            _accBalance += depositAmount;
            Console.WriteLine("Account Balance after deposit" + _accBalance);
        }
    }
}

