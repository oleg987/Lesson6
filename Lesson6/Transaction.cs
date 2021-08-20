using System;

namespace Lesson6
{
    public enum TransactionType
    {
        Put,
        Withdraw
    }

    public class Transaction
    {
        public Guid Id { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Sum { get; set; }
        public bool IsSucces { get; set; }
        public DateTime Created { get; set; }

        public Transaction(TransactionType transactionType, decimal sum, bool isSucces)
        {
            Id = Guid.NewGuid();
            TransactionType = transactionType;
            Sum = sum;
            IsSucces = isSucces;
            Created = DateTime.UtcNow;
        }

        public override string ToString()
        {
            return $"Id: {Id}; Type: {TransactionType}; Sum: {Sum}; Success: {IsSucces}; Date: {Created}";
        }
    }
}
