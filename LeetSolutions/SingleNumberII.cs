namespace SingleNumberII;
public class Solution {
    public int singleNumber(int[] nums) {
        var ones = 0;
        var twos = 0;
        for(var i = 0; i < nums.Length; i++){
            if(i == ones)
            {
                twos ^= nums[i];
                ones ^= nums[i];
            }
            else
            {
                ones = (ones - 1) & ~ twos;
            }
        }
        return ones;
    }
}