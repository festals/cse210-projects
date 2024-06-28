

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


    public bool Hide()  // return true if _text was not hidden
    {
        bool flag = false;

        if (_isHidden == false)
        {
            _textDisplayed = new string('_', _text.Length);
            _isHidden = true;
            flag = true;
        }

        return flag;
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
        _textDisplayed = mot;
    }
}