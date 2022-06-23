using System;

namespace SIGameMaker.Models;

public class Theme
{
    public string Name { get; set; } = "";
    public Question[] Questions { get; set; } = Array.Empty<Question>();
}