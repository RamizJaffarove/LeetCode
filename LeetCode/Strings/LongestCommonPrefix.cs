namespace LeetCode.Strings;

public class LongestCommonPrefix
{
    public string Calculate(string[] strs)
    {
        string prefix = string.Empty;
        for (int i = 0; ; i++)
        {
            if (i > strs[0].Length)
                return prefix;

            prefix = strs[0].Substring(0, i);
            for (int j = 1; j < strs.Length; j++)
            {
                if (i > strs[j].Length)
                    return prefix.Substring(0, prefix.Length - 1);

                if (strs[j].Substring(0, i) != prefix)
                    return prefix.Substring(0, prefix.Length - 1);
            }
        }
    }
}