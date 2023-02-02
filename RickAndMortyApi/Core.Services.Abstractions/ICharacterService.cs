using Core.Domain.Entities;

namespace Core.Services.Abstractions
{
    public interface ICharacterService
    {
       Task<IEnumerable<Character>?> GetCharactersByName(string name);
    }
}
