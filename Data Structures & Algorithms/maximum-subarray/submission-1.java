class Solution {
    public int maxSubArray(int[] nums) {
        int maxSubArraySum = nums[0];
        int maxSum   = nums[0];

        for(int i = 1; i< nums.length; i++){
            maxSum   = Math.max(nums[i], maxSum   + nums[i]);
            maxSubArraySum = Math.max(maxSubArraySum, maxSum);
        }

        return maxSubArraySum;
    }
}
