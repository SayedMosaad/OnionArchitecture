namespace OA.Domain.Repositories
{
    public interface IUnitOFWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
