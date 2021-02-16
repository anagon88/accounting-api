using System;
using System.Web.Http;

namespace Accounting.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }

        public TransactionType Type { get; set; }

        public decimal Amount { get; set; }

        public FinancialAccount FinancialAccount { get; set; }
    }
}
