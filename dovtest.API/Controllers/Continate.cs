using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dovtest.REPOSITORY;
using System.Net.Http;
using System.Net.Http.Headers; 
namespace dovtest.API.Controllers
{
     [ApiController]
    [Route("[controller]")]
    public class ContinateController : ControllerBase
    {
        
         private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
      private readonly IContinateRepository _repo;
        public ContinateController(IContinateRepository repo){
            _repo= repo;
        
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var rng = await _repo.GetContinate();

            return Ok(rng);
        }
    }
}