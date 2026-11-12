public class Solution {
    public int NumDecodings(string s) {
        //return DFS(0, s);
        int n=s.Length;
        int[] dp = new int[n+1];
        dp[0] = 1;
        dp[1] = s[0] == '0' ? 0: 1;

        for(int i=2; i<=n; i++){
            if(s[i-1]!='0'){
                dp[i] +=dp[i-1];
            }

            if(s[i-2] == '1' || (s[i-2] == '2' && s[i-1] <= '6')){
                dp[i] += dp[i-2];
            }
        }
        return dp[n];
    }

    private int DFS(int index, string s) {
       if(index == s.Length){
            return 1;
       }
       if(s[index] == '0'){
            return 0;
       }

       int ways = DFS(index + 1, s);

       if(index + 1 < s.Length && (s[index] == '1' || (s[index] == '2' && s[index + 1] <= '6'))){
            ways+= DFS(index + 2, s);
       }

       return ways;
    }
}
