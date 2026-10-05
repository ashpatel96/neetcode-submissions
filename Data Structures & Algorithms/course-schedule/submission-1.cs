public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        
        int[] inDegree = new int[numCourses];
        Dictionary<int, List<int>> adjList = new();
        Queue<int> q = new();

        int courses = 0;

        foreach(var prereq in prerequisites){
            if(!adjList.TryGetValue(prereq[1], out var neighbors)){
                neighbors = new List<int>();
                adjList[prereq[1]] = neighbors;
            }
            neighbors.Add(prereq[0]);
            inDegree[prereq[0]]++;
        }

        for(int i=0; i < numCourses; i++){
            if(inDegree[i] == 0){
                q.Enqueue(i);
                courses++;
            }
        }

        if(q.Count == 0 && numCourses > 0) {
            return false;
        }

        while(q.Count>0){
            int curr = q.Dequeue();

            if(adjList.ContainsKey(curr)){
                foreach(var neighbor in adjList[curr]){
                    inDegree[neighbor]--;
                    if(inDegree[neighbor] == 0){
                        q.Enqueue(neighbor);
                        courses++;
                    }
                }
            }
        }

        return courses == numCourses;
    }
}
