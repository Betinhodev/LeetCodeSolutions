public class SolutionAvgValue {
    public int AverageValue(int[] nums) {
        int sums=0;
        int count = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] % 3 == 0 && nums[i] % 2 == 0)
            {
                sums+= nums[i];
                count++;
            }
                
        }   
        return sums / count;
    }
}