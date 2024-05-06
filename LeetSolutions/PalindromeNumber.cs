public class SolutionPalindrome {
    public bool IsPalindrome(int x) {
        if(x < 0){
            return false;
        }

        int copyOfX = x;
        int reverse = 0;
        int rem = 0;

        while(x > 0){
            rem = x%10;
            reverse = reverse*10+rem;
            x/=10;
        }

        if(reverse == copyOfX){
            return true;
        }

        return false;
    }
}