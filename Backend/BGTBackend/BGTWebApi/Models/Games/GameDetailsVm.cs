using BGTWebApi.Domain;

namespace BGTWebApi.Models.Games
{
    public class GameDetailsVm
    {
        string Name { get; set; }
        int MinPlayers { get; set; }
        int MaxPlayers { get; set; }
        List<Extention> Extentions { get; set; }
        string? Description { get; set; }
    }
}
