public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> mapping = new() {{')', '('}, {'}', '{'}, {']', '['}};
        Stack<char> brackets = new();
        foreach(var bracket in s.ToCharArray())
        {
            if(mapping.ContainsKey(bracket)) // then is a close bracket
            {
                if (brackets.Count == 0 || brackets.Pop() != mapping[bracket])
                {
                    return false;
                }
            }
            else
            {
                brackets.Push(bracket);
            }
        }
        return brackets.Count == 0;
    }
}
