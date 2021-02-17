using System;
using Accounting.Services.Models;

namespace Accounting.DataAccess.Repositories.Interfaces
{
    public interface IFinancialAccountRepository
    {
        FinancialAccount GetFinancialAccount();
    }
}