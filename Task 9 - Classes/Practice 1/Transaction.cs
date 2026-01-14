using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    internal class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public Transaction()
        {
        }
        public Transaction(decimal amount, DateTime date)
        {
            Amount = amount;
            TransactionDate = date;
        }
    }
}
