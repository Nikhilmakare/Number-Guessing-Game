// Use the Random class to generate a random number.
Random random = new Random();
int secretNumber = random.Next(1, 101); // A random number between 1 and 100

int guess = 0;
int guessCount = 0;

Console.WriteLine("--- Number Guessing Game ---");
Console.WriteLine("I'm thinking of a number between 1 and 100.");

// Use a 'while' loop to keep the game going until the user guesses correctly.
// The condition 'guess != secretNumber' means the loop continues as long as the guess is wrong.
while (guess != secretNumber)
{
    Console.Write("Enter your guess: ");
    string input = Console.ReadLine();

    // This safely converts the user's text input into a number.
    // If they type something that isn't a number, it won't crash.
    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("That's not a valid number. Please try again.");
        continue; // 'continue' skips the rest of the loop and starts from the top.
    }

    guessCount++; // Increment the guess counter.

    // Use if/else if/else to give hints.
    if (guess < secretNumber)
    {
        Console.WriteLine("Too low! Try again.");
    }
    else if (guess > secretNumber)
    {
        Console.WriteLine("Too high! Try again.");
    }
    else
    {
        // This part only runs if the guess is correct.
        Console.WriteLine($"Congratulations! You got it! The number was {secretNumber}.");
        Console.WriteLine($"It took you {guessCount} guesses.");
    }
}