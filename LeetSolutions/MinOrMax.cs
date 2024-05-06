public class SolutionMinOrMax {
    public int FindNonMinOrMax(int[] nums) {
        int min = nums.Min();
        int max = nums.Max();
        int ans = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] > min && nums[i] < max)
            {   
                ans = nums[i];
            }
            else
                ans = -1;
        }

        return ans;
    }
}