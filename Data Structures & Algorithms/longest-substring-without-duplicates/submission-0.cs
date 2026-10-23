public class Solution {
    public int LengthOfLongestSubstring(string s) {

        int write = 0;
        int best = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();

        for(int read=0; read < s.Length; read++){
            map[s[read]] = map.GetValueOrDefault(s[read], 0) + 1;

            while(map[s[read]] > 1){
                map[s[write]]--;
                write++;
            }
            best = Math.Max(best, (read-write) + 1);
        }
        return best;
    }
}
