namespace BGTWebApi.Models.Players
{
    public class UpdatePlayerDto
    {
        Guid Id { get; set; }
        string Name { get; set; }
        Guid? FavoriteGame { get; set; }
        string? Description { get; set; }
    }
}
