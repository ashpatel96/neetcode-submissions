class Solution {
    public void islandsAndTreasure(int[][] grid) {
        if(grid == null || grid.length == 0 || grid[0].length == 0){
            return;
        }
        
        Deque<int[]> q = new ArrayDeque<>();

        int[][] dirs = new int[][]{
            new int[] {0, 1},
            new int[] {0, -1},
            new int[] {1, 0},
            new int[] {-1, 0}
        };
        
        for(int r = 0; r < grid.length; r++){
            for(int c=0; c < grid[0].length; c++){
                if(grid[r][c] == 0){
                    q.offer(new int[]{r,c});
                }
            }
        }
        int distance = 1;
        while(!q.isEmpty()){
            int size = q.size();

            for(int i=0; i< size; i++){
                int[] curr = q.poll();

                for(int[] dir : dirs){
                    int nr = curr[0] + dir[0];
                    int nc = curr[1] + dir[1];

                    if(nr < 0 || nr >= grid.length || nc < 0 || nc >= grid[0].length || grid[nr][nc] == -1 ||
                       grid[nr][nc] != Integer.MAX_VALUE){
                        continue;
                    }

                    //grid[nr][nc] = Math.min(grid[curr[0]][curr[1]], grid[nr][nc]) + 1;
                    if(grid[nr][nc] == Integer.MAX_VALUE){
                        q.offer(new int[] {nr, nc});
                         grid[nr][nc] = distance;
                    }
                }
            }
            distance++;
        }
    }
}
