using AutoMapper;
using Core.Contracts.Models;
using Core.Domain.Entities;
using Core.Domain.Exceptions;
using Core.Services.Abstractions;

namespace Core.Services
{
    public class ConverterService : IConverterService
    {
        private readonly ICharacterService _characterService;
        private readonly ILocationService _locationService;
        private readonly IEpisodeService _episodeService;
        private readonly IMapper _mapper;

        public ConverterService(ICharacterService characterService, ILocationService locationService,
            IEpisodeService episodeService, IMapper mapper)
        {
            _characterService = characterService;
            _locationService = locationService;
            _episodeService = episodeService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CharacterModel>> GetCharactersByName(string name)
        {
            var characters = await _characterService.GetCharactersByName(name);
            if(characters != null  && characters.Any())
            {
                foreach (var character in characters)
                {
                    var url = character.Origin?.Url;
                    character.Origin = await GetLocationByUrl(url);
                }

                return _mapper.Map<IEnumerable<CharacterModel>>(characters);
            }
            else
                throw new NotFoundException("Character with specified name was not found.");

        }

        private async Task<Location?> GetLocationByUrl(string? url)
        {
            if (string.IsNullOrEmpty(url))
                return new Location();

            var locationId = url.Substring(url.LastIndexOf('/'));
            return await _locationService.GetLocationById(locationId);
        }
    }
}
