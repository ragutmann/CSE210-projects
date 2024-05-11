public class Word
{
    private string _text;

    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // By default, word is not hidden
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
            return "_____";
        
        else
            return _text;
    }
}