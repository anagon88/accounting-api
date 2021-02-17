using System;

namespace Accounting.Web.DTO
{
    public class TransactionDTO
    {
        public Guid Id { get; set; }

        public int Type { get; set; }

        public decimal Amount { get; set; }

        public Guid FinancialAccountId { get; set; }
    }
}
