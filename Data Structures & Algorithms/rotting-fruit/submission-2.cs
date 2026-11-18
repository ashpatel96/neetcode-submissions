public class Solution {
    public int OrangesRotting(int[][] grid) {
        int freshFruits = 0;
        int mins = 0;

        Queue<int[]> q = new Queue<int[]>();

        int[][] dirs = new int[][] {
            new int[] {0, 1},
            new int[] {0, -1},
            new int[] {1, 0},
            new int[] {-1, 0},
        };

        for(int r = 0; r < grid.Length; r++) {
            for(int c = 0; c < grid[0].Length; c++){
                if(grid[r][c] == 1){
                    freshFruits++;
                } else if(grid[r][c] == 2) {
                    q.Enqueue(new int[]{r, c});
                }
            }
        }

        if(freshFruits == 0) {
            return 0;
        }

        while(q.Count > 0 && freshFruits > 0) {
            int size = q.Count;

            for(int i = 0; i < size; i++) {
                var curr = q.Dequeue();
                int x = curr[0];
                int y = curr[1];

                foreach(var dir in dirs){
                    int xx = x + dir[0];
                    int yy = y + dir[1];

                    if(xx < 0 || xx >= grid.Length ||
                       yy < 0 || yy >= grid[0].Length||
                       grid[xx][yy]!=1){
                        continue;
                    }

                    grid[xx][yy] = 2;
                    freshFruits--;

                    q.Enqueue(new int[]{xx, yy});
                }
            }
            mins++;
        }
        return freshFruits == 0 ? mins : -1;
    }
}
