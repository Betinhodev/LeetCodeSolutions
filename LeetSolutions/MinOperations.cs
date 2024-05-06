public class SolutionMinOperations {
    public int MinOperations(int n) {
        int[] arr = new int[n];

        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = (2 * i) + 1;
        }

        return 1;
    }
}