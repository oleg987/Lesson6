using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public enum Currencies
    {
        UAH,
        USD,
        EUR
    }

    public class BankAccount
    {
        private Transaction[] transactions;

        public int Number { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Ballance { get => Debit - Credit; }
        public string FullName { get; set; }
        public Currencies Currency { get; set; }

        public BankAccount()
        {
            transactions = new Transaction[0];
        }

        public void Put(decimal sum)
        {
            if (sum > 0)
            {
                Debit += sum;
                var success = new Transaction(TransactionType.Put, sum, true);
                AddTransaction(success);
            }
            else
            {
                var fail = new Transaction(TransactionType.Put, sum, false);
                AddTransaction(fail);
            }
        }

        public void Withdraw(decimal sum)
        {
            if (sum > 0 && sum <= Ballance)
            {
                Credit += sum;
                var success = new Transaction(TransactionType.Withdraw, sum, true);
                AddTransaction(success);
            }
            else
            {
                var fail = new Transaction(TransactionType.Withdraw, sum, false);
                AddTransaction(fail);
            }
        }

        public string TransactionsInfo()
        {
            if (transactions is null || transactions.Length == 0)
            {
                return "No transactions";
            }
            else
            {
                string info = "";

                foreach (var transaction in transactions)
                {
                    info += transaction.ToString() + "\r\n";
                }

                return info;
            }
        }

        private void AddTransaction(Transaction transaction)
        {
            Array.Resize(ref transactions, transactions.Length + 1);
            transactions[transactions.Length - 1] = transaction;
        }
    }
}
