using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("Enter a amount you want to deposit.");
            int accountInput = Convert.ToInt32(Console.ReadLine());

            account.amount = accountInput;

            Console.WriteLine($"The amount in your bank account is: ${account.amount}");
        }
    }
}
