using Microsoft.AspNetCore.Mvc;
using Vendexpay.Core.Repository;
using Vendexpay.Core.VM;
using Vendexpay.Model;

namespace Vendexpay.API.Controllers
{
    [Route("api/Consumer")]
    [ApiController]
    public class ConsumerController :  BaseController<ConsumerVM, Consumer>
    {
        public ConsumerController(IBaseRepo<Consumer> Repo)
        {
            base._repo = Repo;
            base.intiatService();
        }
    }
}
