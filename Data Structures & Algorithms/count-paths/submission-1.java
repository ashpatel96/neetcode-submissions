class Solution {
    public int uniquePaths(int m, int n) {
        //return dfs(0,0,m,n);

        int[][] dp = new int[m][];

        for(int r=0; r < m; r++){
            dp[r] = new int[n];
        }
        dp[0][0] = 1;
        for(int r=0; r < m; r++){
            for(int c=0; c < n; c++){
                
                if(r > 0){
                    dp[r][c] += dp[r-1][c];
                }

                if(c > 0) {
                    dp[r][c] += dp[r][c-1];
                }
            }
        }
        return dp[m-1][n-1];
    }

    private int dfs(int r, int c, int m, int n){
        if(r>=m || c >=n){
            return 0;
        }
        
        if(r == m - 1 && c == n - 1){
            return 1;
        }

        int down = dfs(r+1, c, m, n);
        int right = dfs(r, c+ 1, m, n);

        return down+right;
    }
}
