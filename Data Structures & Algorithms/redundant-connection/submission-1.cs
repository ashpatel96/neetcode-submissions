public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        List<List<int>> adj = new List<List<int>>();

        for(int i=0; i <= edges.Length; i++){
            adj.Add(new List<int>());
        }

        foreach(var edge in edges){
            int u = edge[0];
            int v = edge[1];

            adj[u].Add(v);
            adj[v].Add(u);
            bool[] visited = new bool[edges.Length + 1];

            if(DFS(u, -1, visited, adj)){
                return new int[] {u, v};
            }
        }
        return new int[0];
    }

    private bool DFS(int node, int parent, bool[] visited, List<List<int>> adj){
        
        visited[node] = true;

        foreach(var neighbor in adj[node]){
            if(neighbor == parent){
                continue;
            }
            if(visited[neighbor] || DFS(neighbor, node, visited, adj)){
                return true;
            }
        }
        return false;
    }
}
