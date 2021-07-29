using Microsoft.AspNetCore.Mvc;
using Vendexpay.Core.Repository;
using Vendexpay.Core.VM;
using Vendexpay.Model;

namespace Vendexpay.API.Controllers
{
    [Route("api/Partener")]
    [ApiController]
    public class PartenerController : BaseController<PartenerVM, Partener>
    {
        public PartenerController(IBaseRepo<Partener> Repo)
        {
            
                base._repo = Repo;
            base.intiatService();
        }
    }
}
