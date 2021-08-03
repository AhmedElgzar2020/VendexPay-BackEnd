using Microsoft.AspNetCore.Mvc;
using Vendexpay.Core.Repository;
using Vendexpay.Core.VM;
using Vendexpay.Model;

namespace Vendexpay.API.Controllers
{
    [Route("api/Office")]
    [ApiController]
    public class OfficeController : BaseController<OfficeVM, Office>
    {
        public OfficeController(IBaseRepo<Office> repo)
        {
            _repo = repo;
            intiatService();
        }
    }
}
