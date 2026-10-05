public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0, right = heights.Length - 1, best = int.MinValue;

        while(left < right){
            int minBar = Math.Min(heights[left], heights[right]);

            best = Math.Max(best, (right - left) * minBar);

            if(heights[left] < heights[right]){
                left++;
            } else{
                right --;
            }
        }
        return best;
    }
}
