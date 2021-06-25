using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Shared;

namespace VetClinic.DAL
{
    public interface IPetStore
    {
        public IEnumerable<Pet> GetPets();
        public Pet GetPet(int petId);
        public Pet Create(Pet pet);
        public Pet Update(Pet pet);
        public void Delete(int petId);
    }
}
