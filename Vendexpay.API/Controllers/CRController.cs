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
    [Route("api/CR")]
    [ApiController]
    public class CRController : BaseController<CRVM, CR>
    {
        public CRController(IBaseRepo<CR> repo)
        {
            _repo = repo;
            intiatService();
        }
    }
}
