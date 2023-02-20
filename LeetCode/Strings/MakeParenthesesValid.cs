namespace LeetCode.Strings;

/// <summary>
/// https://leetcode.com/problems/minimum-add-to-make-parentheses-valid/
/// </summary>
public class MakeParenthesesValid
{
    public int MinAddToMakeValid(string s)
    {
        int opened = 0;
        int result = 0;
        foreach (var ch in s)
        {
            if (ch == '(')
                opened += 1;
            else
            {
                if(opened == 0)
                    result += 1;
                else
                    opened -= 1;
            }
        }

        return result + opened;
    }
}