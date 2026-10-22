public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] sCount = new int[26];
        int[] tCount = new int[26];

        foreach(var c in s){
            sCount[c - 'a']++;
        }

        foreach(var c in t){
            tCount[c- 'a']++;
        }

        for(int i=0; i<26; i++){
            if(sCount[i] != tCount[i]){
                return false;
            }
        }

        return true;
    }
}
