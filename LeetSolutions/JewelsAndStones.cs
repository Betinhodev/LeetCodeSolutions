public class SolutionJewels {
    public int NumJewelsInStones(string jewels, string stones) {
        int count = 0;
        

        for(int i = 0; i < jewels.Length; i++)
        {
            for(int j = i; j < stones.Length; j++)
            {
                if(jewels[i] == stones[j])
                {
                    count++;
                }
            }
        }

        return count;

        return count;
    }
}