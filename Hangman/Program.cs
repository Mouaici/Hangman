string word = "example";

int maxLives = 10;
int lives = maxLives;
List<char> guessedLetters = new List<char>();
bool isWordGuessed = false;
Console.WriteLine("Welcome to Hangman!");
foreach (char c in word)
    {
    Console.Write(c == ' ' ? "  " : "_ ");
}
Console.WriteLine("\nYou have " + lives + " lives. Good luck!");
while (lives > 0 && !isWordGuessed)
{
    Console.Write("\nGuess a letter: ");
    char guess = Console.ReadKey().KeyChar;
    Console.WriteLine();
    if (guessedLetters.Contains(guess))
    {
        Console.WriteLine("You already guessed that letter. Try again.");
        continue;
    }
    guessedLetters.Add(guess);
    
    if (word.Contains(guess))
    {
        Console.WriteLine("Good guess!");
    }
    else
    {
        lives--;
        Console.WriteLine("Wrong guess! Lives left: " + lives);
    }
    isWordGuessed = true;
    foreach (char c in word)
    {
        if (guessedLetters.Contains(c) || c == ' ')
        {
            Console.Write(c + " ");
        }
        else
        {
            Console.Write("_ ");
            isWordGuessed = false;
        }
    }
    if (isWordGuessed)
    {
        Console.WriteLine("\nCongratulations! You've guessed the word: " + word);
    }
    else if (lives == 0)
    {
        Console.WriteLine("\nGame over! The word was: " + word);
    }
    Console.WriteLine();
    Console.WriteLine("Guessed letters: " + string.Join(", ", guessedLetters));
    Console.WriteLine("Lives remaining: " + lives);
    Console.WriteLine("Current word: " + string.Join(" ", word.Select(c => guessedLetters.Contains(c) || c == ' ' ? c.ToString() : "_")));

    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();





}
// End of the Hangman game code
// This code implements a simple console-based Hangman game in C#.
// It allows the user to guess letters of a predefined word, tracks lives, and displays the current state of the word.
// The game continues until the user either guesses the word or runs out of lives.
// The code uses basic C# constructs such as loops, conditionals, and collections to manage the game state.
// The game is designed to be simple and educational, demonstrating basic programming concepts in C#.
// The code is structured to be easy to read and understand, making it suitable for beginners learning C#.
// The game can be extended with additional features such as a word list, difficulty levels, or a graphical interface.



