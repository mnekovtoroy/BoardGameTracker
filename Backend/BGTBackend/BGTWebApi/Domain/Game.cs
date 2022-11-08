namespace BGTWebApi.Domain
{
    public class Game
    {
        Guid UserId { get; set; }
        Guid Id { get; set; }
        string Name { get; set; }
        int MinPlayers { get; set; }
        int MaxPlayers { get; set; }
        List<Expansion> Expansions { get; set; }
        string? Description { get; set; }
    }
}
