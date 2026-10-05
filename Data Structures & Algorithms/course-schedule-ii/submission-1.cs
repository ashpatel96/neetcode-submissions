public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        
        int[] indegree = new int[numCourses];
        Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
        List<int> courses = new List<int>();
        Queue<int> q = new Queue<int>();

        foreach(var preq in prerequisites){
            if(!adjList.TryGetValue(preq[1], out var neighbors)){
                neighbors = new List<int>();
                adjList[preq[1]] = neighbors;
            }
            neighbors.Add(preq[0]);
            indegree[preq[0]]++;
        }

        for(int i=0; i < numCourses; i++){
            if(indegree[i] == 0){
                q.Enqueue(i);
                courses.Add(i);
            }
        }

        // if(q.Count == 0 && numCourses > 0){
        //     return new int[0];
        // }

        while(q.Count > 0){
            int curr = q.Dequeue();

            if(adjList.ContainsKey(curr)){
                foreach(int neighbor in adjList[curr]){
                    indegree[neighbor]--;
                    if(indegree[neighbor] == 0){
                        q.Enqueue(neighbor);
                        courses.Add(neighbor);
                    }
                }
            }
        }

        return courses.Count == numCourses ? courses.ToArray() : new int[0];
    }
}
