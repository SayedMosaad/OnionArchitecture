using OA.Domain.Repositories;

namespace OA.Infra.Persistence.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IOwnerRepository> _OwnerRepository;
        private readonly Lazy<IUnitOFWork> _UnitOfWork;
        public RepositoryManager(ApplicationDbContext dbContext)
        {
            _OwnerRepository = new Lazy<IOwnerRepository>(() => new OwnerRepository(dbContext));
            _UnitOfWork = new Lazy<IUnitOFWork>(() => new UnitOfWork(dbContext));
        }
        public IOwnerRepository OwnerRepository => _OwnerRepository.Value;
        public IUnitOFWork unitOFWork => _UnitOfWork.Value;
    }
}
