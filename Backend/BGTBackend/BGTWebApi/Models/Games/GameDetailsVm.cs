using BGTWebApi.Domain;

namespace BGTWebApi.Models.Games
{
    public class GameDetailsVm
    {
        string Name { get; set; }
        int MinPlayers { get; set; }
        int MaxPlayers { get; set; }
        List<Expansion> Expansions { get; set; }
        string? Description { get; set; }
    }
}
