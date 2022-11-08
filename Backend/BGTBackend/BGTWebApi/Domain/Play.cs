namespace BGTWebApi.Domain
{
    public class Play
    {
        Guid UserId { get; set; }
        Guid Id { get; set; }
        DateTime Date { get; set; }
        Game Game { get; set; }
        List<Expansion> Expansions { get; set; }
        List<Result> Results { get; set; }
        string? Description { get; set; }

    }
}
