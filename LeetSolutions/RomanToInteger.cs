public class Solution2 {
    public int RomanToInt(string s) {

        int prev = 0;
        int total = 0;

        Dictionary<char, int> romanNum = new Dictionary<char, int> {
          {'M', 1000},
          {'D', 500},
          {'C', 100},
          {'L', 50},
          {'X', 10},
          {'V', 5},
          {'I', 1},  
        };


        for(int i = s.Length - 1; i >= 0; i-- ){
            if(prev <= romanNum[s[i]]){
                total += romanNum[s[i]];
            }
            else if(prev >= romanNum[s[i]])
            {
                total -= romanNum[s[i]];
            }

            prev = romanNum[s[i]];
        }
    return total;
    }
}