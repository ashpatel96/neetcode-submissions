class Solution {
    public int lengthOfLongestSubstring(String s) {
        int write = 0;
        int best = 0;
        Map<Character, Integer> map =  new HashMap<>();

        for(int read=0; read < s.length(); read++){
            char current = s.charAt(read);
            if(!map.containsKey(current)){
                map.put(current, 0);
            }
            map.put(current, map.get(current) + 1);

            while(map.get(current) > 1){
                map.put(s.charAt(write), map.get(s.charAt(write)) - 1);
                write++;
            }
            best = Math.max(best, (read-write) + 1);
        }
        return best;
    }
}
