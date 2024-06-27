using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string answer;
        string txtScripture;

        Reference myReference = new Reference("D&C",121,36);
        txtScripture = "That the rights of the priesthood are inseparably connected with the powers of heaven, and that the powers of heaven cannot be controlled nor handled only upon the principles of righteousness";

        Scripture myScripture = new Scripture(myReference,txtScripture);

        do
        {
            //clean screen
            Console.Clear();
            //display scripture not hidden
            Console.WriteLine(myScripture.GetDisplayText());
            
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            answer = Console.ReadLine();

            //supprimer des mots de leciture  
            myScripture.HideRandomWords(3);




        } while(answer != "quit" && !myScripture.IsCompletelyHidden()); //not (type quit or there is no more word)
    }
}