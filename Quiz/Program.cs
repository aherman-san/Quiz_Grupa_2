using Quiz;

// Powołanie do życia obiektu game - który będzie zarządzał przebiegiem gry
var game = new Game();

// Wyświetlenie komunikatu powitalnego
game.DisplayWelcomeMessage();

// Zorganizowanie wszystkich pytań w grze
game.CreateQuestionDatabase();

// TUTAJ
while(true)
{
    // Losowanie pytania z bieżącej kategorii
    game.DrawQuestionFromCurrentCategory();

    // Wyświetlanie aktualnego pytania graczowi
    game.CurrentQuestion.Display();

    // Pobranie numeru odpowiedzi od gracza
    var userNumber = Console.ReadLine();

    // Musimy zmusić gracza do wpisania 1, 2, 3 lub 4
    List<string> acceptedKeys = ["1", "2", "3", "4"];

    while (!acceptedKeys.Contains(userNumber))
    {
        Console.Clear();
        game.CurrentQuestion.Display();
        userNumber = Console.ReadLine();
    }


    // Sprawdzanie odpowiedzi gracza
    var isCorrect = game.CheckUserAnswer(userNumber);

    Console.Clear();

    if (isCorrect)
    {
        // Dobra odpowiedź
        game.GoodAnswer();
        // Sprawdzenie czy to było ostatnie pytanie
        if (game.CurrentQuestion.Category == 1000)
        {
            // Ostatnie pytanie
            // Gratulacje, ukończyłes/aś cały Quiz
            game.Success();
            break;
        }
        else
        {
            // Podniesienie kategorii na następną
            game.IncreaseCategory();
        }
    }
    else
    {
        // Zła odpowiedź
        game.FailGameOver();
        break;
        // KONIEC PROGRAMU
    }
}



 Console.ReadLine();


var warehouse = new List<Product>();
warehouse.Add(new Product { Barcode = 1, Name = "Masło Extra", Price = 5.5m });

public class Product
{
    public int Barcode { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
