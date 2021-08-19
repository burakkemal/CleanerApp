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
    public class AdministratorsController : ControllerBase
    {
        IAdministratorService _administratorService;

        public AdministratorsController(IAdministratorService administratorService)
        {
            _administratorService = administratorService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _administratorService.GetAll();
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Administrator administrator)
        {
            var result = _administratorService.Add(administrator);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(Administrator administrator)
        {
            var result = _administratorService.Update(administrator);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpPost("UserIsActiveAdd")]
        public IActionResult UserIsActiveAdd(UserIsActive userIsActive)
        {
            var result = _administratorService.UserIsActiveAdd(userIsActive);
            return result.Success ? Ok(result) : BadRequest(result);

        }
    }
}
