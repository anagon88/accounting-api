using System;
using System.Web.Http;

namespace Accounting.DTO
{
    public class TransactionDTO
    {
        public Guid Id { get; set; }

        public int Type { get; set; }

        public decimal Amount { get; set; }

        public Guid FinancialAccountId { get; set; }
    }
}
