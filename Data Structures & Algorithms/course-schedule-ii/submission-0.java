class Solution {
    public int[] findOrder(int numCourses, int[][] prerequisites) {
        
        int[] indegree = new int[numCourses];
        Map<Integer, List<Integer>> adjList = new HashMap<>();
        Deque<Integer> q = new ArrayDeque<>();
        List<Integer> result = new ArrayList<>();

        for(var prereq : prerequisites){
            adjList.computeIfAbsent(prereq[1], k -> new ArrayList<>()).add(prereq[0]);
            indegree[prereq[0]]++;
        }

        for(int i=0; i < numCourses; i++){
            if(indegree[i] == 0){
                q.offer(i);
                result.add(i);
            }
        }

        if(q.isEmpty() && numCourses > 0){
            return new int[0];
        }
        
        while(!q.isEmpty()){
            int curr = q.poll();

            if(adjList.containsKey(curr)){
                for(var nextCourses : adjList.get(curr)){
                    indegree[nextCourses]--;
                    if(indegree[nextCourses] == 0){
                        q.offer(nextCourses);
                        result.add(nextCourses);
                    }
                }
            }
        }
        return result.size() == numCourses ? result.stream().mapToInt(Integer::intValue).toArray() : new int[0];
    }
}
