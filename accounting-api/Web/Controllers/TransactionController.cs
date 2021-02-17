using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using Accounting.Services.Interfaces;
using Accounting.Services.Models;
using Accounting.Web.DTO;

namespace Accounting.Web.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/transactions")]
    public class TransactionController : ApiController
    {
        private ITransactionService Service;

        public TransactionController(ITransactionService service) {
            Service = service;
        }

        [Route]
        [HttpPost]
        public TransactionDTO Post([FromBody]TransactionDTO TransactionDTO)
        {
            // Should capture errors
            Transaction transaction = AutoMapper.AutoMapper.GetMapper().Map<Transaction>(TransactionDTO);
            transaction = this.Service.CreateTransaction(transaction);
            return  AutoMapper.AutoMapper.GetMapper().Map<TransactionDTO>(transaction);
        }
    }
}
