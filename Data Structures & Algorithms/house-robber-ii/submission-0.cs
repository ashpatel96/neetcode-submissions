public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 1){
            return nums[0];
        }
        //return Math.Max(DFS(0, true, nums), DFS(1, false, nums));
        return Math.Max(Helper(nums[1..]), Helper(nums[..^1]));
    }

    public int DFS(int index, bool skipLastHouse, int[] nums){
        if(index >= nums.Length || (skipLastHouse && index == nums.Length - 1)){
            return 0;
        }

        return Math.Max(DFS(index+1, skipLastHouse, nums), 
                        nums[index] + DFS(index+2, skipLastHouse, nums));
    }

    public int Helper(int[] nums){
        if(nums.Length == 1){
            return nums[0];
        }
        int[] dp = new int[nums.Length];

        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);

        for(int i=2; i < nums.Length; i++){
            dp[i] = Math.Max(dp[i - 1], nums[i] + dp[i-2]);
        }

        return dp[^1];
    }
}
