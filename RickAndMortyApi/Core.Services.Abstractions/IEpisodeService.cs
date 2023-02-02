using Core.Domain.Entities;

namespace Core.Services.Abstractions
{
    public interface IEpisodeService
    {
        Task<Episode?> GetEpisodeByName(string name);
    }
}
