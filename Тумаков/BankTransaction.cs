using System;

namespace Тумаков
{
    internal class BankTransaction
    {
        public DateTime TransactionDate;
        public decimal Amount;

        public BankTransaction(decimal amount)
        {
            TransactionDate = DateTime.Now;
            Amount = amount;
        }
        public override string ToString()
        {
            return $"Дата транзакции {TransactionDate}, Сумма транзакции: {Amount}";
        }

    }
}
