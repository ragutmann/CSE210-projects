using System.ComponentModel;

public class Scripture
{
    private Reference _reference; 
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(" ");

        foreach(string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random ();
        int count = _words.Count;

        if (count <= numberToHide)
        {
            foreach (Word word in _words)
            {
                word.Hide();
            }
        }

        else
        {
            HashSet<int> indicesToHide = new HashSet<int>();
            while (indicesToHide.Count < numberToHide)
            {
                int index = random.Next(0, count);
                if(!indicesToHide.Contains(index))
                {
                    indicesToHide.Add(index);
                }
            }

            foreach (int index in indicesToHide)
            {
                _words[index].Hide();
            }

            
        }

    }

    public string GetDisplayText()
    {
        string displayText = " ";
        foreach (Word word in _words)
        {
            displayText += word.IsHidden() ? "_____" : word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; 
            }
        }
        return true; 
    }

    internal object GetReference()
    {
        return "John 3:16";
    }
}