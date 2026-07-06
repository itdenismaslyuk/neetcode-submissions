public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        
        foreach(char c in s) {
            if(c == '(' || c == '{' || c == '[') {
                // Открывающая скобка - кладем в стек
                stack.Push(c);
            } else {
                // Закрывающая скобка - проверяем соответствие
                if(stack.Count == 0) {
                    return false; // Закрывающая без открывающей
                }
                
                char top = stack.Pop();
                
                // Проверяем, что последняя открывающая соответствует закрывающей
                if(c == ')' && top != '(') return false;
                if(c == '}' && top != '{') return false;
                if(c == ']' && top != '[') return false;
            }
        }
        
        // Стек должен быть пустым (все скобки закрыты)
        return stack.Count == 0;
    }
}