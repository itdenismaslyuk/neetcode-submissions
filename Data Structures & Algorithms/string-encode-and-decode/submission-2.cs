public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        for(int i = 0; i < strs.Count; i++)
        {
            sb.Append($"{strs[i].Length}#{strs[i]}");
        }
        return sb.ToString();
    }

   public List<string> Decode(string s) {
        var list = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            int delimiterIndex = s.IndexOf('#', i);

            int length = int.Parse(s.Substring(i, delimiterIndex - i));

            int start = delimiterIndex + 1;

            string str = s.Substring(start, length);

            list.Add(str);

            i = start + length;
        }

        return list;
    }
}
