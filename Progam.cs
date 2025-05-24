using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Guess a number between 1-10");
        Random random = new Random();
        int result = random.Next(1,11);
        int x = Convert.ToInt32(Console.ReadLine());
        int lives = 3;
        int tries = 1;
        while(x!=result)
        {
            Console.WriteLine("Try again");
            x = Convert.ToInt32(Console.ReadLine());
            if (x > result)
            {
                lives -= 1;
                tries++;
                Console.WriteLine("Wrong, too high");
                Console.WriteLine("Left tries: " + lives );
                if (lives == 0)
                {
                    Console.WriteLine("Game over");
                    Console.WriteLine("Number was: " + x);
                    break;
                }
            }
            else if(x < result)
            {
                lives -= 1;
                tries++;
                Console.WriteLine("Wrong, to low");
                Console.WriteLine("Left tries: " + lives);
                if (lives == 0)
                {
                    Console.WriteLine("Game over");
                    Console.WriteLine( "Number was: " + x);
                    break;
                }
            }
            else
            {
                Console.WriteLine("Congrats, you guessed!");
                Console.WriteLine("You did it in: " + tries);
            }
        }
    }
}
