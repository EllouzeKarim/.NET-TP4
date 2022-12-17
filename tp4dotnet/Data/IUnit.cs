namespace tp4dotnet.Data
{
    public interface IUnit : IDisposable
    {
        IRepositoryStudent student { get; }
        bool complete();
    }
}