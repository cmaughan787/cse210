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
    public void Display()
{
    Console.Clear();
    Console.WriteLine($"{_reference.GetReference()}, {_words}");
}
}