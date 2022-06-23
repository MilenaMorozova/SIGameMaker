using SIGameMaker.Models;
using SIGameMaker.ViewModels.Base;

namespace SIGameMaker.ViewModels;

public class MainWindowViewModel: ViewModel
{
    public string ExampleText { get; set; } = "Example text for test"; // TODO delete it 
    public Round[] Rounds { get; set; } = new Round[]
    {
        new Round { Name = "Round 1", Themes =
        {
            new Theme() {Name = "Theme 1", Questions =
            {
                new Question() {Name = "Question 1"} ,
                new Question() {Name = "Question 2"}
            }},
            new Theme() {Name = "Theme 2", Questions =
            {
                new Question() {Name = "Question 1"} ,
                new Question() {Name = "Question 2"}
            }},
        }}, 
        new Round { Name = "Round 2", Themes =
        {
            new Theme() {Name = "Theme 1"},
            new Theme() {Name = "Theme 2", Questions =
            {
                new Question() {Name = "Question 1"} ,
                new Question() {Name = "Question 2"}
            }},
        }}, 
    };

}