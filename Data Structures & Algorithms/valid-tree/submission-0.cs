public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();

        for(int i=0; i < n; i++){
            adj[i] = new List<int>();
        }

        foreach(var edge in edges){
            int u = edge[0];
            int v = edge[1];

            adj[u].Add(v);
            adj[v].Add(u);
        }

        bool[] visited = new bool[n];

        if(IsCycle(0, -1, visited, adj)){
            return false;
        }

        for(int i=0; i < n; i++){
            if(!visited[i]){
                return false;
            }
        }

        return true;

    }

    private bool IsCycle(int node, int parent, bool[] visited, Dictionary<int, List<int>> adj){
        visited[node] = true;

        foreach(var neighbor in adj[node]){
            if(neighbor == parent){
                continue;
            }
            if(visited[neighbor]){
                return true;
            }
            if(IsCycle(neighbor, node, visited, adj)){
                return true;
            }
        }
        return false;
    }
}
