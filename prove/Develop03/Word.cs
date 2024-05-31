using System;


public class Word

{
    static void Shown()
    {
        // Define the size of the list
        int size = 23;
        
        List<bool> boolList = new List<bool>(new bool[size]);
        
        // Assign true or false to each index based on a condition
        for (int i = 0; i < size; i++)
        {
            // Assign true if the index is even, false if odd
            if (i % 2 == 0)
            {
                boolList[i] = true;
            }
            else
            {
                boolList[i] = false;
            }
        }
    }
    }