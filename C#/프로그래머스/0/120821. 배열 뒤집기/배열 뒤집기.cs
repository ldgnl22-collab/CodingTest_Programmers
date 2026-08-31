using System;

public class Solution
{
    public int[] solution(int[] num)
    {
        int[] answer = new int[num.Length]; {};
            
            int[] mirrorNum = new int[num.Length];
            
            for (int i = 0; i < num.Length; i++)
            {
                mirrorNum[i] = num[num.Length - 1 - i];
                answer[i] = mirrorNum[i];
            }
        
        return answer;
    }
}