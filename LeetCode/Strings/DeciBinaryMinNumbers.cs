namespace LeetCode.Strings;

/// <summary>
/// A decimal number is called deci-binary if each of its digits is either 0 or 1 without any leading zeros.
/// For example, 101 and 1100 are deci-binary, while 112 and 3001 are not.
/// Given a string n that represents a positive decimal integer,
/// return the minimum number of positive deci-binary numbers needed so that they sum up to n.
/// 
/// Example 1:
/// 
/// Input: n = "32"
/// Output: 3
/// Explanation: 10 + 11 + 11 = 32
/// https://leetcode.com/problems/partitioning-into-minimum-number-of-deci-binary-numbers/
/// </summary>
public class DeciBinaryMinNumbers
{
    public int MinPartitions(string n)
    {
        int max = int.MinValue;
        for (var i = 0; i < n.Length; i++)
        {
            var num = int.Parse(n.Substring(i,1));
            if (num > max)
                max = num;
        }

        return max;
    }
}