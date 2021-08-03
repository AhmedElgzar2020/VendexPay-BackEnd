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
    [Route("api/Building")]
    [ApiController]
    public class BuildingController : BaseController<LookUpVM, BuildingType>
    {
        public BuildingController(IBaseRepo<BuildingType> repo)
        {
            _repo = repo;
            intiatService();
        }
    }
}
