public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {
        //return DFS(0, nums, 0, target);

        int total = nums.Sum();
        int n = nums.Length;

        if (Math.Abs((long)target) > total) {
            return 0;
        }
        int [][] dp= new int[n+1][];

        for(int i=0; i<n+1 ; i++){
            dp[i] = new int[2*total+1];
        }
        int offset = total;
        dp[0][offset] = 1;
        
        for(int i = 0; i < n; i++) {
            for(int sum = -total; sum <= total; sum++){
                int ways = dp[i][sum+offset];

                if(ways == 0){
                    continue;
                }

                int plus = sum + nums[i];
                int minus = sum - nums[i];

                dp[i+1] [plus + offset] += ways;
                dp[i+1] [minus + offset] += ways;
            }
        }

        return dp[n][target + offset];

    }

    private int DFS(int index, int[] nums, int sum, int target){
        if(index == nums.Length){
            return sum == target ? 1 : 0;
        }
        
        int ways = 0;

        ways += DFS(index + 1, nums, sum + nums[index], target);

        ways += DFS(index + 1, nums, sum - nums[index], target);

        return ways;
    }
}
