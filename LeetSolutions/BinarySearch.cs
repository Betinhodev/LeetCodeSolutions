public class SolutionBinarySearch {
    public int Search(int[] nums, int target) {
        int i = Array.BinarySearch(nums, target);
        return (i<0)? -1 : i;
    }
}