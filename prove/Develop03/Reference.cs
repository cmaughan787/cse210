using System;


public class Reference
{
    private string _book;
    private int _chapter;
    private string _verse;

public Reference(string refBook, int refChapter, string refVerse)
{
    _book = refBook;
    _chapter = refChapter;
    _verse = refVerse;
}

   public string GetReference()
    {
        return $"{_book} {_chapter}:{_verse}";
    }

    // Display method to print the reference
    public void Display()
    {
        Console.WriteLine(GetReference());
    }
// public void Display()
// {
//     Console.WriteLine($"{_book} {_chapter}:{_verse}");
// }

}