public class Solution {
    public bool Exist(char[][] board, string word) {
        if(word.Length == 0 || board.Length == 0) {
            return false;
        }
        for(int i=0; i < board.Length; i++) {
            for(int j=0; j < board[0].Length; j++){
                if(IsExist(board, i, j, word, 0)){
                    return true;
                }
            }
        }

        return false;
    }

    private bool IsExist(char[][] board, int x, int y, string word, int idx) {
        // base case
        if(idx == word.Length){
            return true;
        }

        //boundry check
        if(x < 0 || x >= board.Length || y < 0 || y >= board[0].Length) {
            return false;
        }

        // character match check
        if(board[x][y] != word[idx]){
            return false;
        }

        //choose
        char temp = board[x][y];
        board[x][y] = '#';
        //explorer
        bool res = IsExist(board, x + 1, y, word, idx + 1) ||
                   IsExist(board, x - 1, y, word, idx + 1) ||
                   IsExist(board, x, y + 1, word, idx + 1) ||
                   IsExist(board, x, y - 1, word, idx + 1);
        //backtrack
        board[x][y] = temp;

        return res;
    }
}
