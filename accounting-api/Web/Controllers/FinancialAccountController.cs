using System;
using System.Web.Http;
using System.Web.Http.Cors;
using Accounting.Services.Interfaces;
using Accounting.Services.Models;
using Accounting.Web.DTO;

namespace Accounting.Web.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/financial-accounts")]
    public class FinancialAccountController : ApiController
    {
        private IFinancialAccountService Service;

        public FinancialAccountController(IFinancialAccountService service)
        {
            Service = service;
        }

        [Route("{id}")]
        [HttpGet]
        public FinancialAccountDTO Get(int id)
        {
            FinancialAccount account = Service.GetFinancialAccount(Guid.NewGuid());
            return AutoMapper.AutoMapper.GetMapper().Map<FinancialAccountDTO>(account);
        }
    }
}
