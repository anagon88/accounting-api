using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting.Services.Models
{
    public class FinancialAccount
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public IList<Transaction> Transactions { get; set; }

        public decimal Total()
        {
            return Transactions.Sum(x => x.Type == TransactionType.Debit? -x.Amount: x.Amount);
        }
    }
}
