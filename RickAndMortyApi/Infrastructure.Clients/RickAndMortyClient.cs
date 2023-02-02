using System.Net.Http.Headers;

namespace Infrastructure.Clients
{
    public class RickAndMortyClient: IHttpClient
    {
        public HttpClient HttpClient { get; set; }
        public string Url { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;

        public RickAndMortyClient()
        {
            Url = "https://rickandmortyapi.com/api/";
            HttpClient = new HttpClient()
            {
                BaseAddress = new Uri(Url)
            };
            SetDefaultHeaders();
        }

        private void SetDefaultHeaders()
        {
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
