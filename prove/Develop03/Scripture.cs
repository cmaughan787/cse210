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
        
        public void HideWord()
        {
     Random random = new Random();
     int moroniCount = Words.Count;

        int randomNumber = random.Next(moroniCount);
        if (wordManager.CheckIndex(indexToCheck))
        {
            Console.WriteLine($"Index {indexToCheck} is true.");
        }
        else
        {
            Console.WriteLine($"Index {indexToCheck} is false.");
        }

        }

    public void Display()
{
    Console.Clear();
    Console.WriteLine($"{_reference.GetReference()}, {_words}");
}
}