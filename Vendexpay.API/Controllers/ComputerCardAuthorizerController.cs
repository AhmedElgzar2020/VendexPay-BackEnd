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
    [Route("api/ComputerCardAuthorizer")]
    [ApiController]
    public class ComputerCardAuthorizerController : BaseController<ComputerCardAuthorizerVM, ComputerCardAuthorizer>
    {
        public ComputerCardAuthorizerController(IBaseRepo<ComputerCardAuthorizer> repo)
        {
            _repo = repo;
            intiatService();
        }
    }
}
