using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendexpay.Core.Repository;
using Vendexpay.Core.VM;
using Vendexpay.Model.LookUps;

namespace Vendexpay.API.Controllers
{
    [Route("api/CompanyType")]
    [ApiController]
    public class CompanyTypeController : BaseController<LookUpVM, CompanyType>
    {
        public CompanyTypeController(IBaseRepo<CompanyType> repo)
        {
            _repo = repo;
            intiatService();
        }
    }
}
