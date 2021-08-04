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
    [Route("api/Document")]
    [ApiController]
    public class DocumentController : BaseController<DocumentVM, Document>
    {
        public DocumentController(IBaseRepo<Document> repo)
        {
            _repo = repo;
            intiatService();
        }
    }
}
