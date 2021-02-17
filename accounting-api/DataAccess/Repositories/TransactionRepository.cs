using System;
using System.Collections.Generic;
using Accounting.DataAccess.Repositories.Interfaces;
using Accounting.DataAccess.Storage;
using Accounting.Services.Models;

namespace Accounting.DataAccess.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        public Transaction CreateTransaction(Transaction transaction)
        {
            return MemoryDB.Instance.AddTransaction(transaction);
        }

        public Transaction GetTransaction(Guid id)
        {
            return MemoryDB.Instance.GetTransaction(id);
        }

        public IList<Transaction> GetTransactions()
        {
            return MemoryDB.Instance.GetTransactions();
        }

        public void RemoveTransaction(Guid id)
        {
            MemoryDB.Instance.RemoveTransaction(id);
        }
    }
}
