public class MinStack {

    private Stack<int> mainStack;
    private Stack<int> minStack;

    public MinStack() {
        mainStack = new Stack<int>();
        minStack = new Stack<int>();
        
    }
    
    public void Push(int value) {
        mainStack.Push(value);

        if(minStack.Count == 0 || value <= minStack.Peek())
        {
            minStack.Push(value);
        }
        else
        {
            minStack.Push(minStack.Peek());
        }
        
    }
    
    public void Pop() {
        mainStack.Pop();
        minStack.Pop();
        
    }
    
    public int Top() {
        return mainStack.Peek();
        
    }
    
    public int GetMin() {
        return minStack.peek();
        
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(value);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */