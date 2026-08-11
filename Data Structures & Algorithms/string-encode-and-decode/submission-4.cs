public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();

        foreach (var str in strs)
        {
            sb.Append($"{str.Length}#{str}");
        }

        return sb.ToString();
    }

    public List<string> Decode(string str) {
        List<string> result = new List<string>();
        
        var buff = string.Empty;
        
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != '#')
            {
                buff += str[i];
                continue;
            }

            var length = int.Parse(buff);
            
            result.Add(str.Substring(i + 1, length));
            
            buff = string.Empty;
            i += length;
        }
        
        return result;
    }
}
