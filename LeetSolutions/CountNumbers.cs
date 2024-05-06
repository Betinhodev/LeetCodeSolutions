public class Solution {
    public int CountDigits(int num) {
        int count = 0;
        int copyOfNum = num;
        int reminder = 0;
        
        while(num > 0)
        {
            reminder = num % 10;
            num = num / 10;

            if(copyOfNum % reminder == 0)
            {
                count++;
            }
        }
        return count;
    }
}