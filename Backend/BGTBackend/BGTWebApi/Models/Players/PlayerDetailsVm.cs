using BGTWebApi.Models.Games;

namespace BGTWebApi.Models.Players
{
    public class PlayerDetailsVm
    {
        string Name { get; set; }
        GameMinimalVm FavoriteGame { get; set; }
        string? Description { get; set; }
    }
}
