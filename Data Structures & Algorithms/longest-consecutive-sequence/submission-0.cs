public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> seen = new HashSet<int>(nums);
        int best =0;

        foreach(var num in nums){

            if(!seen.Contains(num - 1)){
                int length =1;
                int current = num;

                while(seen.Contains(current + 1)){
                    length++;
                    current++;
                }
                best = Math.Max(best, length);
            }
        }
        return best;
    }
}
