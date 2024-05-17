using System;
using System.IO; 

public class Files
{
    public void DisplayEntries()
    {
        string fileName = "MyJournal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{DisplayEntries}");
        }
    }




}
