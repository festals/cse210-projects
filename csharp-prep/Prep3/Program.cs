using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine();

        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        
        
        int guess;
        int numberGuesses = 0;
        string response;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                numberGuesses += 1 ;

                if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (guess != magicNumber);
        
            Console.WriteLine($"It took you {numberGuesses} guess to find the magic number.");
            numberGuesses = 0;
            
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");

        

    }
}