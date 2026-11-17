public class Solution {
    public void Solve(char[][] board) {
        
        int[][] dirs = new int[][]{
            new int[] {0, 1},
            new int[] {0, -1},
            new int[] {1, 0},
            new int[] {-1, 0}
        };

        int rows = board.Length;
        int cols = board[0].Length;

        //Mark boundry to T
        for(int r = 0; r < rows; r++){
            DFS(board, r, 0, dirs);
            DFS(board, r, cols - 1, dirs);
        }

        for(int c =0; c < board[0].Length; c++){
            DFS(board, 0, c, dirs);
            DFS(board, rows - 1, c, dirs);
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

    private void DFS(char[][] board, int x, int y, int[][] dirs){
        if(x < 0 || x >= board.Length || 
           y < 0 || y >= board[0].Length || 
           board[x][y] != 'O'){
            return;
        }

        board[x][y] = 'T';

        foreach(var dir in dirs){
            DFS(board, x + dir[0] , y + dir[1], dirs);
        }
    }
}
