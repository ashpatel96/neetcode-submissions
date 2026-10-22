class Solution {
    public boolean hasDuplicate(int[] nums) {
        Set<Integer> set = new HashSet<>();

        for(var num: nums){
            if(!set.add(num)){
                return true;
            }
        }

        return false;
    }
}