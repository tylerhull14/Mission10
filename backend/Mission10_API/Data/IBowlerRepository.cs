namespace Mission10_API.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
    }
}
