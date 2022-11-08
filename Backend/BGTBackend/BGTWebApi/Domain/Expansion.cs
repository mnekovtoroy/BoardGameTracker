namespace BGTWebApi.Domain
{
    public class Expansion
    {
        Guid Id { get; set; }
        Guid UserId { get; set; }
        Guid GameId { get; set; }
        string Name { get; set; }
    }
}
