using Core.Contracts.Models;

namespace Core.Services.Abstractions
{
    public interface IConverterService
    {
        //
        Task<IEnumerable<CharacterModel>> GetCharactersByName(string name);
    }
}
