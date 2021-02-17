using System;

namespace Accounting.Services.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }

        public TransactionType Type { get; set; }

        public decimal Amount { get; set; }

        public Guid FinancialAccountId { get; set; }
    }
}
