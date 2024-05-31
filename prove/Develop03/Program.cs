using System;

class Program
{
    static void Main(string[] args)
    {
        //Start program by showing the scripture 
        Console.WriteLine("Welcome to your memorization aid!");
        Reference reference = new Reference("Moroni", 7, "33");
        Scripture scripture = new Scripture(reference, "And Christ hath said: If ye will have faith in me ye shall have power to do whatsoever thing is expedient in me.");
        scripture.Display();

        // Word.Shown(); // for debug testing


        Console.WriteLine("Press enter or type 'quit'");
        string input = Console.ReadLine();
        
while (scripture.GetChecker().CheckAll() && input != "quit")
{    
            //call HideWord
            scripture.HideWord();
            // scripture.DisplayVer();
            input = Console.ReadLine();
       
}
Console.WriteLine("Thank you for coming to the Scripture Memorization app! Memorizing scriptures allows the Spirit to bring them back to our rememberance in times of need. Moroni 7:33 teaches us the importance of having faith, and that with faith we truly can accomplish anything. Have faith and keep moving forward!");
    }
}