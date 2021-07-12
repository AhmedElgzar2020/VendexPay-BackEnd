using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendexpay.Core;
using Vendexpay.Core.Repository;
using Vendexpay.Core.Service;
using Vendexpay.Core.VM;
using Vendexpay.Model;

namespace Vendexpay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TVM,T> : ControllerBase where TVM : BaseVM where T:BaseEntity
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseService<T,TVM> _baseService;

        public BaseController(IMapper mapper, IUnitOfWork unitOfWork, IBaseService<T, TVM> baseService)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _baseService = baseService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_baseService.GetAll());
            }
            catch
            {
                return Problem("Error");
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_baseService.Get(id));
            }
            catch
            {
                return Problem("Error");
            }
        }


        [HttpPost]
        public IActionResult Post([FromBody] TVM Model)
        {
            try
            {
                _baseService.Add(Model);
                return Ok("Success");
            }
            catch
            {
                return Problem("Error");
            }
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TVM Model)
        {
            try
            {
                _baseService.Update(id,Model);
                return Ok("Success");
            }
            catch
            {
                return Problem("Error");
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _baseService.Delete(id);
                return Ok("Success");
            }
            catch
            {
                return Problem("Error");
            }
        }
    }
}
