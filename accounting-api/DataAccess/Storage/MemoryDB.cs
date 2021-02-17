using System;
using System.Collections.Generic;
using System.Linq;
using Accounting.Services.Models;

namespace Accounting.DataAccess.Storage
{
    public class MemoryDB
    {
        private static MemoryDB instance;

        public static MemoryDB Instance {
            get {
                if (instance == null)
                {
                    instance = new MemoryDB();
                }

                return instance;
            }
            set { instance = value; }
        }

        private MemoryDB() {
            Transactions = new List<Transaction>();

            FinancialAccount = new FinancialAccount()
            {
                Id = Guid.NewGuid(),
                Name = "Ana Account"
            };

        }

        private FinancialAccount FinancialAccount;
        private IList<Transaction> Transactions;

        public Transaction AddTransaction(Transaction transaction)
        {
            transaction.Id = Guid.NewGuid();
            transaction.FinancialAccountId = FinancialAccount.Id;
            Transactions.Add(transaction);

            return transaction;
        }

        public Transaction GetTransaction(Guid id)
        {
            return Transactions.FirstOrDefault(x => x.Id == id);
        }

        public void RemoveTransaction(Guid id) {
            Transactions.Remove(GetTransaction(id));
        }

        public IList<Transaction> GetTransactions()
        {
            return Transactions.ToList();
        }

        public FinancialAccount GetFinancialAccount()
        {
            return FinancialAccount;
        }
    }
}