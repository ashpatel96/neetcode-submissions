public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
      int s = newInterval[0];
      int e = newInterval[1];
      int n = intervals.Length;
      int i = 0;

      List<int[]> res = new List<int[]>();

      // before part
      while(i < n && intervals[i][1] < s){
        res.Add(intervals[i]);
        i++;
      }
      
      // merging part
      while(i < n && intervals[i][0] <= e){
        s = Math.Min(s, intervals[i][0]);
        e = Math.Max(e, intervals[i][1]);
        i++;
      }
      res.Add(new int[]{s, e});

      while(i < n){
        res.Add(intervals[i]);
        i++;
      }

      return res.ToArray();  
    }
}
