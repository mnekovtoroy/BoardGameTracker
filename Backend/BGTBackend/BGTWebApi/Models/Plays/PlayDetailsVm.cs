﻿using BGTWebApi.Domain;

namespace BGTWebApi.Models.Plays
{
    public class PlayDetailsVm
    {
        DateTime Date { get; set; }
        Guid Game { get; set; }
        List<Extention> Extentions { get; set; }
        List<Result> Results { get; set; }
        string? Description { get; set; }
    }
}
