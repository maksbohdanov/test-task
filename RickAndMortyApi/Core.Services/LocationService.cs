using Core.Domain.Entities;
using Core.Domain.Exceptions;
using Core.Services.Abstractions;
using Infrastructure.Clients;
using Newtonsoft.Json;

namespace Core.Services
{
    public class LocationService : ILocationService
    {
        private readonly IHttpClient _httpClient;

        public LocationService(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Location?> GetLocationById(string locationId)
        {
            var response = await _httpClient.HttpClient.GetAsync($"location/{locationId}");
            if (!response.IsSuccessStatusCode)
                throw new NotFoundException("Location with specified id was not found.");

            var content = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Location>(content);
            return result;
        }
    }
}
