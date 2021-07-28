using Microsoft.AspNetCore.Mvc;
using Vendexpay.Core.Repository;
using Vendexpay.Core.VM;
using Vendexpay.Model;

namespace Vendexpay.API.Controllers
{
    [Route("api/Marchant")]
    [ApiController]
    public class MarchantController : BaseController<MarchantVM, Marchant>
    {

        public MarchantController(IBaseRepo<Marchant> Repo) 
        {
            base._repo = Repo;
            base.intiatService();
        }
    }
}
