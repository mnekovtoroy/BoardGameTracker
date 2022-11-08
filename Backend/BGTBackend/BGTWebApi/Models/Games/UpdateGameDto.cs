namespace BGTWebApi.Models.Games
{
    public class UpdateGameDto
    {
        string Name { get; set; }
        int MinPlayers { get; set; }
        int MaxPlayers { get; set; }
        string? Description { get; set; }
    }
}
