public class SolutionDiff {
    public int DifferenceOfSum(int[] nums) {
        int elementSum = 0;
        int digitSum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            elementSum += nums[i];

            if(nums[i] > 0)
            {
                while(nums[i] > 0)
                {
                    int rem = nums[i] % 10;
                    digitSum = digitSum + rem;
                    nums[i] = nums[i] / 10;
                }
            }

        }
        return elementSum - digitSum;
    }
}