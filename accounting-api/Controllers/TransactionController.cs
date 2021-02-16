using System.Collections.Generic;
using System.Web.Http;
using Accounting.DTO;
using Accounting.Services;
using Accounting.Services.Interfaces;

namespace Accounting.Controllers
{
    [RoutePrefix("api/aaa")]
    //[RoutePrefix("api/accounting/financial-accounts/{financial_account_id}/transactions")]
    public class TransactionController : ApiController
    {
        private ITransactionService Service;

        public TransactionController(ITransactionService service) {
            Service = service;
        }

        [Route]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("{id}")]
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        //[Route]
        //[HttpPost]
        //public void Post([FromBody]TransactionDTO value)
        //{
        //    //return "sddfdsfsdfsdf";
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
