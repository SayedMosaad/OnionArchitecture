using OA.Domain.Entities;

namespace OA.Domain.Repositories
{
    public interface IOwnerRepository
    {
        Task<IEnumerable<Owner>> GetAllOwners(CancellationToken cancellationToken = default);
        Task<Owner> GetOwnerById(Guid Id, CancellationToken cancellationToken = default);
        void Insert(Owner owner);
        void Remove(Owner owner);
    }
}
