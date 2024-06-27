using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text) 
    {
        _reference = Reference;
        // transform text in word list
        text = "le chien est beau";
        // si vide arret duu traitement

        int blankIndex;
        blankIndex = text.IndexOf(" ");
        // si " " pas trouvé = 1 seule mot
        if (blankIndex != -1)
        {
            Word myWord = new Word(text); 
            _words.Add(myWord);
        }
        // sinon le 1er mot se trouve entre position 0 et blankIndex
        else 
        {

        }

        
    }


    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}