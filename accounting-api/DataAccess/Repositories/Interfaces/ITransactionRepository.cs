using System;
using System.Collections.Generic;
using Accounting.Services.Models;

namespace Accounting.DataAccess.Repositories.Interfaces
{
    public interface ITransactionRepository
    {
        Transaction CreateTransaction(Transaction transaction);

        Transaction GetTransaction(Guid id);

        IList<Transaction> GetTransactions();

        void RemoveTransaction(Guid id);
    }
}