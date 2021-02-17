using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Accounting.Services.Models;

namespace Accounting.Services.Interfaces
{
    public interface IFinancialAccountService
    {
        FinancialAccount GetFinancialAccount(Guid id);
    }
}