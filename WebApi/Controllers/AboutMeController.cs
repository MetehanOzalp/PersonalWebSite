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
    public class AboutMeController : ControllerBase
    {
        IAboutMeService _aboutMeService;

        public AboutMeController(IAboutMeService aboutMeService)
        {
            _aboutMeService = aboutMeService;
        }

        [HttpPost("add")]
        public IActionResult Add(AboutMe aboutMe)
        {
            var result = _aboutMeService.Add(aboutMe);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(AboutMe aboutMe)
        {
            var result = _aboutMeService.Delete(aboutMe);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            var result = _aboutMeService.Get();
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update(AboutMe aboutMe)
        {
            var result = _aboutMeService.Update(aboutMe);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
