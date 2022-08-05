using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class FisController : ControllerBase
    {
        private IFisService fisService;

        public FisController(IFisService fisService)
        {
            this.fisService = fisService;
        }

        [HttpGet("getall")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {

            var result = fisService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int fisId)
        {
            var result = fisService.GetById(fisId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Fis fis)
        {
            var result = fisService.Add(fis);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Fis fis)
        {
            var result = fisService.Update(fis);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Fis fis)
        {
            var result = fisService.Delete(fis);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        //[HttpPost("transaction")]
        //public IActionResult TransactionTest(Product product)
        //{
        //    var result = _productService.TransactionalOperation(product);
        //    if (result.Success)
        //    {
        //        return Ok(result.Message);
        //    }

        //    return BadRequest(result.Message);
        //}

    }
}
