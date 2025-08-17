

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The rest of your code remains unchanged.
class Program
{
    static string GetRandomWord()
    {
        string[] words = { "example", "hangman", "programming", "csharp", "console", "game", "challenge", "developer", "code", "learning" };
        Random random = new Random();
        return words[random.Next(words.Length)];
    }

    static void Main(string[] args)
    {
        string word = GetRandomWord();
        int lives = 10;
        HashSet<char> guessedLetters = new HashSet<char>();
        bool isWordGuessed = false;

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
    }
}



