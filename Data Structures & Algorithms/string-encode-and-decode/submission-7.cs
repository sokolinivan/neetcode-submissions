public class Solution {

    public string Encode(IList<string> strs) {
        var encode = "";
        foreach(var s in strs) {
            encode = encode + s.Length.ToString() + '#' + s;
        }
        return encode;
    }

    public List<string> Decode(string str) {
        List<string> result = new List<string>();


        int idx = 0;
        while (idx < str.Length) {
            int length = 0;
            while (str[idx] != '#') {
                length = length * 10 + (str[idx] - '0');
                idx++;
            }
            idx++;
            result.Add(str.Substring(idx, length));
            idx += length;
        }
        
        // var buff = string.Empty;
        
        // for (int i = 0; i < str.Length; i++)
        // {
        //     if (str[i] != '#')
        //     {
        //         buff += str[i];
        //         continue;
        //     }

        //     var length = int.Parse(buff);
            
        //     result.Add(str.Substring(i + 1, length));
            
        //     buff = string.Empty;
        //     i += length;
        // }
        
        return result;
    }
}
