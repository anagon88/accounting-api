using System;
using System.Web.Http;
using Accounting.DataAccess.Repositories;
using Accounting.DataAccess.Repositories.Interfaces;
using Accounting.Services.Interfaces;
using Accounting.Services.Models;
using System.Linq;

namespace Accounting.Services
{
    public class FinancialAccountService : IFinancialAccountService
    {
        private IFinancialAccountRepository Repository;

        public FinancialAccountService(IFinancialAccountRepository repository)
        {
            Repository = repository;
        }

        public FinancialAccount GetFinancialAccount(Guid id)
        {
            // Should filter by Id, but I have only 1 right now
            FinancialAccount account = Repository.GetFinancialAccount();
            return Repository.GetFinancialAccount();
        }
    }
}
