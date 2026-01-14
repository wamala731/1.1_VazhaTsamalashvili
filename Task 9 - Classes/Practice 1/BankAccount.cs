using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    internal class BankAccount
    {
        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get;  set; }
        public string ?Note { get; set; }
        List <Transaction> Transactions = new List<Transaction>();

        public BankAccount() 
        { 
        }
        public BankAccount(string number, string owner, decimal balance, List <Transaction> transactions, string? note = "" )
        {
            Number = number;
            Owner = owner;
            Balance = balance;
            Transactions = transactions;
            Note = note;
        }

        public decimal GetBalance()
        {
            return Balance;
        }
        public void MakeDeposit(decimal amount)
        {
            Balance += amount;
            Transactions.Add( new Transaction( amount, DateTime.Now.Date) );
        }
        public void MakeWithdrawal (decimal amount)
        {
            Balance -= amount;
            Transactions.Add(new Transaction (-amount, DateTime.Now.Date ));
        }
        public void GetTransactionHistory()
        {
            foreach ( Transaction transaction in Transactions )
            {
                Console.WriteLine($"Amount: {transaction.Amount} Date: {transaction.TransactionDate}");
            }
        }
    }
}
