using System;

public class Solution
{
    public int[] solution(int[] numbers, string direction)
    {
        int[] answer = new int[] {};
        int tempNum = 0;
        bool isRight = true;
        
        if (direction == "right")
        {
            isRight = true;
            tempNum = numbers[numbers.Length - 1];
        }
        else
        {
            isRight = false;
            tempNum = numbers[0];
        }
        
        if (isRight)
        {
            for (int i = numbers.Length-1; i > 0; i--)
            {
                numbers[i] = numbers[i-1];
            }
            numbers[0] = tempNum;
        }
        else
        {
            for (int i = 0; i < numbers.Length-1; i++)
            {
                numbers[i] = numbers[i+1];
            }
            numbers[numbers.Length-1] = tempNum;
        }
        
        return answer = numbers;
    }
}