using Core.Domain.Entities;
using Core.Domain.Exceptions;
using Core.Domain.Responses;
using Core.Services.Abstractions;
using Infrastructure.Clients;
using Newtonsoft.Json;

namespace Core.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly IHttpClient _httpClient;

        public CharacterService(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Character>?> GetCharactersByName(string name)
        {
            var response = await _httpClient.HttpClient.GetAsync($"character/?name={name}");
            if (!response.IsSuccessStatusCode)
                throw new NotFoundException("Character with specified name was not found.");

            var content = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<CharactersByNameResponse>(content);
            return result?.Results;
        }
    }
}
