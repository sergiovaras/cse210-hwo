using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public Reference GetReference() => _reference;

    public void HideRandomWords(int count)
    { 
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        Random random = new Random();

        for (int i = 0; i < count && visibleWords.Any(); i++)
        {
            Word wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }
    }

    public bool AllWordsHidden() => _words.All(w => w.IsHidden());


    public string GetScriptureText()
    {
        string scriptureText = string.Join(" ", _words);
        return $"{_reference} {scriptureText}";
    }
}

    