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
    [Route("api/Contact")]
    [ApiController]
    public class ContactController : BaseController<ContactVM, Contact>
    {
        public ContactController(IBaseRepo<Contact> repo)
        {
            _repo = repo;
            intiatService();
        }
    }
}
