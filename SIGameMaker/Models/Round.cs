using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace SIGameMaker.Models;

public class Round
{
    public string Name { get; set; } = "";
    public List<Theme> Themes { get; set; } = new List<Theme>();
}