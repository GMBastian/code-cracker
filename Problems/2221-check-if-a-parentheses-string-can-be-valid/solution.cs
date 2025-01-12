public class Solution {
    public bool CanBeValid(string s, string locked) {
        if(s.Length % 2 == 1)
            return false;
        Stack<int> openBrackets = new();
        Stack<int> unlocked = new();
        for(int i = 0; i < s.Length; i++)
        {
            if(locked[i] == '0')
                unlocked.Push(i);
            else if(s[i] == '(')
                openBrackets.Push(i);
            else if(s[i] == ')')
            {
                if(openBrackets.Count > 0)
                    openBrackets.Pop();
                else if(unlocked.Count > 0)
                    unlocked.Pop();
                else 
                    return false;
            }
        }
        while(
            openBrackets.Count > 0 &&
            unlocked.Count > 0 && 
            openBrackets.Peek() < unlocked.Peek()
        )
        {
            openBrackets.Pop();
            unlocked.Pop();
        }

        return openBrackets.Count == 0;
    }
}
