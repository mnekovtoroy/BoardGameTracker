namespace BGTWebApi.Domain
{
    public class Player
    {
        Guid UserId { get; set; }
        Guid Id { get; set; }
        string Name { get; set; }
        Game FavoriteGame { get; set; }
        string? Description { get; set; }
    }
}
