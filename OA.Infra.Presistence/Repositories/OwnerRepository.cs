using Microsoft.EntityFrameworkCore;
using OA.Domain.Entities;
using OA.Domain.Repositories;

namespace OA.Infra.Persistence.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly ApplicationDbContext _db;

        public OwnerRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Owner>> GetAllOwners(CancellationToken cancellationToken = default)
        {
            return await _db.Owners.ToListAsync(cancellationToken);
        }

        public async Task<Owner> GetOwnerById(Guid Id, CancellationToken cancellationToken = default)
        {
            return await _db.Owners.FirstOrDefaultAsync(x => x.Id == Id, cancellationToken);
        }

        public void Insert(Owner owner) => _db.Add(owner);

        public void Remove(Owner owner) => _db.Remove(owner);

    }
}
