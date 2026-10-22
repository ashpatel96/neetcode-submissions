public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach(var str in strs){
            int[] strCount = new int[26];

            foreach(var c in str){
                strCount[c - 'a']++;
            }

            string signature = string.Join(",", strCount);

            if(!map.ContainsKey(signature)){
                map[signature] = new List<string>();
            }

            map[signature].Add(str);
        }

        return map.Values.ToList();
    }
}
