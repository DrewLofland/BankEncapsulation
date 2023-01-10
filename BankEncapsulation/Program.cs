using System.Globalization;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();
            Console.WriteLine($"Please enter a deposit amount");
            double userInput = double.Parse(Console.ReadLine());

            myAccount.Deposit(userInput);

            double userBalance = myAccount.GetBalance();

            Console.WriteLine($"Current Balance: {userBalance}");

        }
    }
}
