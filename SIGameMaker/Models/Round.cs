using System;

namespace SIGameMaker.Models;

public class Round
{
    public string Name { get; set; } = "";
    public Theme[] Themes { get; set; } = Array.Empty<Theme>();
}