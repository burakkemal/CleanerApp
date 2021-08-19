using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectsController : ControllerBase
    {
        IObjectService _objectService;

        public ObjectsController(IObjectService objectService)
        {
            _objectService = objectService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _objectService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add([FromForm()] Entities.Concrete.Object @object)
        {
            var result = _objectService.Add(@object);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update([FromForm()] Entities.Concrete.Object @object)
        {
            var result = _objectService.Update(@object);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
