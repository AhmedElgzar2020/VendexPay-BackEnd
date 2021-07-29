using Microsoft.AspNetCore.Mvc;
using Vendexpay.Core.Repository;
using Vendexpay.Core.VM;
using Vendexpay.Model;

namespace Vendexpay.API.Controllers
{
    [Route("api/Campaign")]
    [ApiController]
    public class CampaignController : BaseController<CampaignVM,Campaign>
    {
        public CampaignController(IBaseRepo<Campaign> Repo)
        {
            base._repo = Repo;
            base.intiatService();
        }
    }
}
