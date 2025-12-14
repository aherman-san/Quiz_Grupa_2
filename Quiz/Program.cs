using Quiz;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

// Powołanie do życia obiektu game - który będzie zarządzał przebiegiem gry
var game = new Game();

// Wyświetlenie komunikatu powitalnego
game.DisplayWelcomeMessage();

// Zorganizowanie wszystkich pytań w grze
game.CreateQuestionDatabase();

// Losowanie pytania z najniżej kategorii
game.DrawQuestionFromCurrentCategory();

// Wyświetlanie aktualnego pytania graczowi
game.CurrentQuestion.Display();

// Pobranie numeru odpowiedzi od gracza
var userNumber = Console.ReadLine();

// Sprawdzanie odpowiedzi gracza
var isCorrect = game.CheckUserAnswer(userNumber);

Console.Clear();

if (isCorrect)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(" Brawo, to jest jest poprawna odpowiedź");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" Ups, to niesety nie jest prawidłowa opowiedź ...");
    Console.WriteLine(" KONIEC GRY");
}





    Console.ReadLine();