class Solution {
    public boolean isAnagram(String s, String t) {
        int[] sCount = new int[26];
        int[] tCount = new int[26];

        for(var c : s.toCharArray()){
            sCount[c -'a']++;
        }

        for(var c : t.toCharArray()){
            tCount[c -'a']++;
        }

        for(int i=0; i < 26;i++){
            if(sCount[i] != tCount[i]){
                return false;
            }
        }
        return true;
    }
}
