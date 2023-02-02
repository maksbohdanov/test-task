using Core.Contracts.Models;

namespace Core.Services.Abstractions
{
    public interface IConverterService
    {
        Task<bool> CheckIfPersonIsInEpisode(PresenceRequest request);
        Task<IEnumerable<CharacterModel>> GetCharactersByName(string name);
    }
}
