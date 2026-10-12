public class MinStack {

    /*
        1 , 2, 0
        reg stack -> 1 , 2, 0
        min stack -> 1 -> 0
        pop -> reg stack : 0 min stack
    */
    Stack<int> stack = null;
    Stack<int> minStack = null;
    
    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(minStack.Count == 0 || minStack.Peek() >= val){
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        if(stack.Count() > 0){
            int peek = stack.Pop();
            if(minStack.Count > 0 && minStack.Peek() == peek){
                minStack.Pop();
            }
        }
    }
    
    public int Top() {
        return stack.Peek();        
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
