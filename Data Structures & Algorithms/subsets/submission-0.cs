public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        BackTrack(nums, 0, new List<int>(), result);
        return result;
    } 

    private void BackTrack(int[] nums, int start, List<int> path, List<List<int>> result){
        result.Add(new List<int>(path)); 
        for(int i= start; i< nums.Length; i++){
            path.Add(nums[i]);
            BackTrack(nums, i + 1, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }
}
