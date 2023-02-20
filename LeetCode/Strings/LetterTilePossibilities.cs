namespace LeetCode.Strings;

/// <summary>
/// https://leetcode.com/problems/letter-tile-possibilities/
/// </summary>
public class LetterTilePossibilities
{ 
    public int NumTilePossibilities(string tiles)
    {
        var combinationsSet = new HashSet<string>();
        for (int i = 0; i < tiles.Length; i++)
        {
            var subStr = tiles.Substring(0, i+1);
            SetAllCombinations(subStr, combinationsSet, 0);
        }

        return combinationsSet.Count;
    }

    private void SetAllCombinations(string str, HashSet<string> combinations, int startIndex)
    {
        if (combinations == null) 
            throw new ArgumentNullException(nameof(combinations));

        if (startIndex < 0)
            throw new ArgumentOutOfRangeException(nameof(startIndex));

        if (str.Length == 1)
        {
            combinations.Add(str);
            return;
        }

        if (str.Length == 0 || startIndex >= str.Length - 1)
            return;

        var ch = str.Substring(startIndex, 1);
        var tmpStr = str.Remove(startIndex, 1);

        for (int i = 0; i < tmpStr.Length; i++)
        {
            if(i == startIndex) continue;

            var combination = tmpStr.Insert(i, ch);
            combinations.Add(combination);
        }

        SetAllCombinations(str, combinations, startIndex + 1);
    }
}