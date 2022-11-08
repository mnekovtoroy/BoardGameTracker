namespace BGTWebApi.Models.Games
{
    public class CreateGameDto
    {
        string Name { get; set; }
        int MinPlayers { get; set; }
        int MaxPlayers { get; set; }
        string? Description { get; set; }
    }
}
