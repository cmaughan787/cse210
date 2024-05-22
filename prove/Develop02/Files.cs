using System;
using System.IO; 
using System.Collections.Generic;

public class Files
{

    public void SaveToFile(Journal journal)
    {
        string fileName = "MyJournal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
     
            foreach (Entry entry in journal._entries)
            {
                outputFile.WriteLine($"Date: {entry.date} \nPrompt: {entry.jorprompt} \nEntry: {entry.text}");
            }
        }
    }



}

