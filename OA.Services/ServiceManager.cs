using OA.Domain.Repositories;
using OA.Services.Abstractions;

namespace OA.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<OwnerService> _OwnerService;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _OwnerService = new Lazy<OwnerService>(() => new OwnerService(repositoryManager));
        }
        public IOwnerService OwnerService => _OwnerService.Value;
    }
}
