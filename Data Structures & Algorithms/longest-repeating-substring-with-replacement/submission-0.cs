public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        int best =0;
        int write =0, read=0;
        for(read=0; read < s.Length; read++){
            map[s[read]] = map.GetValueOrDefault(s[read],0) + 1;
            int maxFreq = map.Values.Max();
            while((read - write + 1) - maxFreq > k){
                char w = s[write];
                map[w]--;
                if(map[w] == 0){
                    map.Remove(w);
                }
                write++;
                maxFreq = map.Values.Max();
            }
            best = Math.Max(best, (read - write) + 1);
        }
        return best;
    }
}
