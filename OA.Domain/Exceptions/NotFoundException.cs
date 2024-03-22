namespace OA.Domain.Exceptions
{
    public abstract class NotFoundException : Exception
    {
        protected NotFoundException(string Message) : base(Message) { }


    }
}
