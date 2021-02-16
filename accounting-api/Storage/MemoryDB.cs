using System.Collections.Generic;
using Accounting.Models;

namespace Accounting.Storage
{
    public class MemoryDB
    {
        public static MemoryDB Instance {
            get {
                if (Instance == null)
                {
                    Instance = new MemoryDB();
                }

                return Instance;
            }
            set { Instance = value; }
        }

        private MemoryDB() { }

        private IList<FinancialAccount> FinancialAccounts;
        private IList<Transaction> Transactions;
    }
}