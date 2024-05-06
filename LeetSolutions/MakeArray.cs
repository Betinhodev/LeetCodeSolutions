public class SolutionMakeArray {
    public int MinimumOperations(int[] nums) {
        int min = nums.Min();
        int count = 0;
        int i = 0;

        while(nums[i] > 0)
        {
            foreach(int num in nums)
            {
                if(num == 0)
                {
                    break;
                }
                if(num > 0)
                {
                    nums[i] -= min;
                }
            }
            count++;            
            i++;

        }

        return count;
        
    }
}