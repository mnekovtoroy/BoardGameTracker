﻿using BGTWebApi.Domain;

namespace BGTWebApi.Models.Plays
{
    public class CreatePlayDto
    {
        DateTime Date { get; set; }
        Guid Game { get; set; }
        List<Expansion> Expansions { get; set; }
        List<Result> Results { get; set; }
        string? Description { get; set; }
    }
}
