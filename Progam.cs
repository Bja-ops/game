using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose difficulty: ");
        Console.WriteLine("1. Easy");
        Console.WriteLine("2. Medium");
        Console.WriteLine("3. Hard");
        Console.WriteLine("4. Extreme");
        string choice = Console.ReadLine();

        Random random = new Random();
        int numberToGuess = 0;

        // Wybór poziomu trudności
        switch (choice)
        {
            case "1":
                Console.WriteLine("Guess a number between 1 and 10");
                numberToGuess = random.Next(1, 11);
                break;
            case "2":
                Console.WriteLine("Guess a number between 1 and 50");
                numberToGuess = random.Next(1, 51);
                break;
            case "3":
                Console.WriteLine("Guess a number between 1 and 100");
                numberToGuess = random.Next(1, 101);
                break;
            case "4":
                Console.WriteLine("Guess a number between 1 and 500");
                numberToGuess = random.Next(1, 501);
                break;
            default:
                Console.WriteLine("Invalid choice. Defaulting to Easy (1-10)");
                numberToGuess = random.Next(1, 11);
                break;
        }

        int guess;
        int attempts = 0;

        do
        {
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess > numberToGuess)
            {
                Console.WriteLine("Too high. Try again:");
            }
            else if (guess < numberToGuess)
            {
                Console.WriteLine("Too low. Try again:");
            }
        }
        while (guess != numberToGuess);

        Console.WriteLine("Congratulations! You guessed the number in tries:" + attempts);
    }
}
