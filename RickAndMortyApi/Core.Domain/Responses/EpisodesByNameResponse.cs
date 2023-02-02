using Core.Domain.Entities;

namespace Core.Domain.Responses
{
    public class EpisodesByNameResponse
    {
        public List<Episode> Results { get; set; } = new List<Episode>();
    }
}
