using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationObjectsController : ControllerBase
    {
        ILocationObjectService _locationObjectService;

        public LocationObjectsController(ILocationObjectService locationObjectService)
        {
            _locationObjectService = locationObjectService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _locationObjectService.GetAll();
            return result.Success
                 ? Ok(result)
                 : BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add([FromForm()] LocationObject locationObject)
        {
            var result = _locationObjectService.Add(locationObject);
            return result.Success 
                ? Ok(result) 
                : BadRequest(result);
        }

    }
}
