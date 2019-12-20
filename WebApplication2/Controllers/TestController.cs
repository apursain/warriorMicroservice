using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Model;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestRepository testRepository;
        public TestController(ITestRepository tRepository)
        {
            testRepository = tRepository;
        }


        // GET: api/Test
        [HttpGet]
        public IActionResult Get()
        {
            var lstTest = testRepository.GetTests();
            return new OkObjectResult(lstTest);
        }

        // GET: api/Test/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var lstTest = testRepository.GetTestById(id);
            return new OkObjectResult(lstTest);
        }

        [HttpPost("getuserinfo")]
       
        public IActionResult GetUser(int i)
        {
            int p = 0;
            return Ok(p);
        }

            //// POST: api/Test
            //[HttpPost]
            //public void Post([FromBody] string value)
            //{
            //}

            //// PUT: api/Test/5
            //[HttpPut("{id}")]
            //public void Put(int id, [FromBody] string value)
            //{
            //}

            //// DELETE: api/ApiWithActions/5
            //[HttpDelete("{id}")]
            //public void Delete(int id)
            //{
            //}
        }
}
