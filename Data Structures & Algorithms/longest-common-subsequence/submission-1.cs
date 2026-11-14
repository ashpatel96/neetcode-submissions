public class Solution {
    public int LongestCommonSubsequence(string s1, string s2) {
        int m = s1.Length, n = s2.Length;

        int[][] dp = new int[m+1][];

        for(int r=0; r <= m; r++){
            dp[r] = new int[n + 1];
        }

        for(int r = 1; r <= m; r++){
            for(int c=1; c <= n; c++){
                if(s1[r-1] == s2[c-1]){
                    dp[r][c] = 1 + dp[r-1][c-1];
                } else {
                    dp[r][c] = Math.Max(dp[r-1][c], dp[r][c-1]);
                }
            }
        }
        return dp[m][n];
    }
}
