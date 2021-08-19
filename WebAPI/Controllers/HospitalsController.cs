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
    public class HospitalsController : ControllerBase
    {
        IHospitalService _hospitalService;

        public HospitalsController(IHospitalService hospitalService)
        {
            _hospitalService = hospitalService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _hospitalService.GetAll();
            return result.Success
                ? Ok(result)
                : BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Hospital hospital)
        {
            var result = _hospitalService.Add(hospital);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Hospital hospital)
        {
            var result = _hospitalService.Update(hospital);
            return result.Success
                ? Ok(result)
                : BadRequest(result);
        }
    }
}
