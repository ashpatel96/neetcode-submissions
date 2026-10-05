class Solution {
    public int maxProfit(int[] prices) {
        int minPriceSoFar = prices[0];
        int maxProfit = 0;

        for(int i=1; i< prices.length;i++){
            maxProfit = Math.max(maxProfit, prices[i] - minPriceSoFar);
            minPriceSoFar = Math.min(minPriceSoFar, prices[i]);
        }

        return maxProfit;
    }
}
