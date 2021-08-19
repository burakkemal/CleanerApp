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
    public class CleanersController : ControllerBase
    {
        ICleanerService _cleanerService;
        IHospitalIsActiveService hospitalIsActive;
        public CleanersController(ICleanerService cleanerService)
        {
            _cleanerService = cleanerService;
        }

        
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _cleanerService.GetAll();
            return result.Success
                ? Ok(result)
                : BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Cleaner cleaner)
        {
            var result = _cleanerService.Add(cleaner);
            return result.Success 
                ? Ok(result) 
                : BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(Cleaner cleaner)
        {
            var result = _cleanerService.Update(cleaner);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
