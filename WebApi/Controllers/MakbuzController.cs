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
    public class MakbuzController : ControllerBase
    {
        private IMakbuzService makbuzService;

        public MakbuzController(IMakbuzService makbuzService)
        {
            this.makbuzService = makbuzService;
        }

        [HttpGet("getall")] 
        public IActionResult GetList()
        {

            var result = makbuzService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int makbuzId)
        {
            var result = makbuzService.GetById(makbuzId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Makbuz makbuz)
        {
            var result = makbuzService.Add(makbuz);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Makbuz makbuz)
        {
            var result = makbuzService.Update(makbuz);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Makbuz makbuz)
        {
            var result = makbuzService.Delete(makbuz);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }

}
