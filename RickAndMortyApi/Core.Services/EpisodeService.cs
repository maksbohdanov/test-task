using Core.Services.Abstractions;
using Infrastructure.Clients;

namespace Core.Services
{
    public class EpisodeService : IEpisodeService
    {
        private readonly IHttpClient _httpClient;

        public EpisodeService(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}
