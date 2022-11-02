namespace BGTWebApi.Domain
{
    public class Result
    {
        Guid PlayerId { get; set; }
        Guid PlayerName { get; set; }
        int Team { get; set; } = 1;
        int Score { get; set; }
    }
}
