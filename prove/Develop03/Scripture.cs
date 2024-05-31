using System;


public class Scripture
{
    private Reference _reference;
    private string _words;
    private Word _checker;


    public Word GetChecker()
    {
        return _checker;
    }
    public Scripture(Reference reference, string words)
    {
        _reference = reference;
        _words = words;
        _checker = new Word(Words.Count);
        foreach (var word in Words)
        {
            string _ok = "";
            for (int i = 0; i < word.Length; i++)
            {
                _ok += "_";
            }
            Replace.Add(_ok);
        } 
    }

    public List<string> Words = new List<string>
    {
        "Moroni",
        "7:",
        "33",
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
    public List<string> Replace = new List<string>();
    // {
    // "___”, “_____”, “____”, “____:”, “__”, “__”, “____”, “____”, “_____”, "__", "__", "__", "_____", "____", "_____", "__", "__", "__________", "_____", "__", "_________", "__", "__." 
    // };

        public void DisplayVer()
        {
            string s = string.Join(" ", Words);
            Console.WriteLine(s);
        }
        
    public void HideWord()
    {
    int count = 0;
    while (count == 0)
    {
        Random random = new Random();
        int moroniCount = Words.Count;
        int randomNumber = random.Next(moroniCount);

        // IF TURE REPLACE
        
        if (_checker.CheckIndex(randomNumber) == true)
        {
            Console.Clear();
            Words[randomNumber] = Replace[randomNumber];
            DisplayVer();
            //SET bool to FALSE
            _checker.SetFalse(randomNumber);
            Console.WriteLine(randomNumber);
            count = 1;
        }
        // IF FALSE GENERATE NEW NUMBER
        }
    }

    public void Display()
{
    Console.Clear();
    Console.WriteLine($"{_reference.GetReference()}, {_words}");
}
}