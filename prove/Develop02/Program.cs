using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Journal
{
    static void Main(string[] args)
    {
        public int var = 0;
    
        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to your journal!");
            Console.WriteLine("     1. Write an entry");
            Console.WriteLine("     2. Display journal");
            Console.WriteLine("     3. Load journal");
            Console.WriteLine("     4. Save new entry");
            Console.WriteLine("     5. Quit");
            Console.WriteLine("Select number from menu.");
            var = Convert.ToInt16(Console.ReadLine());
                if (var > 5)
                    {
                        Console.WriteLine("Please enter a number from 1-5");
                    }
                while (var != 0)
                    {
                        if (var == 1) 
                        {
                            jentry();
                        }
                        if (var == 2) 
                        {
                            jdisplay();
                        }
                        if (var == 3) 
                        {
                            jload();
                        }
                        if (var == 4) 
                        {
                            jsave();
                        }
                        if (var == 5) 
                        {
                            leave();
                        }
                     }
      
        }  
        public void jentry()
            {
                
            }
        public void jdisplay()
            {
                
            }
        public void jload()
            {
                
            }
        public void jsave()
            {
                
            }
        public void leave()
            {
                
            }

        DisplayMenu();
        
    }
}
