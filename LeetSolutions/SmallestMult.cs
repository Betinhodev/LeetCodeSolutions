public class SolutionSmall {
    public int SmallestEvenMultiple(int n) {
        int result = 0;

        for(int i = 1; i <= n*2; i++)
        {
            if((n* i) % 2 == 0)
            {
                result += n*i;
                break;
            }
        }
        return result;
        
    }
}