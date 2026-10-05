public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        List<string> result= new List<string>();
        GenerateParenthesis(n, n, string.Empty, result);
        return result;
    }

    private void GenerateParenthesis(int leftParenthes, int rightParenthes, string str, List<string> result){
        if (leftParenthes ==0 && rightParenthes ==0){
            result.Add(str);            
        } else {
            if(leftParenthes > 0){
                GenerateParenthesis(leftParenthes -1, rightParenthes, str + "(", result);
            }
            if(leftParenthes < rightParenthes){
                GenerateParenthesis(leftParenthes, rightParenthes - 1, str + ")", result);
            }
        }
    }

}
