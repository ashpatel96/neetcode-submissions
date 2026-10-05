class Solution {
    public boolean canFinish(int numCourses, int[][] prerequisites) {
        
        Map<Integer, List<Integer>> adjList = new HashMap<>();
        int[] inDegree = new int[numCourses];

        for(var prereq: prerequisites){
            adjList.computeIfAbsent(prereq[1], k -> new ArrayList<>()).add(prereq[0]);
            inDegree[prereq[0]]++;
        }

        Deque<Integer> q = new ArrayDeque<>();
        int courses = 0;

        for(int i=0; i < inDegree.length; i++){
            if(inDegree[i] == 0){
                q.offer(i);
                courses++;
            }
        }

        while(!q.isEmpty()){
            int curr = q.poll();

            if(adjList.containsKey(curr)){
                for(int neighbor : adjList.get(curr)){
                    inDegree[neighbor]--;

                    if(inDegree[neighbor]== 0){
                        q.offer(neighbor);
                        courses++;
                    }
                }
            }
        }

        return courses == numCourses;
    }
}
