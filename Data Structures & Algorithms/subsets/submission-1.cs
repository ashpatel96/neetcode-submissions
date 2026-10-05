public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        BackTrack(nums, 0, new List<int>(), result);
        return result;
    } 

    private void BackTrack(int[] nums, int start, List<int> path, List<List<int>> result){
        // result.Add(new List<int>(path)); 
        // for(int i= start; i< nums.Length; i++){
        //     path.Add(nums[i]);
        //     BackTrack(nums, i + 1, path, result);
        //     path.RemoveAt(path.Count - 1);
        // }
        if(start >= nums.Length){
            result.Add(new List<int>(path));
        } else {

            // skip
            BackTrack(nums, start + 1, path, result);

            // choose 
            path.Add(nums[start]);

            // explore
            BackTrack(nums, start + 1, path, result);

            //BackTrack
            path.RemoveAt(path.Count - 1);
        }
    }
}
