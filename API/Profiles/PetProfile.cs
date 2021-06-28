using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetClinic.API.Profiles
{
    public class PetProfile : Profile
    {
        public PetProfile()
        {
            CreateMap<Shared.Pet, Models.PetDto>();
        }
    }
}
