﻿using System;
using System.Collections.Generic;
using Accounting.Services.Models;
using Accounting.Web.DTO;

namespace Accounting.Services.Interfaces
{
    public interface ITransactionService
    {
        Transaction CreateTransaction(Transaction transaction);

        Transaction GetTransaction(Guid id);

        IList<Transaction> GetTransactions();

        void RemoveTransaction(Guid id);
    }
}