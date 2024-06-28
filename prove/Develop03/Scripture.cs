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

        //recherche du blanc
        int previousBlankIndex = 0;
        int blankIndex;

        // si chaine vide ou blanc au bout de la chaine
        //recherche du blanc suivant
        //si pas de blanc, cets un seul mot
        //sinon extrait mot entre blanc preced et nv blanc
        // et blanc precednt = nv blanc
        
        while(previousBlankIndex <= text.Length)
        {
            blankIndex = text.IndexOf(" ", previousBlankIndex);
            
            Word myWord = new Word("");
            
            // si " " pas trouvé = 1 seule mot
            if (blankIndex == -1)
            {
                myWord.SetWord(text.Substring(previousBlankIndex, text.Length - previousBlankIndex)); 
                _words.Add(myWord);
                previousBlankIndex = text.Length +1 ;
            }
            // sinon le mot se trouve entre position previousblankindex et blankIndex
            else 
            {
                myWord.SetWord(text.Substring(previousBlankIndex, blankIndex - previousBlankIndex)); 
                _words.Add(myWord);
                previousBlankIndex = blankIndex +1;
            }
        }
        
    }


    public void HideRandomWords(int numberToHide) 
    //select randomly one number between 0 and the list.length
    // recupere le mot et cache le
    {
        bool flagVisibled;

        for (int i = 1; i <= numberToHide; i++)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, _words.Count);
            flagVisibled =_words[randomNumber].Hide();

            //si le mot était deja caché alors on recommence en decalant numberToHide, sauf si tous les mots sont cachés
            if (flagVisibled == false && numberToHide <= _words.Count)
            {
                numberToHide ++;
            }    
        }
    }

    public string GetDisplayText()
    // retourner le text avec les mots cachés s'ily en a
    {
        string localText ="";
        
        foreach (var word in _words)
        {
            localText += $"{word.GetDisplayText()} ";
            //Console.WriteLine(word.GetDisplayText());
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