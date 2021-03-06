using Microsoft.AspNetCore.Mvc;
using Vendexpay.Core.Repository;
using Vendexpay.Core.VM;
using Vendexpay.Model;

namespace Vendexpay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : BaseController<VendorVM,Vendor>
    {
        public VendorController(IBaseRepo<Vendor> vendorRepo)
        {
            base._repo = vendorRepo;
            base.intiatService();
        }
    }
}
