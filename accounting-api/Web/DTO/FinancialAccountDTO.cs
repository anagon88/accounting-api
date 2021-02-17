using System;
using System.Collections.Generic;

namespace Accounting.Web.DTO
{
    public class FinancialAccountDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public IList<TransactionDTO> Transactions { get; set; }

        public decimal Total { get; set; }
    }
}
