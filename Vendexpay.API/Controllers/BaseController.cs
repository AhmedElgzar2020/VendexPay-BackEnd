using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Vendexpay.Core;
using Vendexpay.Core.Repository;
using Vendexpay.Core.Service;
using Vendexpay.Core.VM;
using Vendexpay.Infrastructure.Repository;
using Vendexpay.Model;
using Vendexpay.Service;

namespace Vendexpay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TVM, T> : Controller where TVM : BaseVM where T : BaseEntity
    {
        private IMapper _mapper;
        private IBaseService<T, TVM> _baseService;
        protected IBaseRepo<T> _repo;

        public BaseController()
        {

        }

        protected void intiatService()
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<TVM, T>(); cfg.CreateMap<T, TVM>(); });
            _mapper = config.CreateMapper();
            _baseService = new BaseService<T, TVM>(_mapper, _repo);
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_baseService.GetAll());
            }
            catch (Exception e)
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
            catch (Exception ex)
            {
                return Problem("Error");
            }
        }

        [HttpPost]
        [Route("AddRange")]
        public IActionResult Post([FromBody] List<TVM> Model)
        {
            try
            {
                _baseService.AddRange(Model);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return Problem("Error");
            }
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TVM Model)
        {
            try
            {
                _baseService.Update(id, Model);
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

        [HttpPost, DisableRequestSizeLimit]
        [Route("Upload")]
        public IActionResult Upload()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("Resources", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}
