public class Solution {
    public int CountComponents(int n, int[][] edges) {
        HashSet<int> visited = new HashSet<int>();
        Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();
        int components = 0;

        foreach(var edge in edges){
            int u = edge[0];
            int v = edge[1];

            if(!adj.ContainsKey(u)){
                adj[u] = new List<int>();
            }
            if(!adj.ContainsKey(v)){
                adj[v] = new List<int>();
            }

            adj[u].Add(v);
            adj[v].Add(u);
        }
        for(int i=0;i<n;i++){
            if(visited.Add(i)){
                DFS(i, -1, visited, adj);
                components++;
            }
        }
        return components;
    }
    private void DFS(int node, int parent, HashSet<int> visited, Dictionary<int, List<int>> adj){
        visited.Add(node);

        if(adj.ContainsKey(node)){
            foreach(var neighbour in adj[node]){
                if(neighbour == parent){
                    continue;
                }
                if(!visited.Contains(neighbour)){
                    DFS(neighbour, node, visited, adj);
                }
            }
        }
    }
}
