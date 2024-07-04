using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string answer;

        do
        {
            Console.Clear();
            Activity myActivity = new Activity();

            myActivity.ShowSpinner(30);
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Start breathing activity");  // 
            Console.WriteLine("2. Start reflecting activity");    // 
            Console.WriteLine("3. Start listing activity");       // 
            Console.WriteLine("4. Quit");   //
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();

            if (answer == "1")
            {

            }

            if (answer == "2")
            {

            }

            if (answer == "3")
            {

            } 

        }while(answer != "4");

    }
}