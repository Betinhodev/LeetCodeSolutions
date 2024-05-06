public class SolutionDivNonDiv {
    public int DifferenceOfSums(int n, int m) {
        int sum1 = 0;
        int sum2 = 0;

        for(int i = 0; i <= n; i++)
        {
            if(i % m != 0)
            {
                sum1 = i + sum1;
            }
            else
            {
                sum2 = i + sum2;
            }
        }
        return sum1 - sum2;
    }
}