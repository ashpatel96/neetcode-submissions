/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {
        intervals.Sort((a, b) => a.start.CompareTo(b.start));

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach(var iv in intervals){
            
            if(pq.Count > 0 && pq.Peek() <= iv.start){
                pq.Dequeue();
            }
            pq.Enqueue(iv.end, iv.end);
        }

        return pq.Count;
    }
}
