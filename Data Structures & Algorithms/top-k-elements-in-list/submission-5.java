class Solution {
    public int[] topKFrequent(int[] nums, int k) {
        // Map<Integer, Integer> freqMap = new HashMap<>();
        // PriorityQueue<int[]> pq = new PriorityQueue<>((a,b) -> Integer.compare(a[1], b[1]));

        // for(int num : nums){
        //     freqMap.put(num, freqMap.getOrDefault(num,0) + 1);
        // }

        // for(Map.Entry<Integer, Integer> kvp : freqMap.entrySet()){
        //     if(pq.size() < k){
        //         pq.offer(new int[]{kvp.getKey(), kvp.getValue()});
        //     } else if (pq.size() == k && pq.peek()[1] < kvp.getValue()) {
        //         pq.poll();
        //         pq.offer(new int[]{kvp.getKey(), kvp.getValue()});
        //     }
        // }

        // int i = 0;
        // int[] result = new int[k];

        // while(!pq.isEmpty()){
        //     var pqval = pq.poll();
        //     result[i] = pqval[0];
        //     i++;
        // }

        // return result;

        return topKBucketSort(nums, k);
    }
    private int[] topKBucketSort(int[] nums, int k){
        Map<Integer, Integer> map = new HashMap<>();

        for(var num : nums){
            map.put(num, map.getOrDefault(num,0) + 1);
        }

        List<Integer>[] buckets = new ArrayList[nums.length + 1];

        for(Map.Entry<Integer, Integer> kvp : map.entrySet()){
            int num = kvp.getKey();
            int freq = kvp.getValue();

            if(buckets[freq] == null){
                buckets[freq] = new ArrayList<>();
            }
            buckets[freq].add(num);
        }

        List<Integer> result = new ArrayList<>();

        for(int i=buckets.length - 1;i>=0; i--){
            if(buckets[i] == null){
                continue;
            }

            for(int x: buckets[i]){
                result.add(x);

                if(result.size() == k){
                    return result.stream().mapToInt(j -> j).toArray();
                }
            }
        }

        return result.stream().mapToInt(j -> j).toArray();
    }
}
