using System;
using System.Collections.Generic;
using Accounting.DataAccess.Repositories;
using Accounting.DataAccess.Repositories.Interfaces;
using Accounting.Services.Interfaces;
using Accounting.Services.Models;
using Accounting.Web.DTO;
using System.Linq;

namespace Accounting.Services
{
    public class TransactionService : ITransactionService
    {
        private ITransactionRepository Repository;

        public TransactionService(ITransactionRepository repository)
        {
            Repository = repository;
        }

        public Transaction CreateTransaction(Transaction transaction)
        {
            // Should have validations
            if (transaction.Type == TransactionType.Debit)
            {
                IList<Transaction> transactionsSaved = GetTransactions();
                decimal partialTotal = transactionsSaved.Sum(x => x.Type == TransactionType.Debit ? -x.Amount : x.Amount) - transaction.Amount;
                if (partialTotal < 0)
                {
                    throw new Exception("ExceedLimit");
                }
            }
            return Repository.CreateTransaction(transaction);
        }

        public Transaction GetTransaction(Guid id)
        {
            return Repository.GetTransaction(id);
        }

        public IList<Transaction> GetTransactions()
        {
            return Repository.GetTransactions();
        }

        public void RemoveTransaction(Guid id)
        {
            Repository.RemoveTransaction(id);
        }
    }
}
