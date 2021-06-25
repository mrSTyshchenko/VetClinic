using System;
using System.Collections.Generic;
using System.Linq;
using VetClinic.Shared;

namespace VetClinic.DAL
{
    public class PetInMemoryStore : IPetStore
    {
        private static readonly List<Pet> pets = new()
        {
            new Pet { Id = 1, Name = "Tom", Kind = "Cat", Age = 3 },
            new Pet { Id = 2, Name = "Jery", Kind = "Mouse", Age = 2 }
        };

        public Pet Create(Pet pet)
        {
            pet.Id = pets.Select(p => p.Id).Max() + 1;

            pets.Add(pet);
            return pet;
        }

        public void Delete(int petId)
        {
            pets.Remove(pets.First(p => p.Id == petId));
        }

        public IEnumerable<Pet> GetPets()
        {
            return pets;
        }

        public Pet GetPet(int petId)
        {
            return pets.FirstOrDefault(p => p.Id == petId);
        }

        public Pet Update(Pet pet)
        {
            var petIndex = pets.IndexOf(pets.FirstOrDefault(p => p.Id == pet.Id));
            pets[petIndex] = pet;
            return pet;
        }
    }
}
