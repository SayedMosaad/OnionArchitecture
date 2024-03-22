namespace OA.Domain.Exceptions
{
    public sealed class OwnerNotFoundException : NotFoundException
    {
        public OwnerNotFoundException(Guid OwnerId) : base($"The Owner with the Identifier {OwnerId} was not found")
        {
        }
    }
}
