using System;
using System.Collections.Generic;

namespace SIGameMaker.Models;

public enum QuestionType
{
    Ordinary,
    WithSecret,
    // TODO add more types
};

public class Question
{
    public string Name { get; set; } = "";
    public int Price { get; set; } = 0;
    public QuestionType Type { get; set; } = QuestionType.Ordinary;
    public List<string> Answers { get; set; } = new List<string>();
    public List<string> WrongAnswers { get; set; } = new List<string>();
    public string Comment { get; set; } = "";
    // TODO add steps
}