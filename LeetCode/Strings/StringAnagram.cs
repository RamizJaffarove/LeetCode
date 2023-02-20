namespace LeetCode.Strings;

/// <summary>
/// https://leetcode.com/problems/minimum-number-of-steps-to-make-two-strings-anagram/
/// </summary>
public class StringAnagram
{
    public int MinSteps(string s, string t)
    {
        var tCharCount = new Dictionary<char, int>(t.Length);
        for (int i = 0; i < t.Length; i++)
        {
            if (tCharCount.ContainsKey(t[i]))
                tCharCount[t[i]] += 1;
            else
                tCharCount.Add(t[i], 1);

            if (tCharCount.ContainsKey(s[i]))
                tCharCount[s[i]] -= 1;
            else
                tCharCount.Add(s[i], -1);
        }

        int result = 0;
        foreach (var charCount in tCharCount)
        {
            if (charCount.Value > 0)
                result += charCount.Value;
        }

        return result;
    }
}