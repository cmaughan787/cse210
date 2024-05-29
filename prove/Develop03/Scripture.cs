using System;


public class Scripture
{
    private Reference _reference;
    private string _words;

    public Scripture( Reference reference, string words)
    {
        _reference = reference;
        _words = words;
    }

    public List<string> Words = new List<string>
    {
        "And",
        "Christ",
        "hath",
        "said:",
        "If",
        "ye",
        "will",
        "have",
        "faith",
        "in",
        "me",
        "ye",
        "shall",
        "have",
        "power",
        "to",
        "do",
        "whatsoever",
        "thing",
        "is",
        "expedient",
        "in",
        "me."
    };

    public void Display()
{
    Console.Clear();
    Console.WriteLine($"{_reference.GetReference()}, {_words}");
}
}