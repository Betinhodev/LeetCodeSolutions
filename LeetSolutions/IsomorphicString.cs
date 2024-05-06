public class SolutionIsomorphic {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        Dictionary<char, char> map = new Dictionary<char, char>();
        HashSet<char> mapped = new HashSet<char>();

        for(int i = 0; i < s.Length; i++){
            if(map.ContainsKey(s[i])){
                return false;
            }
            else {
                if (mapped.Contains(t[i]))
                    return false;

                map[s[i]] = t[i];
                mapped.Add(t[i]);

                
            }

        }
            return true;
    }
}