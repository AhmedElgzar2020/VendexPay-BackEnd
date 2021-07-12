using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendexpay.Core;
using Vendexpay.Core.Service;
using Vendexpay.Core.VM;
using Vendexpay.Model;

namespace Vendexpay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : BaseController<VendorVM,Vendor>
    {
        private static IMapper _mapper;
        private static IUnitOfWork _unitOfWork;
        private static IBaseService<Vendor, VendorVM> _vendorService;

        public VendorController():base(_mapper, _unitOfWork, _vendorService)
        {

        }
    }
}
