using OA.Domain.Repositories;

namespace OA.Infra.Persistence.Repositories
{
    public class UnitOfWork : IUnitOFWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
