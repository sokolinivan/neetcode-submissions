public class Solution {

    public string Encode(IList<string> strs) {
		StringBuilder builder = new StringBuilder();

		for (int i = 0; i < strs.Count; i++)
		{
			builder.Append(strs[i] + '\n');
		}

		return builder.ToString();
    }

    public List<string> Decode(string s) {
		string buf = string.Empty;
		List<string> result = new List<string>();
		
		for (int i = 0; i < s.Length; i++) {
			if (s[i] != '\n') {
				buf += s[i];
			} else {
				result.Add(buf);
				buf = string.Empty;
			}
		}
		
		return result;
   }
}
