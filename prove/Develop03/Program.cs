// for exceeding requierement when pressing enter I randomly select from only those words that are not already hidden 
// I also ask the user for the number of words they want to hide



using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        string answer;
        string txtScripture;
        string txtNumberToHide;
        int numberToHide;
        
        // instancie reference et scripture
        Reference myReference = new Reference("D&C",121,36);
        txtScripture = "That the rights of the priesthood are inseparably connected with the powers of heaven, and that the powers of heaven cannot be controlled nor handled only upon the principles of righteousness.";

        // if you want to test with multiple verses
        //Reference myReference = new Reference("D&C",121,34,36);
        //txtScripture = "Behold, there are many called, but few are chosen. And why are they not chosen? \nBecause their hearts are set so much upon the things of this world, and aspire to the honors of men, that they do not learn this one lesson \nThat the rights of the priesthood are inseparably connected with the powers of heaven, and that the powers of heaven cannot be controlled nor handled only upon the principles of righteousness.";

        Scripture myScripture = new Scripture(myReference,txtScripture);
        
        //ask user for number of word they want to hide at a time (3 by default)
        Console.Clear();
        Console.Write("How many words do you want to be simultanely hidden each time you press enter? (3 by default): ");
        txtNumberToHide = Console.ReadLine();

        // si num , on convertit en int sinoon 3
        if ( int.TryParse(txtNumberToHide, out numberToHide))
        {
            numberToHide = Int32.Parse(txtNumberToHide);
            numberToHide = Math.Abs(numberToHide);
        }
        
        if (numberToHide == 0)
        {
            numberToHide = 3;
        }
        

        // affiche et reaffiche la phrase encachant des mots 
        do
        {
            //clean screen
            Console.Clear();


            Console.Write(myReference.GetDisplayText()+" ");
            //display scripture not hidden
            Console.WriteLine(myScripture.GetDisplayText());
            
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            answer = Console.ReadLine();

            //hide words from scripture  
            myScripture.HideRandomWords(numberToHide);




        } while(answer != "quit" && !myScripture.IsCompletelyHidden()); //not (type quit or there is no more word)

        //display scripture completely hidden
        if(myScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.Write(myReference.GetDisplayText()+" ");
            Console.WriteLine(myScripture.GetDisplayText());
            Console.WriteLine("bye-bye");
        }
    }
}