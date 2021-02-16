using System;
using System.Collections.Generic;
using Accounting.DTO;
using Accounting.Models;
using AutoMapper;

namespace Accounting.AutoMapper
{
    /// <summary>
    /// Mapping between DTOs and Entities.
    /// </summary>
    public static class AutoMapper
    {
        /// <summary>
        /// Gets a new instance of configured Mapper.
        /// </summary>
        /// <returns>the IMapper instance</returns>
        public static IMapper GetMapper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Transaction, TransactionDTO>()
                    .ReverseMap();
                cfg.CreateMap<FinancialAccount, FinancialAccountDTO>()
                    .ReverseMap();
            });
            return config.CreateMapper();
        }
    }
}