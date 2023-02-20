namespace LeetCode.Strings;

public class PartitionLabels
{
    public IList<int> Calculate(string s)
    {
        var result = new List<int>();
        if (string.IsNullOrEmpty(s))
            return result;

        int startPartitionIndex = 0;
        for (int nextPartitionIndex = 0; nextPartitionIndex < s.Length;)
        {
            nextPartitionIndex = ToNextPartition(s, startPartitionIndex);
            result.Add(nextPartitionIndex - startPartitionIndex);
            startPartitionIndex = nextPartitionIndex;
        }

        return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"></param>
    /// <param name="startIndex"></param>
    /// <returns>Start index of the next partition</returns>
    private int ToNextPartition(string s, int startIndex)
    {
        int lastIndex = startIndex;
        var partitionSigns = new HashSet<char>();
        var tempSigns = new HashSet<char>();
        var partitionSign = s[startIndex];

        for (int i = startIndex + 1; i < s.Length;)
        {
            if (s[i] == partitionSign)
            {
                lastIndex = i;
                partitionSigns.UnionWith(tempSigns);
            }
            else
            {
                tempSigns.Add(s[i]);
            }

            i++;
            if (i == s.Length)
            {
                tempSigns.Clear();
                i = lastIndex+1;
                if (partitionSigns.Count > 0)
                {
                    partitionSign = partitionSigns.First();
                    partitionSigns.Remove(partitionSign);
                }
                else
                {
                    break;
                }
            }
        }

        return lastIndex + 1;
    }
}