using Quiz;
using System.Runtime.Intrinsics.X86;

// Powołanie do życia obiektu game - który będzie zarządzał przebiegiem gry
var game = new Game();

// Wyświetlenie komunikatu powitalnego
game.DisplayWelcomeMessage();

// Zorganizowanie wszystkich pytań w grze
game.CreateQuestionDatabase();

// Losowanie pytania z najniżej kategorii
game.DrawQuestionFromCurrentCategory();



Console.ReadLine();
