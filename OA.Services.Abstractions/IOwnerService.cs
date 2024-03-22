using Shared.DTOs.Owner;

namespace OA.Services.Abstractions
{
    public interface IOwnerService
    {
        Task<IEnumerable<OwnerDTO>> GetAllOwners(CancellationToken cancellationToken = default);
        Task<OwnerDTO> GetOwnerById(Guid Id, CancellationToken cancellationToken = default);
        void Insert(CreateOwnerDTO owner);
        void Remove(OwnerDTO owner);
    }
}
