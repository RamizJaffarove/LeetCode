namespace LeetCode.Strings;

public class TinyUrl
{
    private readonly Dictionary<int, string> _urlHashes = new();
    private const string TinyUrlPrefix = "https://tinyurl.com/";

    // Encodes a URL to a shortened URL
    public string Encode(string longUrl)
    {
        int urlHashCode = longUrl.GetHashCode();
        _urlHashes.Add(urlHashCode, longUrl);

        return $"{TinyUrlPrefix}{urlHashCode}";
    }

    // Decodes a shortened URL to its original URL.
    public string Decode(string shortUrl)
    {
        var hashCodeStr = shortUrl.Replace(TinyUrlPrefix, string.Empty);
        return _urlHashes[int.Parse(hashCodeStr)];
    }
}