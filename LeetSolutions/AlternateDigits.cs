public class SolutionAlternate {
    public int AlternateDigitSum(int n) {
         int sum = 0;
        int sign = 1;
        int digitCount = (int) Math.Log10(n) + 1;
        
        if(digitCount % 2 == 0)
        {
            sign *= -1;
        }

        while(n > 0)
        {
            sum += n % 10 * sign;
            n /= 10;
            sign *= -1;
        }

        return sum;
    }
}