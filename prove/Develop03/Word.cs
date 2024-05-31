using System;


public class Word

{
    private List<bool> boolList;
    private Random random;

        public WordManager(int size)
    {
        boolList = new List<bool>(new bool[size]);
    }
    public static void SetAllTrue()
    {
        // Define the size of the list
        int size = 23;
        
        List<bool> boolList = new List<bool>(new bool[size]);
        
        // Assign true or false to each index based on a condition
        for (int i = 0; i < boolList.Count; i++)
            {
                boolList[i] = true;
            }
            // use to see bool values
            // foreach (bool value in boolList)
            // {
            //     Console.WriteLine(value);
            // }
    }

    public void SetRandomFalse(int numberOfFalse)
    {
        int count = 0;
        while (count < numberOfFalse)
        {
            int randomIndex = random.Next(boolList.Count);
            if (boolList[randomIndex])
            {
                boolList[randomIndex] = false;
                count++;
            }
        }
    }
        public bool CheckIndex(int index)
    {
        if (index < 0 || index >= boolList.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range");
        }
        return boolList[index];
    }
    }