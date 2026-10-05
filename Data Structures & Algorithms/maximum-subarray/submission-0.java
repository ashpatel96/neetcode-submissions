class Solution {
    public int maxSubArray(int[] nums) {
        int maxSubArraySum = nums[0];
        int subArraySum = nums[0];

        for(int i = 1; i< nums.length; i++){
            subArraySum = Math.max(nums[i], subArraySum + nums[i]);
            maxSubArraySum = Math.max(maxSubArraySum, subArraySum);
        }

        return maxSubArraySum;
    }
}
