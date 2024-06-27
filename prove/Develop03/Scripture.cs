using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text) 
    {
        _reference = Reference;

        //
        // transform text in word list
        //

        text = "le chien est beau";

        // si vide arret duu traitement

        //recherche du blanc
        int blankIndex;
        blankIndex = text.IndexOf(" ");
        
        Word myWord = new Word("");
        // si " " pas trouvé = 1 seule mot
        if (blankIndex == -1)
        {
            myWord.SetWord(text); 
            _words.Add(myWord);
        }
        // sinon le 1er mot se trouve entre position 0 et blankIndex
        else 
        {
            myWord.SetWord(text.Substring(0, blankIndex)); 
            _words.Add(myWord);
        }

        myWord.SetWord("chien"); 
        _words.Add(myWord);
        myWord = null;

        
    }


    public void HideRandomWords(int numberToHide) 
    //select randomly one number between 0 and the list.length
    // recupere le mot et cache le
    //mot.hide
    {
        _words[0].Hide();
    }

    public string GetDisplayText()
    // retourner le text avec les mots cachés s'ily en a
    {
        string localText ="";
        
        foreach (var word in _words)
        {
            localText += $"{word.GetDisplayText()} ";
            Console.WriteLine(word.GetDisplayText());
        }
        return localText;
    }

    public bool IsCompletelyHidden()
    {
        bool allHide = true;

        foreach (var word in _words)
        {
            if (word.IsHidden() == false)
            {
                allHide = false;
            }
        }
        return allHide;
    }
}