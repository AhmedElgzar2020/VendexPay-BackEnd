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
    [Route("api/[controller]")]
    [ApiController]
    public class POSController : BaseController<POSVM,POS>
    {
        public POSController(IBaseRepo<POS> Repo)
        {
            base._repo = Repo;
            base.intiatService();
        }
    }
}
