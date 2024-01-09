namespace Assignments
{
    /// <summary>
    /// A parent class called Bank Account
    /// </summary>
    public class BankAccount
    {
        private double _accBalance;
        /// <summary>
        /// fhdskjl
        /// </summary>
        /// <param name="withdrawAmount">lsdhfjs</param>
        public void Withdraw(double withdrawAmount)
        {
            this._accBalance -= withdrawAmount;

            Console.WriteLine("Account Balance after withdraw" + _accBalance);
        }
        /// <summary>
        /// fdkjvhds
        /// </summary>
        /// <param name="depositAmount">sdjfsdjn</param>
        public void Deposit(double depositAmount)
        {
            _accBalance += depositAmount;
            Console.WriteLine("Account Balance after deposit" + _accBalance);
        }
    }
}

