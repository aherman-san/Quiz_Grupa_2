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
        var a1 = new Answer();
        a1.Id = 1;
        a1.Content = "niebieski";
        a1.IsCorrect = true;
        p1.Answers.Add(a1);

        var a2 = new Answer();
        a2.Id = 2;
        a2.Content = "zielony";
        p1.Answers.Add(a2);

        var a3 = new Answer();
        a3.Id = 3;
        a3.Content = "czerwony";
        p1.Answers.Add(a3);

        var a4 = new Answer();
        a4.Id = 4;
        a4.Content = "zółty";
        p1.Answers.Add(a4);


        QuestionDatabase.Add(p1);
        //var p2 = new Question();
        //p2.Id = 2;
        //p2.Category = 200;
        //p2.Content = "Jak miał na imię Einstein?";
        //p2.Answers.Add("Albert");
        //p2.Answers.Add("Zenek");
        //p2.Answers.Add("Janek");
        //p2.Answers.Add("Maciek");
        //QuestionDatabase.Add(p2);
    }

    public void DrawQuestionFromCurrentCategory()
    {
        // Na razie losujemy pierwsze pytanie z listy
        CurrentQuestion = QuestionDatabase[0];
    }

    public bool CheckUserAnswer(string userNumber)
    {
        //// logika w której na podstawie numeru gracza, ustalamy czy odpowiedź jest poprawna lub nie
        //foreach (var answer in CurrentQuestion.Answers)
        //{       
        //    // musimy zamienić odpowiedź gracza na integer
        //    var userNumberAsInteger = int.Parse(userNumber);
        //    // nas interesuje ta sytuacja:
        //    if (userNumberAsInteger == answer.Id)
        //    {
        //        return answer.IsCorrect;
        //    }
        //}

        //return false;

        return CurrentQuestion.Answers.First(x => x.Id == int.Parse(userNumber)).IsCorrect;


    }
}
