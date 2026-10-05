class Solution {
    
    public int minCostClimbingStairs(int[] cost) {
        //return Math.min(minCostClimbingStairs(cost, 0), minCostClimbingStairs(cost, 1));

        int[] dp = new int[cost.length];
        int n = cost.length;
        dp[0] = cost[0];
        dp[1] = cost[1];

        for(int i=2; i < n; i++){
            dp[i] = cost[i] + Math.min(dp[i-1], dp[i-2]);
        }

        System.out.println(Arrays.toString(dp));

        return Math.min(dp[n - 1], dp[n - 2]);
    }
    public int minCostClimbingStairs(int[] cost, int index) {
        if(index >= cost.length){
            return 0;
        }
        return cost[index] + Math.min(minCostClimbingStairs(cost, index + 1),
        minCostClimbingStairs(cost, index + 2));
    }
}
