public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

        foreach(var stone in stones){
            pq.Enqueue(stone, stone);
        }

        while(pq.Count > 1){
            int stone1 = pq.Dequeue();
            int stone2 = pq.Dequeue();

            pq.Enqueue((stone1 - stone2), (stone1 - stone2));
        }

        return pq.Dequeue();
    }
}
