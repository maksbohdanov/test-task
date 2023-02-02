using AutoMapper;
using Core.Contracts.Models;
using Core.Domain.Entities;

namespace Core.Contracts.Mapping
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Location, LocationModel>();

            CreateMap<Character, CharacterModel>();
        }
    }
}
