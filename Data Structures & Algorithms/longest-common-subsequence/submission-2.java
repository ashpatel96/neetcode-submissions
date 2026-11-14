class Solution {
    public int longestCommonSubsequence(String s1, String s2) {
        int m = s1.length(), n = s2.length();

        int[][] dp = new int[m + 1][];

        for(int r=0; r <= m; r++){
            dp[r] = new int[n+1];
        }

        for(int r=1; r<=m; r++){
            for(int c=1; c<=n; c++){
                if(s1.charAt(r-1)== s2.charAt(c-1)){
                    dp[r][c] = dp[r-1][c-1] + 1;
                } else{
                    dp[r][c] = Math.max(dp[r-1][c], dp[r][c-1]);
                }
            }
        }

        return dp[m][n];
    }
}
