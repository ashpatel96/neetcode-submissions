public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> result = new List<List<int>>();
        BackTrack(nums, 0, target, new List<int>(), result);

        return result;
    }

    private void BackTrack(int[] nums, int start, int target, List<int> path, List<List<int>> result){
        if(target == 0){
            result.Add(new List<int>(path));
        } else{
            for(int i = start; i < nums.Length; i++){
                if(target>=nums[i]){
                    path.Add(nums[i]);
                    BackTrack(nums, i, target - nums[i], path, result);
                    path.RemoveAt(path.Count - 1);
                }
            }
        }
    }
}
