class Solution {
    public void solve(char[][] board) {
        int[][] dirs = new int[][]{
            new int[] {0, 1},
            new int[] {0, -1},
            new int[] {1, 0},
            new int[] {-1, 0},
        };

        int rows = board.length;
        int cols = board[0].length;

        for(int r = 0; r < rows; r++){
            dfs(board, r, 0, dirs);
            dfs(board, r, cols -1 , dirs);
        }

        for(int c = 0; c < cols; c++){
            dfs(board, 0, c, dirs);
            dfs(board, rows -1, c, dirs);
        }

        for(int r = 0; r < rows; r++){
            for(int c = 0; c < cols; c++){
                if(board[r][c] == 'O'){
                    board[r][c] = 'X';
                } else if (board[r][c] == 'T'){
                    board[r][c] = 'O';
                }
            }
        }
    }

    private void dfs(char[][] board, int x, int y, int[][] dirs){
        if(x < 0 || x >= board.length ||
           y < 0 || y >= board[0].length ||
           board[x][y] != 'O'){
            return;
        }

        board[x][y] = 'T';

        for(var dir: dirs){
            dfs(board, x + dir[0], y, dirs);
            dfs(board, x, y + dir[1], dirs);
        }
    }
}
