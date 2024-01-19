namespace Assignments
{   /// <summary>
///  Derived class from the parent class
/// </summary>
    public class CheckingAccount : BankAccount
    {
        private double _accBalance;
        private string _accNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckingAccount"/> class.
        /// </summary>
        /// <param name="accNum">Account Number</param>
        /// <param name="accBalance">1000</param>
        public CheckingAccount(string accNum, double accBalance) 
        {
            this._accBalance = accBalance;
            this._accNumber = accNum;
        }

        /// <summary>
        /// Method to deposit
        /// </summary>
        /// <param name="depositAmount">100</param>
        public void Deposit(int depositAmount)
        {
            base.Deposit(depositAmount);
        }

        /// <summary>
        /// Withdraw amount
        /// </summary>
        /// <param name="withdrawAmonut">1000</param>
        public void Withdraw(int withdrawAmonut)
        {
            base.Withdraw(withdrawAmonut);
        }
    }
}