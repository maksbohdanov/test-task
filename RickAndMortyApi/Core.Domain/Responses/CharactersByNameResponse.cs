using Core.Domain.Entities;

namespace Core.Domain.Responses
{
    public class CharactersByNameResponse
    {
        public List<Character> Results { get; set; } = new List<Character>();
    }
}
