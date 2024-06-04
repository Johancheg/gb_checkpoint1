using System;
class Program
{
    static void Main(string[] args)
    {
        string [] mainarray = {"lol","kek", "cheburek", "kontrosha", "dushit", "abc"};
        string[] resultarray = new string[mainarray.Length];
        int resultindex =0;
        
        for (int i = 0; i < mainarray.Length; i++)
        {
            if (mainarray[i].Length <= 3)
            {
                resultarray[resultindex] = resultarray[i];
                resultindex++;
            }
        }
        
    }
}
