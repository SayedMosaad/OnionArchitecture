using Mapster;
using OA.Domain.Repositories;
using OA.Services.Abstractions;
using Shared.DTOs.Owner;

namespace OA.Services
{
    public class OwnerService : IOwnerService
    {
        private readonly IRepositoryManager _repositoryManager;

        public OwnerService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

        public async Task<IEnumerable<OwnerDTO>> GetAllOwners(CancellationToken cancellationToken = default)
        {
            var Owners = await _repositoryManager.OwnerRepository.GetAllOwners(cancellationToken);
            var OwnerDTO = Owners.Adapt<IEnumerable<OwnerDTO>>();
            return OwnerDTO;

        }

        public Task<OwnerDTO> GetOwnerById(Guid Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Insert(CreateOwnerDTO owner)
        {
            throw new NotImplementedException();
        }

        public void Remove(OwnerDTO owner)
        {
            throw new NotImplementedException();
        }
    }
}
