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
    [Route("api/Country")]
    [ApiController]
    public class CountryController : BaseController<LookUpVM, Country>
    {
        public CountryController(IBaseRepo<Country> repo)
        {
            _repo = repo;
            intiatService();
        }
    }
}
