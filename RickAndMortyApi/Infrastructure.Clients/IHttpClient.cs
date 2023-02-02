namespace Infrastructure.Clients
{
    public interface IHttpClient
    {
        public HttpClient HttpClient { get; set; }
        public string Url { get; set; }
        public string Token { get; set; }
    }
}
