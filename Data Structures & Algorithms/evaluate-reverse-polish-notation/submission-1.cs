public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        string[] operation = { "+", "*", "-", "/" };
        for(int i = 0; i < tokens.Length; i++)
        {
            if(operation.Contains(tokens[i]))
            {
                var second = stack.Pop();
                var first = stack.Pop();
                switch(tokens[i])
                {
                    case "+":
                        first += second;
                        break;
                    case "-":
                        first -= second;
                        break;
                    case "*":
                        first *= second;
                        break;
                    case "/":
                        first /= second;
                        break;
                    default:
                        break;
                }
                stack.Push(first);
            } else
            {
                stack.Push(Int32.Parse(tokens[i]));
            }
        }
        return stack.Peek();
    }
}
