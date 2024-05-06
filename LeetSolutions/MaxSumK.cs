public class SolutionMaximizeSum {
    public int MaximizeSum(int[] nums, int k) {
        var max = nums.Max();
        var sum = max;

        for(int i = 0; i <= k - 2; i++)
        {
            max = max + 1;
            sum += max;
        }

        return sum;
    }
}