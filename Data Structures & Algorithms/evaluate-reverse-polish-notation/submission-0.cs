public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();

        foreach(var token in tokens){
            if(IsOpertor(token)){
                int operator2 = stack.Pop();
                int operator1 = stack.Pop();
                int val = token switch {
                    "+" => operator1 + operator2,
                    "-" => operator1 - operator2,
                    "*" => operator1 * operator2,
                    "/" => operator1 / operator2,
                    _ => 0
                };
                stack.Push(val);
            }
            else {
                stack.Push(int.Parse(token));
            }
        }
        return stack.Pop();
    }

    private bool IsOpertor(string token){
        return token == "+" || token == "-" || token == "*" || token == "/";
    }
}
