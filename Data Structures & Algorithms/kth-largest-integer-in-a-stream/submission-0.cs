public class KthLargest {
    private readonly PriorityQueue<int, int> pq = new();
    private  int _k;
    public KthLargest(int k, int[] nums) {
        _k = k;
        foreach(var num in nums){
            Add(num);
        }
    }
    
    public int Add(int num) {
        if(pq.Count < _k){
                pq.Enqueue(num, num);
                Console.WriteLine($"added {num} ");
        } else if(pq.Peek() < num){
                Console.WriteLine($"Dequeue element {pq.Peek()} and added {num} ");
                pq.Dequeue();
                pq.Enqueue(num, num);
        }

        return pq.Peek();
    }
}
