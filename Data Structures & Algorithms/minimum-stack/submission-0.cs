public class MinStack {
    
    internal Stack<int> stack;

    public MinStack() {
        stack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return stack.Min();
    }
}
