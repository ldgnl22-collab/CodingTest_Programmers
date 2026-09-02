using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = 0;
        float number = 0f;
        
        number = (float)num1 / (float)num2;
        number *= 1000;
        
        answer = (int)number;
        
        return answer;
    }
}