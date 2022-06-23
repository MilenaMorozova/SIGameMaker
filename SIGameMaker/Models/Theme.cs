using System;
using System.Collections.Generic;

namespace SIGameMaker.Models;

public class Theme
{
    public string Name { get; set; } = "";
    public List<Question> Questions { get; set; } = new List<Question>();
}