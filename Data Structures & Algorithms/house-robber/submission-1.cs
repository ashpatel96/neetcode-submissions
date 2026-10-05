public class Solution {
    public int Rob(int[] nums) {
        //return Rob(nums, 0);
        if (nums.Length == 1)
            return nums[0];

        int[] dp = new int[nums.Length];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);

        for(int i=2;i< nums.Length;i++){
            dp[i] = Math.Max(dp[i-1], nums[i] + dp[i-2]);
        }
        return dp[nums.Length-1];
    }

    public int Rob(int[] nums, int index){
        if(index >= nums.Length){
            return 0;
        }

        int skip = Rob(nums, index + 1);
        
        int choose = nums[index] + Rob(nums, index + 2) ;

        return Math.Max(skip, choose);
    }
}
