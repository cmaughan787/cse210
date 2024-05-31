using System;


public class Word

{
    private List<bool> boolList;
    private Random random = new Random();

    public Word(int size) 
    {
        boolList = new List<bool>(Enumerable.Repeat(true, size));
    }

    // public void WordManager(int size)
    // {
    //     List<bool> boolList = new List<bool>(Enumerable.Repeat(true, size));
    // }

    public void SetAllTrue()
    {
        for (int i = 0; i < boolList.Count; i++)
        {
            boolList[i] = true;
        }
    }
            // use to see bool values
            // foreach (bool value in boolList)
            // {
            //     Console.WriteLine(value);
            // }

    public void SetFalse(int randomNumber)
    {

            // Console.WriteLine("bool", boolList.Count);

                boolList[randomNumber] = false;
    }
        public bool CheckIndex(int index)
    {
        if (index < 0 || index >= boolList.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range");
        }
        return boolList[index];
    }
    public bool CheckAll()
    {
        int count = 0;
        foreach (bool item in boolList)
        {
            
            if (item)
                count ++;
        }
        if (count == 0)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }
}