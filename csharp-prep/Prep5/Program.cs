using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int numberSquared = SquareNumber(number);
        DisplayResult (name, numberSquared);
    }

    static void DisplayWelcome ()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName ()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber ()
    {
        Console.Write("What is your favorite number (only integer)? ");
        int number = int.Parse(Console.ReadLine()); 
        return number;
    }

    static int SquareNumber (int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult (string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }

}