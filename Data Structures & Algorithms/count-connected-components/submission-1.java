class Solution {
    public int countComponents(int n, int[][] edges) {
        Set<Integer> visited = new HashSet<>();
        Map<Integer, List<Integer>> adj = new HashMap<>();
        int components =0;

        for(var edge: edges){
            int u = edge[0];
            int v = edge[1];

            if(!adj.containsKey(u)){
                adj.put(u, new ArrayList<>());
            }
            if(!adj.containsKey(v)){
                adj.put(v, new ArrayList<>());
            }

            var ulist = adj.get(u);
            var vlist = adj.get(v);

            ulist.add(v);
            vlist.add(u);
        }

        for(int i=0; i< n; i++){
            if(!visited.contains(i)){
                DFS(i, -1, visited, adj);
                components++;
            }
        }
        return components;
    }
    private void DFS(int node, int parent, Set<Integer> visited, Map<Integer, List<Integer>> adj){
        visited.add(node);
        
        if(adj.containsKey(node)){
            for(var neighbour:adj.get(node)){
                if(node == parent){
                    continue;
                }
                if(!visited.contains(neighbour)){
                    DFS(neighbour, node, visited, adj);
                }
            }
        }
    }
}
