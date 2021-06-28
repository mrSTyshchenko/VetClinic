using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetClinic.Shared;
using VetClinic.DAL;
using Microsoft.Extensions.Logging;
using AutoMapper;

namespace VetClinic.API.Controllers
{
    [ApiController]
    [Route("api/pets")]
    public class PetController : ControllerBase
    {        
        private readonly IPetStore petStore;
        private readonly IMapper mapper;

        public PetController(IPetStore petStore, IMapper mapper)
        {
            this.mapper = mapper;
            this.petStore = petStore;
        }

        [HttpGet()]
        public ActionResult<Models.PetDto> Get()
        {
            var pets = petStore.GetPets();

            return Ok(mapper.Map<IEnumerable<Models.PetDto>>(pets));
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
