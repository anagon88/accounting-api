using System;
using Accounting.DataAccess.Repositories.Interfaces;
using Accounting.DataAccess.Storage;
using Accounting.Services.Models;

namespace Accounting.DataAccess.Repositories
{
    public class FinancialAccountRepository : IFinancialAccountRepository
    {
        public FinancialAccount GetFinancialAccount()
        {
            FinancialAccount account = MemoryDB.Instance.GetFinancialAccount();
            account.Transactions = MemoryDB.Instance.GetTransactions();
            return account;
        }
    }
}
