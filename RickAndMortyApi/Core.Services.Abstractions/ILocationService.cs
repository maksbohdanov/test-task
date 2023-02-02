using Core.Domain.Entities;

namespace Core.Services.Abstractions
{
    public interface ILocationService
    {
        Task<Location?> GetLocationById(string locationId);
    }
}
