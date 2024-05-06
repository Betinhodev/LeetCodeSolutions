public class SolutionXor {
    public int XorOperation(int n, int start) {
        
        int[] array = new int[n];
        int xor = start;

        array[0] = start;

        for(int i =1;i<n;i++){
            array[i] = start+2*i;
        }

        for(int i=1;i<n;i++){
            xor=xor^array[i];
        }
        return xor;
    }
}