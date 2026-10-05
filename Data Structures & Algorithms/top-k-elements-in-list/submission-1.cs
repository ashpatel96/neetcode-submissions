public class Solution {
    /*
        Create frequency map for element
        Loop through map and mainitain k element in minheap
        pop elements from minheap.
    */
    public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int, int> freqMap = new Dictionary<int, int>();
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

        foreach(var num in nums){
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;
        }

        foreach(var kv in freqMap){
            if(pq.Count < k){
                pq.Enqueue(kv.Key, kv.Value);
            } else {
                 // Get frequency of the least-frequent item in heap
                pq.TryPeek(out int element, out int minFrequency);

                if (minFrequency < kv.Value)
                {
                    pq.Dequeue();
                    pq.Enqueue(kv.Key, kv.Value);
                }
            }
        }

        int[] result = new int[k];

        int i =0;

        while(pq.Count >0){
            pq.TryDequeue(out int element, out int _);
            result[i++] = element;
        }
        
        return result;
    }
}
