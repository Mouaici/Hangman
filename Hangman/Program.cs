string word= "example";
Random random = new Random();
string[] messages = new string[10];
// messages[0] = "Welcome to Hangman!";
// messages[1] = "You have 10 lives. Good luck!";
// messages[2] = "Guess a letter: ";
// messages[3] = "Good guess!";
// messages[4] = "Wrong guess! Lives left: ";

// All values are null.
// Hangman game in C#

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




