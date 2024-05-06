public class SolutionBaseK {
    public int SumBase(int n, int k) {
        
        var result = 0;
        var baseK = n/=k;
        var sum = 0;

        while(baseK > 0)
        {
            result += n % 10;
            sum = sum + result;
            baseK = baseK / 10;
        }
        return sum;
    }
}