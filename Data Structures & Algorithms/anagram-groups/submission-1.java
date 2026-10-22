class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
        Map<String, List<String>> map = new HashMap<>();

        for(String str:strs){
            int[] freq = new int[26];

            for(var c: str.toCharArray()){
                freq[c - 'a']++;
            }

            String result = Arrays.toString(freq);

            if(!map.containsKey(result)){
                map.put(result, new ArrayList<>());
            }
            var lst = map.get(result);
            lst.add(str);
            map.put(result, lst);
        }

        return new ArrayList<>(map.values());
    }
}
