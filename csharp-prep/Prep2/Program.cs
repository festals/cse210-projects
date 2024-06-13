using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine();

        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);

        string letterGrade = "";
        string sign = "";

        if (number >= 90)
        {
            letterGrade = "A";
        }
        else if (number >=80)
        {
            letterGrade = "B";
        }
        else if (number >=70)
        {
            letterGrade = "C";
        }
        else if (number >=60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (number < 97 && number > 60)
        {
            if  (number % 10 >= 7)
            {
                sign = "+";
            }      
        }
        else if (number > 59)
        {
            if (number % 10 < 3)
            {
                sign = "-";
            }
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {letterGrade}{sign}.");

        if (number >= 70)
        {
            Console.WriteLine("Congratulation! You have passed this class! ");            
        }
        else
        {
            Console.WriteLine("Your grade is not high enough to pass this class, Try again next semester I know you can do it. ");
        }
    }
}