using Core.Domain.Entities;
using Core.Domain.Exceptions;
using Core.Domain.Responses;
using Core.Services.Abstractions;
using Infrastructure.Clients;
using Newtonsoft.Json;

namespace Core.Services
{
    public class EpisodeService : IEpisodeService
    {
        private readonly IHttpClient _httpClient;

        public EpisodeService(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Episode?> GetEpisodeByName(string name)
        {
            var response = await _httpClient.HttpClient.GetAsync($"episode/?name={name}");
            if (!response.IsSuccessStatusCode)
                throw new NotFoundException("Episode with specified name was not found.");

            var content = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<EpisodesByNameResponse>(content);
            return result?.Results.FirstOrDefault();
        }
    }
}
