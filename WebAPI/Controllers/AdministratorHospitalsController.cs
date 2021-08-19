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
    public class AdministratorHospitalsController : ControllerBase
    {
        IAdministratorHospitalService _administratorHospitalService;

        public AdministratorHospitalsController(IAdministratorHospitalService administratorHospitalService)
        {
            _administratorHospitalService = administratorHospitalService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _administratorHospitalService.GetAll();
            return result.Success
                ? Ok(result)
                : BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(AdministratorHospital administratorHospital)
        {
            var result = _administratorHospitalService.Add(administratorHospital);
            return result.Success
                ? Ok(result)
                : BadRequest(result);
        }
        [HttpPost("hospitalIsActiveAdd")]
        public IActionResult HospitalIsActiveAdd(HospitalIsActive hospitalIsActive)
        {
            var result = _administratorHospitalService.HospitalIsActiveAdd(hospitalIsActive);
            return result.Success
                ? Ok(result)
                : BadRequest(result);
        }
        [HttpPut("hospitalIsActiveAddUpdate")]
        public IActionResult HospitalIsActiveUpdate(HospitalIsActive hospitalIsActive)
        {
            var result = _administratorHospitalService.HospitalIsActiveUpdate(hospitalIsActive);
            return result.Success
                ? Ok(result)
                : BadRequest(result);
        }
    }
}
