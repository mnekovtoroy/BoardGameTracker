using BGTWebApi.Domain;
using BGTWebApi.Models.Games;

namespace BGTWebApi.Models.Plays
{
    public class PlaysMinimalVm
    {
        Guid Id { get; set; }
        DateTime Date { get; set; }
        GameMinimalVm Game { get; set; }
        List<Result> Results { get; set; }
        string? Description { get; set; }
    }
}
