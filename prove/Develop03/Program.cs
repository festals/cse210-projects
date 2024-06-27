using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string answer;

        do
        {
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            answer = Console.ReadLine();
            
            string key = Console.ReadKey().Key.ToString();
            do  // while they press enter (i think im not sure that work)
            {

            } while (key.ToUpper() == "");

        } while(answer != "quit"); //or there is no more word
    }
}