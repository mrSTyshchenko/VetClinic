using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetClinic.Shared;
using VetClinic.DAL;
using Microsoft.Extensions.Logging;

namespace VetClinic.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetController : ControllerBase
    {
        private readonly ILogger<PetController> logger;
        private readonly IPetStore petStore;

        public PetController(ILogger<PetController> logger, IPetStore petStore)
        {
            this.logger = logger;
            this.petStore = petStore;
        }

        [HttpGet]
        public IEnumerable<Pet> Get()
        {
            return petStore.GetPets();            
        }

        [HttpPost]
        public Pet Create(Pet pet)
        {
            return petStore.Create(pet);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            petStore.Delete(id);
        }

        [HttpPatch]
        public Pet Update(Pet pet)
        {
           return petStore.Update(pet);
        }
    }
}
