public class Word
{
    private string _text;
    private string _textDisplayed;
    private bool _isHidden;


    public Word(string text)  //text contains one word
    {
        _text = text; 
        _textDisplayed = text;
    }


    public void Hide()  //
    {
        _textDisplayed = "___";
        _isHidden = true;
    }

    public void Show()
    {
        _textDisplayed = _text;
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()  //return ___ if hidden or text not hidden
    {
        return _textDisplayed;
    }

    public void SetWord(string mot)
    {
        _text = mot;
    }
}