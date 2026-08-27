using System;

public class Solution
{
    public int solution(string a, string b)
    {
        string compareString = "";
            
            char[] compareChar = new char[a.Length];

            int[] index = new int[a.Length];
            int indexChanger = a.Length - 1;
            
            int resultCount = 0;

            for (int i = 0; i < a.Length; i++)
            {
                index[i] = i;
                compareChar[i] = a[i];
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a == b && i == 0)
                {
                    return 0;
                }
                for (int j = 0; j < a.Length; j++)
                {
                    index[j] -= 1;
                    if (index[j] == -1)
                    {
                        index[i] = a.Length - 1;
                    }
                    compareString += compareChar[index[j]];
                }

                if (compareString == b)
                {
                    return i+1;
                }
                else
                {
                    if (i >= a.Length-1)
                    {
                        return -1;
                    }
                }
                
                a = compareString;
                
                compareString = "";
            }
        
        return resultCount;
    }
}