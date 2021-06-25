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
    [Route("api/pets")]
    public class PetController : ControllerBase
    {        
        private readonly IPetStore petStore;

        public PetController(IPetStore petStore)
        {
            this.petStore = petStore;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(petStore.GetPets());
        }

        [HttpGet("{petId:int}")]
        public IActionResult Get(int petId)
        {
            var pet = petStore.GetPet(petId);

            if (pet == null)
            {
                return NotFound();
            }

            return Ok(pet);
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
