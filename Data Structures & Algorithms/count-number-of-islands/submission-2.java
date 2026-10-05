class Solution {
    public int numIslands(char[][] grid) {
        
        int island =0;
        for(int r=0; r < grid.length; r++){
            for(int c=0; c < grid[0].length; c++){
                if(grid[r][c] == '1'){
                    DFS(grid, r, c);
                    island++;
                }
            }
        }
        return island;
    }

    private void DFS(char[][] grid, int x, int y){
        if(x < 0 || x >=grid.length || y < 0 || y >= grid[0].length || grid[x][y] != '1'){
            return;
        }
        grid[x][y] = '0';

        DFS(grid, x + 1, y);
        DFS(grid, x - 1, y);
        DFS(grid, x, y + 1);
        DFS(grid, x, y- 1);
    }
}
