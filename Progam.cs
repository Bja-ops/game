using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose difficulty: ");
        Console.WriteLine("1.Easy");
        Console.WriteLine("2.Normal");
        Console.WriteLine("3.Hard");
        Console.WriteLine("4.Extreme");
        string choice = Console.ReadLine();
        switch(choice)
        {
            case "1":
                Console.WriteLine("Choose number between 1-10");
                Random random = new Random();
                int lives = 3;
                int tries = 0;
                int x = random.Next(1,11);
                int a = Convert.ToInt32(Console.ReadLine());
                while(x!=a)
                {
                    Console.WriteLine("Try again");
                    if(a>x)
                    {
                        tries = tries + 1;
                        Console.WriteLine("Too high");
                        lives = lives - 1;
                        Console.WriteLine("Left tries: " + lives);
                        if(lives == 0)
                        {
                            Console.WriteLine("Game over");
                            Console.WriteLine("Number was: " + x);
                            break;
                        }
                    }
                    else if(a < 0)
                    {
                        tries = tries + 1;
                        Console.WriteLine("Too low");
                        lives = lives - 1;
                        Console.WriteLine("Left tries: " + lives);
                        if(lives == 0)
                        {
                            Console.WriteLine("Game over");
                            Console.WriteLine("Number was: " + x);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Congratulations, you guessed");
                        Console.WriteLine("Tries: " + tries);
                        break;
                    }
                }
                break;
            case "2":
                Random random2 = new Random();
                Console.WriteLine("Choose numbers between 1-50");
                int lives2 = 5;
                int tries2 = 0;
                int y = random2.Next(1,51);
                int b = Convert.ToInt32(Console.ReadLine());
                while(y!=b)
                {
                    Console.WriteLine("Try again");
                    if (b>y)
                    {
                        tries2 = tries2 + 1;
                        Console.WriteLine("Too high");
                        lives2 = lives2 - 1;
                        Console.WriteLine("Left tries: " + lives2);
                        if (lives2 == 0)
                        {
                            Console.WriteLine("Game over");
                            Console.WriteLine("Number was: " + y);
                            break;
                        }
                    }
                    else if (b < y)
                    {
                        tries2 = tries2 + 1;
                        Console.WriteLine("Too low");
                        lives2 = lives2 - 1;
                        Console.WriteLine("Left tries: " + lives2);
                        if (lives2 == 0)
                        {
                            Console.WriteLine("Game over");
                            Console.WriteLine("Number was: " + y);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Congratulations, you guessed");
                        Console.WriteLine("Tries:" + tries2);
                        break;
                    }
                }
                break;
            case "3":
                Random random3 = new Random();
                int lives3 = 10;
                int tries3 = 0;
                Console.WriteLine("Chose numbers between 1-100");
                int z = random3.Next(1,101);
                int c = Convert.ToInt32(Console.ReadLine());
                while(c!=z)
                {
                    Console.WriteLine("Try again");
                    if(c>z)
                    {
                        lives3 = lives3 - 1;
                        tries3 = tries3 + 1;
                        Console.WriteLine("Too hight");
                        Console.WriteLine("Left tries: " + tries3);
                        if (lives3 == 0)
                        {
                            Console.WriteLine("Number was: " + z);
                            break;
                        }
                    }
                    else if(c<z)
                    {
                        tries3 = tries3 + 1;
                        lives3 = lives3 - 1;
                        Console.WriteLine("Too low");
                        Console.WriteLine("Left tries: " + lives3);
                        if (lives3 == 0)
                        {
                            Console.WriteLine("Number was: " + z );
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Congratulations, you guessed");
                        Console.WriteLine("Tries: " + tries3);
                        break;
                    }
                }
                break;
            case "4":
                Console.WriteLine("Chose number between 1-1000");
                Random random4 = new Random();
                int lives4 = 15;
                int tries4 = 0;
                int q = random4.Next(1, 1001);
                int d = Convert.ToInt32(Console.ReadLine());
                while(d!=q)
                {
                    Console.WriteLine("Try again");
                    if(d>q)
                    {
                        lives4 = lives4 - 1;
                        tries4 = tries4 + 1;
                        Console.WriteLine("Too high");
                        Console.WriteLine("Left tries: " + lives4);
                        if(lives4 == 0)
                        {
                            Console.WriteLine("Game over");
                            Console.WriteLine("Number was: " + q);
                            break;
                        }
                    }
                    else if(d<q)
                    {
                        lives4 = lives4 - 1;
                        tries4 = tries4 + 1;
                        Console.WriteLine("Too low");
                        Console.WriteLine("Left tries: " + lives4);
                        if(lives4 == 0)
                        {
                            Console.WriteLine("Game over");
                            Console.WriteLine("Number was: " + q);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Congratulations, you guessed");
                            Console.WriteLine("Tries: " + tries4);
                        }
                    }
                }
                break;
            default:
                Console.WriteLine("Wrong option");
                break;
        }
    }
}
