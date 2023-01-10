using System.Globalization;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();
            Console.WriteLine($"Please enter a deposit amount");
            double depositAmount = double.Parse(Console.ReadLine());

            ba.Deposit(depositAmount);

            double userBalance = ba.GetBalance();

            Console.WriteLine($"Current Balance: {userBalance}");

        }
    }
}
