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
    [Route("api/MobilePayment")]
    [ApiController]
    public class MobilePaymentController : BaseController<MobilePaymentVM, MobilePayment>
    {
        public MobilePaymentController(IBaseRepo<MobilePayment> Repo)
        {
            base._repo = Repo;
            base.intiatService();
        }
    }
}
