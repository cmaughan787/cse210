using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Moroni", 7, "33");
        Scripture scripture = new Scripture(reference, "And Christ hath said: If ye will have faith in me ye shall have power to do whatsoever thing is expedient in me.");
        scripture.Display();
    }
}