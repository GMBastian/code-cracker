public class Solution {
    public bool IsValid(string s) {
        Stack<Char> stack = new Stack<Char>();
        var charArray = s.ToCharArray();

        for(int i = 0; i < charArray.Length ; i++)
        {
            if(charArray[i] == '(' || charArray[i] == '[' || charArray[i] == '{'){
              stack.Push(charArray[i]); 
              continue; 
            }else if(stack.Count == 0)
            return false;
            Char top = stack.Pop();
            if(top == '(' && charArray[i] != ')')
            return false;
            if(top == '[' && charArray[i] != ']')
            return false;
            if(top == '{' && charArray[i] != '}')
            return false;
        } 
        return stack.Count == 0;
    }
}
