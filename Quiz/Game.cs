using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz;

public class Game
{
    public Game()
    {
        CurrentCategory = 100;
    }

    // Aktualna kategoria pytań, z której losujemy pytania
    public int CurrentCategory { get; set; }

    // Baza wszystkich pytań w grze
    public List<Question> QuestionDatabase { get; set; }

    // Aktualne pytanie, na które gracz odpowiada
    public Question CurrentQuestion { get; set; }


    public void DisplayWelcomeMessage()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine(" Witaj w aplikacji Quiz");
        Console.WriteLine(" Spróbuj oddpowiedzieć na 7 pytań");
        Console.WriteLine(" Powodzenia !!!");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" Naciśnij ENTER, aby zobaczyć pierwsze pytanie ... ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadLine();
        Console.Clear();
    }

    public void CreateQuestionDatabase()
    {
        // Na razie nasza lista wszystkich pytań będzie zawierała tylko dwa pytania, jedno za 100 a drugie za 200;
        QuestionDatabase = new List<Question>();
        var p1 = new Question();
        p1.Id = 1;
        p1.Category = 100;
        p1.Content = "Jaki jest kolor nieba?";
        p1.Answers.Add("niebieski");
        p1.Answers.Add("zielony");
        p1.Answers.Add("czerwony");
        p1.Answers.Add("zółty");
        QuestionDatabase.Add(p1);
        var p2 = new Question();
        p2.Id = 2;
        p2.Category = 200;
        p2.Content = "Jak miał na imię Einstein?";
        p2.Answers.Add("Albert");
        p2.Answers.Add("Zenek");
        p2.Answers.Add("Janek");
        p2.Answers.Add("Maciek");
        QuestionDatabase.Add(p2);
    }

    public void DrawQuestionFromCurrentCategory()
    {
        // Na razie losujemy pierwsze pytanie z listy
        CurrentQuestion = QuestionDatabase[0];
    }


}
