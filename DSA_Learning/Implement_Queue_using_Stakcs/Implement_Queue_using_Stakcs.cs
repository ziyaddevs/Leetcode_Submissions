public class MyQueue {
    private Stack<int> inputStack;
    private Stack<int> outputStack;

    public MyQueue() {
        inputStack = new Stack<int>();
        outputStack = new Stack<int>();
        
    }
    
    public void Push(int x) {
        inputStack.Push(x);
        
    }
    
    public int Pop() {
        ShiftStack();
        return outputStack.Pop();        
    }
    
    public int Peek()
    {
        ShiftStack();
        return outputStack.Peek();
    }
    
    public bool Empty()
    {
        return inputStack.Count == 0 && outputStack.Count == 0;
    }

    private void ShiftStack()
    {
        if(outputStack.Count == 0)
        {
            while(intputStack.Count > 0)
            {
                outputStack.Push(inputStack.Pop());
            }
        }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */