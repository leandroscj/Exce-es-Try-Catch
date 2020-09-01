using Exceções_Try_Catch.Entities;
using Exceções_Try_Catch.Entities.Excepetions;
using System;

namespace Exceções_Try_Catch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter account data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine());

            Account account = new Account(number, name, balance);

            Console.WriteLine("Withdraw Limit: " + account.WithdrawLimit);
            try
            {
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                account.Withdraw(withdraw);
                Console.WriteLine("New balance:" + account.Balance.ToString("F2"));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}