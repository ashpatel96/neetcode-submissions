public class Solution {
    public int ClimbStairs(int n) {     
        // if(n == 0){
        //     return 1;
        // }
        // if(n < 0){
        //     return 0;
        // }
        // return ClimbStairs(n -1) + ClimbStairs(n-2);

        int[] dp = new int[n+1];
        dp[0] = 1;
        dp[1] = 1;
        for(int i= 2; i<=n; i++){
            dp[i] = dp[i-1] + dp[i-2];
        }
        return dp[n];
    }


}
