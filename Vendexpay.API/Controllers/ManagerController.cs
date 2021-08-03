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
    [Route("api/Manager")]
    [ApiController]
    public class ManagerController : BaseController<ManagerVM, Manager>
    {
        public ManagerController(IBaseRepo<Manager> repo)
        {
            _repo = repo;
            intiatService();
        }
    }
}
