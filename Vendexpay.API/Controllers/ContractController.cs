using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendexpay.Core.Repository;
using Vendexpay.Core.VM;
using Vendexpay.Model;

namespace Vendexpay.API.Controllers
{
    [Route("api/Contract")]
    [ApiController]
    public class ContractController : BaseController<ContractVM, Contract>
    {
        public ContractController(IBaseRepo<Contract> repo)
        {
            _repo = repo;
            intiatService();
        }
    }
}
