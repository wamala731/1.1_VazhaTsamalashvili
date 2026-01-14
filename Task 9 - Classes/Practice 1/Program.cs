using System.Data;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Transaction> transactions = new List<Transaction> {
                new Transaction ( 1000, new DateTime (2022, 05, 12, 13, 7, 56) ),
                new Transaction ( -500, new DateTime (2022, 06, 15, 9, 30, 0) ),
                new Transaction ( 1500, new DateTime (2023, 11, 20, 16, 45, 30) ),
                new Transaction ( -300, new DateTime (2024, 01, 25, 11, 15, 0) ),
                new Transaction ( 700, new DateTime (2025, 08, 05, 14, 0, 0) ),
                new Transaction ( -200, new DateTime (2026, 02, 14, 10, 20, 0) )
                };
            List<Transaction> transactions2 = new List<Transaction> {
                new Transaction ( 2000, new DateTime (2022, 03, 10, 10, 0, 0) ),
                new Transaction ( -800, new DateTime (2022, 04, 18, 15, 30, 0) ),
                new Transaction ( 1200, new DateTime (2023, 09, 22, 12, 45, 0) ),
                new Transaction ( -400, new DateTime (2024, 12, 30, 9, 15, 0) )
                };
            List<Transaction> transactions3 = new List<Transaction> {
                new Transaction ( 1500, new DateTime (2022, 07, 05, 14, 0, 0) ),
                new Transaction ( -600, new DateTime (2022, 08, 12, 11, 30, 0) ),
                new Transaction ( 900, new DateTime (2023, 10, 28, 16, 20, 0) ),
                new Transaction ( -250, new DateTime (2024, 11, 15, 10, 10, 0) )
                };
            BankAccount account = new BankAccount("1234 5678 9876 5432", "Giorgi", 16000, transactions);
            BankAccount account2 = new BankAccount("9876 5432 1234 5678", "Mariami ", 5000, transactions2);
            BankAccount account3 = new BankAccount("4567 8901 2345 6789", "Nika", 8000, transactions3);
            while (true)
            {
                Console.WriteLine("===================");
                Console.WriteLine("Options: ");
                Console.WriteLine("1. Deposit.");
                Console.WriteLine("2. Withdraw.");
                Console.WriteLine("3. Get Balance.");
                Console.WriteLine("4. Ger History.");
                Console.WriteLine("===================");
                byte operationChoise = Convert.ToByte(Console.ReadLine());
                if (operationChoise < 1 || operationChoise > 4)
                {
                    Console.WriteLine("Invalid operation choice. Please select a valid option.");
                    continue;
                }
                Console.WriteLine("===================");
                Console.WriteLine("Choose account: ");
                Console.WriteLine("1. Giorgi's account.");
                Console.WriteLine("2. Mariami's account.");
                Console.WriteLine("3. Nikas's account. ");
                Console.WriteLine("===================");
                byte accountChoise = Convert.ToByte(Console.ReadLine());
                if (accountChoise< 1 || accountChoise >3)
                {
                    Console.WriteLine("Invalid operation choice. Please select a valid option.");
                    continue;
                }
                decimal amount;
                while (true)
                {
                    if (operationChoise == 1)
                    {
                        Console.WriteLine("Enter deposit amount: ");
                        if (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
                        {
                            Console.WriteLine("Invalid amount. Deposit amount must be a positive number.");
                        }
                        if (accountChoise == 1)
                        {
                            account.MakeDeposit(amount);
                            break;
                        }
                        else if (accountChoise == 2)
                        {
                            account2.MakeDeposit(amount);
                            break;
                        }
                        else if (accountChoise == 3)
                        {
                            account3.MakeDeposit(amount);
                            break;
                        }
                    }
                    else if (operationChoise == 2)
                    {
                        Console.WriteLine("Enter withdrawal amount: ");
                        if (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
                        {
                            Console.WriteLine("Invalid amount. Withdrawal amount must be a positive number.");
                        }
                        if (accountChoise == 1)
                        {
                            account.MakeWithdrawal(amount);
                            break;
                        }
                        else if (accountChoise == 2)
                        {
                            account2.MakeWithdrawal(amount);
                            break;
                        }
                        else if (accountChoise == 3)
                        {
                            account3.MakeWithdrawal(amount);
                            break;
                        }
                    }
                    else if (operationChoise == 3)
                    {
                        if (accountChoise == 1)
                        {
                            Console.WriteLine("Current Balance: " + account.GetBalance());
                            break;
                        }
                        else if (accountChoise == 2)
                        {
                            Console.WriteLine("Current Balance: " + account2.GetBalance());
                            break;
                        }
                        else if (accountChoise == 3)
                        {
                            Console.WriteLine("Current Balance: " + account3.GetBalance());
                            break;
                        }
                    }
                    else
                    {
                        if (accountChoise == 1)
                        {
                            account.GetTransactionHistory();
                            break;
                        }
                        else if (accountChoise == 2)
                        {
                            account2.GetTransactionHistory();
                            break;
                        }
                        else if (accountChoise == 3)
                        {
                            account3.GetTransactionHistory();
                            break;
                        }
                    }
                }

            }
        }
    }
}