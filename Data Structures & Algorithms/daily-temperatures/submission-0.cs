public class Solution {
    /*
        Stack            i           tempratures         result
        0                0           30                  [0]
        1                1           38                  [1]
   [1,2]                 2           30                  [1, 0, 0] 
                         3           36                  [1, 0, 0] 
    
    */
    public int[] DailyTemperatures(int[] temperatures) {
        
        int n = temperatures.Length;
        int[] result = new int[n];
        int i =0;
        Stack<int> stack = new Stack<int>();

        while(i < n ){
            while(stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i]){
                result[stack.Peek()] = i - stack.Peek();
                stack.Pop();                    
            }
            stack.Push(i);
            i++;
        }

        return result;
    }
}
