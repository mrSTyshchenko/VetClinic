using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetClinic.Shared;
using Microsoft.Extensions.Logging;

namespace VetClinic.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetController : Controller
    {
        private readonly ILogger<PetController> logger;

        public PetController(ILogger<PetController> logger)
        {
            this.logger = logger;
        }            

        [HttpGet]
        public IEnumerable<Pet> Get()
        {
            return new List<Pet> 
            { 
                new Pet { Name = "Tom", Kind = "Cat", Age = 3 },
                new Pet { Name = "Jery", Kind = "Mouse", Age = 2 } 
            };
        }
    }
}
