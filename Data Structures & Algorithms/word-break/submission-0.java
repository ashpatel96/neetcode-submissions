class TrieNode {
    Map<Character, TrieNode> children;
    boolean isWord = false;

    TrieNode(){
        children = new HashMap<>();
    }
}
class Solution {

    public boolean wordBreak(String s, List<String> wordDict) {

        TrieNode root = new TrieNode();

        for(String word: wordDict){
            TrieNode node = root;

            for(Character c: word.toCharArray()){
                node = node.children.computeIfAbsent(c, k -> new TrieNode());
            }
            node.isWord = true;
        }

        boolean[] dp = new boolean[s.length()];

        for(int i=0; i< s.length(); i++){
            if(i == 0 || dp[i-1]){
                TrieNode node = root;
                for(int j = i; j < s.length(); j++){
                    node = node.children.get(s.charAt(j));

                    if(node == null){
                        break;
                    }

                    if(node.isWord){
                        dp[j] = true;
                    }
                }
            }
        }

        return dp[s.length() -1];
    }
}
