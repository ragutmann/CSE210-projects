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
        // Code to hide random words
        Random random = new Random ();
        int count = _words.Count;

        if (count <= numberToHide)
        {
            // Hide all words if numberToHide is greater than or equal to count
            foreach (Word word in _words)
            {
                word.Hide();
            }
        }

        else
        {
            // Hide random words
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
        // Code to get the display text of the scripture
        string displayText = " ";
        foreach (Word word in _words)
        {
            displayText += word.IsHidden() ? "_____" : word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        // Code to check if all words are hidden
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // If any word is not hidden, return false
            }
        }
        return true; // If all words are hidden, return true
    }

    internal object GetReference()
    {
        throw new NotImplementedException();
    }
}