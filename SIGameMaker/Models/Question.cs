using System;

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
    public string[] Answers { get; set; } = Array.Empty<string>();
    public string[] WrongAnswers { get; set; } = Array.Empty<string>();
    public string Comment { get; set; } = "";
    // TODO add steps
}