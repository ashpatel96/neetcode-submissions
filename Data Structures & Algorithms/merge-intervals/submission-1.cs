public class Solution {
    public int[][] Merge(int[][] intervals) {

        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));
        List<int[]> res = new List<int[]>();
        int currStart = intervals[0][0];
        int currEnd = intervals[0][1];

        for(int i =1; i<intervals.Length; i++){
            int s = intervals[i][0];
            int e = intervals[i][1];

            if(s<=currEnd){
                currEnd = Math.Max(currEnd, e);
            } else {
                res.Add(new int[]{currStart,currEnd});
                currStart = s;
                currEnd = e;
            }
        }
        res.Add(new int[]{currStart, currEnd});
        return res.ToArray();
    }
}
