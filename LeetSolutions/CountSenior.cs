public class SolutionCountSeniors {
    public int CountSeniors(string[] details) {
        int count = 0;

        for(int i = 1; i < details.Length; i++)
        {
            int age = details[i][11] * 10 + details[i][12];
            if(age > 60)
            {
                count++;
             
            }
        }

        return count;
    }
}