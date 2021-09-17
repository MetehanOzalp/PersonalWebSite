using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationsController : ControllerBase
    {
        IEducationService _educationService;

        public EducationsController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        [HttpPost("add")]
        public IActionResult Add(Education education)
        {
            var result = _educationService.Add(education);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Education education)
        {
            var result = _educationService.Delete(education);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost("getAll")]
        public IActionResult GetAll()
        {
            var result = _educationService.GetAll();
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Education education)
        {
            var result = _educationService.Update(education);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
