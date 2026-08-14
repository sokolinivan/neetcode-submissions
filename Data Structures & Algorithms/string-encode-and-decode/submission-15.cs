public class Solution {
    private static char delimiter = '\u001F';

    public string Encode(IList<string> strs) 
    {   
        if(strs.Count() == 0) 
        {
            return string.Empty;
        }

        var sb = new StringBuilder();
        
        foreach (var str in strs)
        {
            sb.Append(str).Append(delimiter);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) 
    {
        if (s.Length == 0 || s == string.Empty) return new List<string>();

        var result = new List<string>();
        int i = 0;
        int prevDelimiterIndex = 0;

        while (i < s.Length)
        {
            if (s[i] == delimiter) 
            {
                Console.WriteLine($"p: {prevDelimiterIndex}");
                Console.WriteLine($"i - 1: {i}");
                result.Add(s.Substring(prevDelimiterIndex, i - prevDelimiterIndex));
                prevDelimiterIndex = i + 1;
            }
            i++;
        }

        return result;
    }
}
