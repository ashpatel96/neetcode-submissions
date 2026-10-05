class Solution {
    
    public int minCostClimbingStairs(int[] cost) {
        //return Math.min(minCostClimbingStairs(cost, 0), minCostClimbingStairs(cost, 1));

        int n = cost.length;
        int prev2 = cost[0];
        int prev1 = cost[1];

        for(int i=2; i < n; i++){
            int current = cost[i] + Math.min(prev2, prev1);
            prev2 = prev1;
            prev1 = current;
        }

        return Math.min(prev2, prev1);
    }
    public int minCostClimbingStairs(int[] cost, int index) {
        if(index >= cost.length){
            return 0;
        }
        return cost[index] + Math.min(minCostClimbingStairs(cost, index + 1),
        minCostClimbingStairs(cost, index + 2));
    }
}
