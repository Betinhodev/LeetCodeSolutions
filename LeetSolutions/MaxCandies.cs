public class SolutionCandies {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        
        int maxCandies = candies.Max();
        IList<bool> ans = new List<bool>();

        for(int i = 0; i < candies.Length; i++ )
        {
            if(candies[i] + extraCandies >= maxCandies)
            {
                ans.Add(true);
            }
            else
                ans.Add(false);
        }

        return ans;
    }
}