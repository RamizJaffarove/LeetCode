namespace LeetCode.Strings;

public class FindReplacePattern
{
    public IList<string> FindAndReplace(string[] words, string pattern)
    {
        var result = new List<string>(words.Length);
        result.AddRange(words.Where(word => IsMatch(word, pattern)));

        return result;
    }

    private bool IsMatch(string word, string pattern)
    {
        if (word.Length != pattern.Length)
            return false;

        var patternToWord = new Dictionary<char, char>();
        var wordToPattern = new Dictionary<char, char>();
        bool isMatch = true;
        for (var i = 0; i < pattern.Length && isMatch; i++)
        {
            var p = pattern[i];
            var w = word[i];
            if (!patternToWord.ContainsKey(p) && !wordToPattern.ContainsKey(w))
            {
                patternToWord[p] = w;
                wordToPattern[w] = p;
            }
            else
            {
                isMatch = patternToWord.ContainsKey(p) 
                          && wordToPattern.ContainsKey(w) 
                          && patternToWord[p] == w
                          && wordToPattern[w] == p;
            }
        }

        return isMatch;
    }
}