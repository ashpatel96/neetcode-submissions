class Solution {
    public int orangesRotting(int[][] grid) {
        int freshFruits = 0;
        int mins = 0;

        Deque<int[]> q = new ArrayDeque<>();
        int[][] dirs = new int[][]{
            new int[] {0, 1},
            new int[] {0, -1},
            new int[] {1, 0},
            new int[] {-1, 0},
        };

        for(int r = 0; r < grid.length; r++){
            for(int c = 0; c < grid[0].length; c++){
                if(grid[r][c] == 1) {
                    freshFruits++;
                } else if (grid[r][c] == 2) {
                    q.offer(new int[]{r,c});
                }
            }
        }

        if(freshFruits == 0) return 0;
        
        while(q.size() > 0 && freshFruits > 0){
            int levelSize = q.size();

            for(int i = 0; i < levelSize; i++){
                var curr = q.poll();
                int x = curr[0];
                int y = curr[1];

                for(var dir: dirs){
                    int xx = x + dir[0];
                    int yy = y + dir[1];

                    if(xx < 0 || xx >= grid.length || 
                       yy < 0 || yy >= grid[0].length || 
                       grid[xx][yy] != 1 ){
                        continue;
                    }
                    grid[xx][yy] = 2;
                    freshFruits--;
                    q.offer(new int[] {xx, yy});
                }
            }
            mins++;
        }
        return freshFruits == 0 ? mins : -1;        
    }
}
