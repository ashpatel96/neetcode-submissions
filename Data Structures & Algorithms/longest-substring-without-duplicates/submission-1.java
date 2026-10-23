class Solution {
    public int lengthOfLongestSubstring(String s) {
        int write = 0;
        int best = 0;
        Map<Character, Integer> map =  new HashMap<>();

        for(int read=0; read < s.length(); read++){
            if(!map.containsKey(s.charAt(read))){
                map.put(s.charAt(read), 0);
            }
            map.put(s.charAt(read), map.get(s.charAt(read)) + 1);

            while(map.get(s.charAt(read)) > 1){
                map.put(s.charAt(write), map.get(s.charAt(write)) - 1);
                write++;
            }
            best = Math.max(best, (read-write) + 1);
        }
        return best;
    }
}
