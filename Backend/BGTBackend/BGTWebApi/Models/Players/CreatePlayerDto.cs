namespace BGTWebApi.Models.Players
{
    public class CreatePlayerDto
    {
        string Name { get; set; }
        Guid FavoriteGame { get; set; }
        string? Description { get; set; }
    }
}
