class Solution {
    public int maxProduct(int[] nums) {
        int subMax = nums[0];
        int subMin = nums[0];
        int maxProduct = nums[0];

        for(int i=1; i < nums.length; i++){
            int prevMax = subMax;
            int prevMin = subMin;

            subMax = Math.max(nums[i], Math.max(prevMax * nums[i], prevMin * nums[i]));

            subMin = Math.min(nums[i], Math.min(prevMax * nums[i], prevMin * nums[i]));

            maxProduct = Math.max(subMax, maxProduct);
        }

        return maxProduct;
    }
}
