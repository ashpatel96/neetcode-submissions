public class Solution {
    public int Trap(int[] height) {
        int water =0, leftMax = int.MinValue, rightMax = int.MinValue;
        int left = 0, right = height.Length - 1, result =0;

        while(left < right){
            leftMax = Math.Max(leftMax, height[left]);
            rightMax  = Math.Max(rightMax, height[right]);

            if(leftMax < rightMax){
                result += leftMax - height[left];
                left++;
            } else {
                result += rightMax - height[right];
                right--;
            }
        }
        return result;
    }
}
