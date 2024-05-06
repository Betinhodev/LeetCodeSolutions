public class SolutionSmallerNumbers {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int count = 0;
        int[] counter = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if(nums[j] < nums[i])
                {
                    count++;
                }
            }
            counter[i] = count;
            count = 0;
        }

        return counter;
    }
}