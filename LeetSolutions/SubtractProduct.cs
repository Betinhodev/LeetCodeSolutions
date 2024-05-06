public class SolutionProduct {
    public int SubtractProductAndSum(int n) {
        
        int copyOfN = n;
        int reminder = 0;
        int sum =0;
        int product = 1;

        while (n > 0)
            {
                reminder = n % 10;
                sum = sum + reminder;
                n = n / 10;
            }

        while (copyOfN > 0)
        {
            reminder = copyOfN % 10;
            product = product * reminder;
            copyOfN = copyOfN / 10;
        }
        
        return product + sum;
    }
}