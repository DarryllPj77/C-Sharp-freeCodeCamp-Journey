using System;

namespace Task_3___Money_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*DISPLAY "Enter payment amount"

            INPUT paymentString

            IF TryParse paymentString to decimal payment THEN
                  DISPLAY "Payment accepted"
            ELSE
                  DISPLAY "Invalid amount"
            END IF*/

            // Fix sample AccountBalance = 30,000
            //decimal accountBalance = 30000;

            //Display accountBalance
            //AccountBalance(accountBalance);
            decimal balance = AccountBalance(30000);

            Console.WriteLine("Accout Balance: " + balance);
            Console.Write("Enter Amount to Withdraw: ");
            string amount = Console.ReadLine();

            bool valid = decimal.TryParse(amount, out decimal number);

            do
            {
                // for validation 
                if (valid)
                {
                    Console.WriteLine("Amount Withdrawed: {0}", number);
                    //WithdrawAmount(number);
                }
                else
                {
                    Console.WriteLine("Invalid Input amount");
                    Console.Write("Enter Amount to Withdraw: ");
                    amount = Console.ReadLine();
                    valid = decimal.TryParse(amount, out number);
                }
            } while (!valid);

            Console.Write("Do you want to withdraw?(Yes or No): ");
            string choice = Console.ReadLine();
            string yes = "YES";
            if (choice.ToUpper() == yes)
            {
                decimal withdrawAmount = WithdrawAmount(number);
                Console.WriteLine("User Will withdrawing the amount of {0}", withdrawAmount);
                decimal newBalance = UserWithdraw(balance ,withdrawAmount);
            }
            else if(choice.ToUpper() != yes)
            {
                Console.WriteLine("The user is not going to Withdraw");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

        }

        static decimal WithdrawAmount(decimal withdrawAmount)
        {
            return withdrawAmount;
        }

        static decimal UserWithdraw(decimal balance, decimal withdraw)
        {
            decimal accoutBalance = balance;

            decimal newBalance = accoutBalance - WithdrawAmount(withdraw);

            Console.WriteLine("newBalance:" + newBalance);

            return newBalance;
        }

        static decimal AccountBalance(decimal balance)
        {
            return balance;
        }
    }
}
