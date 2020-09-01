using Exceções_Try_Catch.Entities.Excepetions;

namespace Exceções_Try_Catch.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string name, double balance)
        {
            Number = number;
            Name = name;
            Balance = balance;
            WithdrawLimit = 300.00;
        }

        public void Deposit(double deposit)
        {
            Balance = deposit;
        }

        public void Withdraw(double withdraw)
        {
            if (withdraw > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            else if (withdraw > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else
            {
                Balance = Balance - withdraw;
            }
        }
    }
}